using Ensure;
using JetBrains.Annotations;
using Microsoft.Extensions.Configuration;

namespace TheFund.AtidsXe.Blazor.Server.Extensions
{
    public static class ConfigurationExtensions
    {
        public static IConfigurationSection GetSection<T>([NotNull] this IConfiguration configuration) where T : class
        {
            configuration.EnsureNotNull();

            return configuration.GetSection(typeof(T).Name);
        }

        public static T GetOption<T>([NotNull] this IConfiguration configuration) where T : class
        {
            configuration.EnsureNotNull();

            return configuration.GetSection(typeof(T).Name).Get<T>();
        }

        public static T GetOption<T>([NotNull] this IConfiguration configuration, [NotNull] string key)
        {
            configuration.EnsureNotNull();
            key.EnsureNotNullOrWhitespace();

            return configuration.GetSection(key).Get<T>();
        }
    }
}
