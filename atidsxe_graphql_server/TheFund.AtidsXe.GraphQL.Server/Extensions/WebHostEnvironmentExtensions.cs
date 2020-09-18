using Microsoft.AspNetCore.Hosting;

namespace TheFund.AtidsXe.GraphQL.Server.Extensions
{
    public static class WebHostEnvironmentExtensions
    {
        public static bool IsLocal(this IWebHostEnvironment webHostEnvironment)
        {
            return webHostEnvironment.EnvironmentName == "Local";
        }

        public static bool IsPersonal(this IWebHostEnvironment webHostEnvironment)
        {
            return webHostEnvironment.EnvironmentName == "Personal";
        }
    }
}
