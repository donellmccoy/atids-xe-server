using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.ComponentModel.DataAnnotations;
using TheFund.AtidsXe.Data.Context;

namespace TheFund.AtidsXe.GraphQL.Server.Options
{
    public sealed class DatabaseContextOptions : IDatabaseContextOptions
    {
        public static string SectionName => nameof(DatabaseContextOptions);

        [Required]
        public string ConnectionString { get; set; }
        public int CommandTimeout { get; set; } = 120;
        public int PoolSize { get; set; } = 16;
        public int MaxRetryCount { get; set; } = 5;
        public TimeSpan MaxRetryDelay { get; set; } = TimeSpan.FromSeconds(30);
        public bool EnablePooling { get; set; } = false;
        public bool UseInMemoryDatabase { get; set; } = false;
        public bool EnableDetailedErrors { get; set; } = true;
        public string InMemoryDatabaseName { get; set; } = nameof(ApplicationDbContext);
        public QueryTrackingBehavior QueryTrackingBehavior { get; set; } = QueryTrackingBehavior.NoTracking;
        public ServiceLifetime ContextLifetime { get; set; } = ServiceLifetime.Transient;
        public ServiceLifetime OptionsLifetime { get; set; } = ServiceLifetime.Transient;
    }
}
