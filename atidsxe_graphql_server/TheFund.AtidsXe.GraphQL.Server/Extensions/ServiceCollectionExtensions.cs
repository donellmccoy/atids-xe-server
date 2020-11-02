using Ensure;
using HotChocolate;
using HotChocolate.Execution;
using HotChocolate.Execution.Configuration;
using HotChocolate.Types;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;
using TheFund.AtidsXe.Data.Context;
using TheFund.AtidsXe.GraphQL.Server.Data;
using TheFund.AtidsXe.GraphQL.Server.Mutations;
using TheFund.AtidsXe.GraphQL.Server.Options;
using TheFund.AtidsXe.GraphQL.Server.Queries;

namespace TheFund.AtidsXe.GraphQL.Server.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureGraphQL([NotNull] this IServiceCollection services, [NotNull] IConfiguration configuration)
        {
            services.EnsureNotNull();

            var options = configuration.GetOption<QueryExecutionOptions>();

            services.AddRedisQueryStorage(_ => ConnectionMultiplexer.Connect("localhost:6379").GetDatabase(0));

            services.AddGraphQL(sp => SchemaBuilder.New()
                                                   .AddServices(sp)
                                                   .AddQueryType(d => d.Name("Query"))
                                                   .AddType<FileReferenceQueries>()
                                                   .AddType<SearchQueries>()
                                                   .AddType<TitleEventSearchQueries>()
                                                   .AddType<BranchLocationQueries>()
                                                   .AddType<ChainOfTitlesQueries>()
                                                   .AddType<WorksheetQueries>()
                                                   .AddType<ExaminationStatusTypeQueries>()
                                                   .AddType<ChainOfTitleCategoryTypeQueries>()
                                                   .AddType<TitleEventTypeQueries>()
                                                   .AddType<FileStatusQueries>()
                                                   .AddExportDirectiveType()
                                                   .AddMutationType(d => d.Name("Mutation"))
                                                   .AddType<FileReferenceMutations>()
                                                   .BindClrType<string, StringType>()
                                                   .Create());

            //.Create(), b => b.UseActivePersistedQueryPipeline(options).AddSha256DocumentHashProvider());

            return services;
        }

        public static IServiceCollection ConfigureOptions([NotNull] this IServiceCollection services, [NotNull] IConfiguration configuration)
        {
            services.EnsureNotNull();
            configuration.EnsureNotNull();

            services.AddOptions();

            services.AddOptions<DatabaseContextOptions>()
                    .Bind(configuration.GetSection<DatabaseContextOptions>())
                    .ValidateDataAnnotations();

            return services;
        }

        public static IServiceCollection ConfigureDbContext([NotNull] this IServiceCollection services, [NotNull] IWebHostEnvironment environment, [NotNull] IConfiguration configuration)
        {
            services.EnsureNotNull();
            environment.EnsureNotNull();
            configuration.EnsureNotNull();
            
            var options = configuration.GetOption<DatabaseContextOptions>();

            if(options.UseInMemoryDatabase)
            {
                services.AddDbContext<ApplicationDbContext>(builder =>
                {
                    builder.EnableDetailedErrors(options.EnableDetailedErrors);
                    builder.UseInMemoryDatabase(options.InMemoryDatabaseName);
                });

                DataGenerator.Initialize(services);
            }
            else
            {
                void CreateOptionsAction(DbContextOptionsBuilder builder)
                {
                    builder.EnableDetailedErrors(options.EnableDetailedErrors);
                    builder.UseQueryTrackingBehavior(options.QueryTrackingBehavior);
                    builder.UseSqlServer
                    (
                        options.ConnectionString,
                        _ =>
                        {
                            _.EnableRetryOnFailure(options.MaxRetryCount, options.MaxRetryDelay, null);
                            _.CommandTimeout(options.CommandTimeout);
                        });
                }

                if (options.EnablePooling)
                {
                    services.AddDbContextPool<ApplicationDbContext>(CreateOptionsAction, options.PoolSize);
                }
                else
                {
                    services.AddDbContext<ApplicationDbContext>(CreateOptionsAction, options.ContextLifetime, options.OptionsLifetime);
                }
            }

            return services;
        }
    
        public static IServiceCollection ConfigureCompression([NotNull] this IServiceCollection services, [NotNull] IConfiguration configuration)
        {
            services.AddResponseCompression(options =>
            {
                options.Providers.Add<GzipCompressionProvider>();
                options.EnableForHttps = true;
                options.MimeTypes = new[] { "application/json" };
            });

            services.Configure((System.Action<GzipCompressionProviderOptions>)(_ => _ = configuration.GetOption<GzipCompressionProviderOptions>()));

            return services;
        }
    }
}
