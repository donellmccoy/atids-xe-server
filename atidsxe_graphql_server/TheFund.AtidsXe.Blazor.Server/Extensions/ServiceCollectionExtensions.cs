using Ensure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Blazor;
using TheFund.AtidsXe.Blazor.Server.Data;
using TheFund.AtidsXe.Blazor.Server.DataAdaptors;
using TheFund.AtidsXe.Blazor.Server.Options;
using TheFund.AtidsXe.Blazor.Server.Services;
using TheFund.AtidsXe.Blazor.Server.Utility;

namespace TheFund.AtidsXe.Blazor.Server.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureBlazor(this IServiceCollection services)
        {
            services.EnsureNotNull();

            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSyncfusionBlazor();

            return services;
        }

        public static IServiceCollection ConfigureCaching(this IServiceCollection services)
        {
            services.EnsureNotNull();

            services.AddMemoryCache();
            services.AddSingleton<ITaskCache, TaskCache>();

            return services;
        }

        public static IServiceCollection ConfigureGraphQL(this IServiceCollection services, IConfiguration configuration)
        {
            services.EnsureNotNull();
            configuration.EnsureNotNull();

            return services;
        }

        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.EnsureNotNull();

            services.AddSingleton<WeatherForecastService>();
            services.AddSingleton<SearchResultsAdaptor>();

            services.AddSingleton<IDataService, DataService>();
            services.AddSingleton<IGraphQLService, GraphQLService>();

            return services;
        }

        public static IServiceCollection ConfigureOptions(this IServiceCollection services, IConfiguration configuration)
        {
            services.EnsureNotNull();
            configuration.EnsureNotNull();

            services.AddOptions();

            services.Configure<GraphQLServiceOptions>(configuration.GetSection(GraphQLServiceOptions.SectionName));

            return services;
        }
    }
}
