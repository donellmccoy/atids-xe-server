﻿using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Context
{
    public partial class ATIDSXEContext : DbContext
    {
        public ATIDSXEContext()
        {
        }

        public ATIDSXEContext(DbContextOptions<ATIDSXEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BranchLocation> BranchLocation { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(ATIDSXEContext)));
        }
    }
}
