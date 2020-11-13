using Ensure;
using JetBrains.Annotations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Blazor;
using TheFund.AtidsXe.Blazor.Server.Data;
using TheFund.AtidsXe.Blazor.Server.Options;
using TheFund.AtidsXe.Blazor.Server.Pages;
using TheFund.AtidsXe.Blazor.Server.Services;
using TheFund.AtidsXe.Blazor.Server.Utility;

namespace TheFund.AtidsXe.Blazor.Server.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureBlazor([NotNull] this IServiceCollection services)
        {
            services.EnsureNotNull();

            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSyncfusionBlazor();

            return services;
        }


        public static IServiceCollection ConfigureCaching([NotNull] this IServiceCollection services)
        {
            services.EnsureNotNull();

            services.AddMemoryCache();
            services.AddSingleton<ITaskCache, TaskCache>();

            return services;
        }

        public static IServiceCollection ConfigureGraphQL([NotNull] this IServiceCollection services, [NotNull] IConfiguration configuration)
        {
            services.EnsureNotNull();
            configuration.EnsureNotNull();


            return services;
        }

        public static IServiceCollection ConfigureServices([NotNull] this IServiceCollection services)
        {
            services.EnsureNotNull();

            services.AddSingleton<WeatherForecastService>();
            services.AddSingleton<SearchResultsAdaptor>();

            services.AddSingleton<IDataService, DataService>();
            services.AddSingleton<IGraphQLService, GraphQLService>();

            return services;
        }

        public static IServiceCollection ConfigureOptions([NotNull] this IServiceCollection services, [NotNull] IConfiguration configuration)
        {
            services.EnsureNotNull();
            configuration.EnsureNotNull();

            services.AddOptions();

            services.Configure<GraphQLServiceOptions>(configuration.GetSection(GraphQLServiceOptions.SectionName));

            return services;
        }
    }
}
