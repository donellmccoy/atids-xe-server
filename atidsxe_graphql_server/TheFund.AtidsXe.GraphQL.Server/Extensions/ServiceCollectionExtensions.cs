using Ensure;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TheFund.AtidsXe.Data.Context;
using TheFund.AtidsXe.GraphQL.Server.Data;
using TheFund.AtidsXe.GraphQL.Server.Options;

namespace TheFund.AtidsXe.GraphQL.Server.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDbContextServices([NotNull] this IServiceCollection services, [NotNull] IWebHostEnvironment environment, [NotNull] IConfiguration configuration)
        {
            services.EnsureNotNull();
            environment.EnsureNotNull();
            configuration.EnsureNotNull();

            var options = configuration.GetSection<DatabaseContextOptions>();

            options.Ensure(p => p != null, $"{nameof(DatabaseContextOptions)} configuration section is missing for environment: {environment.EnvironmentName}");

            if(options.UseInMemoryDatabase)
            {
                services.AddDbContext<ATIDSXEContext>(_=> _.UseInMemoryDatabase(options.InMemoryDatabaseName));
                DataGenerator.Initialize(services);
            }
            else
            {
                void CreateOptionsAction(DbContextOptionsBuilder builder)
                {
                    builder.EnableDetailedErrors(!environment.IsProduction());
                    builder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                    builder.UseSqlServer
                    (
                        options.ConnectionString,
                        _ =>
                        {
                            _.EnableRetryOnFailure(options.MaxRetryCount, options.MaxRetryDelayTimeSpan, null);
                            _.CommandTimeout(options.CommandTimeout);
                        });
                }

                if (options.EnablePooling)
                {
                    services.AddDbContextPool<ATIDSXEContext>(CreateOptionsAction, options.PoolSize);
                }
                else
                {
                    services.AddDbContext<ATIDSXEContext>(CreateOptionsAction, ServiceLifetime.Transient, ServiceLifetime.Transient);
                }
            }

            return services;
        }
    }
}
