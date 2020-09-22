using Ensure;
using HotChocolate;
using HotChocolate.Execution.Configuration;
using HotChocolate.Types;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TheFund.AtidsXe.Data.Context;
using TheFund.AtidsXe.GraphQL.Server.Data;
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

            services.AddDataLoaderRegistry()
                    .AddGraphQL(sp => SchemaBuilder.New()
                                                   .AddServices(sp)
                                                   .AddQueryType(d => d.Name("Query"))
                                                       .AddType<FileReferenceQueries>()
                                                       .AddType<BranchLocationQueries>()
                                                       .AddType<FileStatusQueries>()
                                                   .BindClrType<string, StringType>()
                                                   .Create(), options);

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
                services.AddDbContext<ATIDSXEContext>(_ =>
                {
                    _.EnableDetailedErrors(options.EnableDetailedErrors);
                    _.UseInMemoryDatabase(options.InMemoryDatabaseName);
                });

                DataGenerator.Initialize(services);
            }
            else
            {
                void CreateOptionsAction(DbContextOptionsBuilder builder)
                {
                    builder.EnableDetailedErrors(options.EnableDetailedErrors);
                    builder.UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll);
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
                    services.AddDbContextPool<ATIDSXEContext>(CreateOptionsAction, options.PoolSize);
                }
                else
                {
                    services.AddDbContext<ATIDSXEContext>(CreateOptionsAction, options.ContextLifetime, options.OptionsLifetime);
                }
            }

            return services;
        }
    }
}
