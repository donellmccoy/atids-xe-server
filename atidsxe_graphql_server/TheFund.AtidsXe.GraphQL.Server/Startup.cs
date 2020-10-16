using HotChocolate.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;
using TheFund.AtidsXe.GraphQL.Server.Extensions;

namespace TheFund.AtidsXe.GraphQL.Server
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
            services.ConfigureOptions(_configuration)
                    .ConfigureDbContext(_hostingEnvironment, _configuration)
                    .ConfigureGraphQL(_configuration)
                    .ConfigureCompression(_configuration);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseResponseCompression();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            
            app.UseGraphQL("/api/v1/graphql");
        }
    }
}
