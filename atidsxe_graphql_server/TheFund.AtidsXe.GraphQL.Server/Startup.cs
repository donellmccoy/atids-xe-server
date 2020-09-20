using HotChocolate;
using HotChocolate.AspNetCore;
using HotChocolate.Execution.Configuration;
using HotChocolate.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;
using TheFund.AtidsXe.GraphQL.Server.Extensions;
using TheFund.AtidsXe.GraphQL.Server.Queries;

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
                    .AddDbContextServices(_hostingEnvironment, _configuration)
                    .AddDataLoaderRegistry()
                    .AddGraphQL(sp => SchemaBuilder.New()
                                                   .AddServices(sp)
                                                   .AddQueryType(d => d.Name("Query"))
                                                   .AddType<BranchLocationQueries>()
                                                   .BindClrType<string, StringType>()
                                                   .Create(),
                    new QueryExecutionOptions { ForceSerialExecution = true });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseGraphQL("/graphql");
        }
    }
}
