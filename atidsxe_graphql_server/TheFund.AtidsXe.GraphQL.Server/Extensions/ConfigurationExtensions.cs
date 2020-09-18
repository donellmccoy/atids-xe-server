using Ensure;
using JetBrains.Annotations;
using Microsoft.Extensions.Configuration;

namespace TheFund.AtidsXe.GraphQL.Server.Extensions
{
    public static class ConfigurationExtensions
    {
        public static T GetSection<T>([NotNull] this IConfiguration configuration)
        {
            configuration.EnsureNotNull();

            return configuration.GetSection(typeof(T).Name).Get<T>();
        }

        public static T GetSection<T>([NotNull] this IConfiguration configuration, [NotNull] string key)
        {
            configuration.EnsureNotNull();
            key.EnsureNotNullOrWhitespace();

            return configuration.GetSection(key).Get<T>();
        }
    }
}
