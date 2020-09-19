using Microsoft.EntityFrameworkCore;
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


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchLocation>(entity =>
            {
                entity.Property(e => e.AccountNumber).HasMaxLength(5).IsRequired();
                entity.HasIndex(e => e.AccountNumber).HasName("IX_BRANCH_LOCATION_ACCOUNT").IsUnique();
                entity.Property(e => e.AccountNumber).IsUnicode(false);
                entity.Property(e => e.Description).IsUnicode(false);
                entity.Property(e => e.Description).HasMaxLength(50).IsRequired();
            });
        }
    }
}
