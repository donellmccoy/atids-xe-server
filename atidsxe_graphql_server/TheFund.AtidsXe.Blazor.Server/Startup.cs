using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;
using TheFund.AtidsXe.Blazor.Server.Extensions;

namespace TheFund.AtidsXe.Blazor.Server
{
    public class Startup
    {
        #region Fields

        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IConfiguration _configuration;

        #endregion

        public Startup(IWebHostEnvironment environment)
        {
            _hostingEnvironment = environment;

            var configBuilder = new ConfigurationBuilder()
                               .SetBasePath(Directory.GetCurrentDirectory())
                               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                               .AddJsonFile($"appsettings.{environment.EnvironmentName}.json", false)
                               .AddEnvironmentVariables();

            _configuration = configBuilder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureBlazor()
                    .ConfigureCaching()
                    .ConfigureOptions(_configuration)
                    .ConfigureServices();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzQyNjE1QDMxMzgyZTMzMmUzMENJcDcwYlZ0c05rYnlpQ3pXbVdQMHM2RENhVTNVUy84aGJFNkFPSmI0YTQ9");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
