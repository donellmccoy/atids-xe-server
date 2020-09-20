using Microsoft.Extensions.DependencyInjection;
using System;

namespace TheFund.AtidsXe.GraphQL.Server.Options
{
    public interface IDatabaseContextOptions
    {
        string ConnectionString { get; set; }
        int CommandTimeout { get; set; }
        int PoolSize { get; set; }
        int MaxRetryCount { get; set; }
        TimeSpan MaxRetryDelay { get; set; }
        bool EnablePooling { get; set; }
        bool UseInMemoryDatabase { get; set; }
        string InMemoryDatabaseName { get; set; }
        ServiceLifetime ContextLifetime { get; set; }
        ServiceLifetime OptionsLifetime { get; set; }
        bool EnableDetailedErrors { get; set; }
    }
}