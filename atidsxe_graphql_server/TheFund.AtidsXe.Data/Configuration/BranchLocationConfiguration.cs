using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class BranchLocationConfiguration : IEntityTypeConfiguration<BranchLocation>
    {
        public void Configure(EntityTypeBuilder<BranchLocation> builder)
        {
            builder.Property(e => e.BranchLocationId).ValueGeneratedOnAdd();

            builder.Property(e => e.AccountNumber).HasMaxLength(5).IsUnicode(false).IsRequired();
            builder.HasIndex(e => e.AccountNumber).HasName("IX_BRANCH_LOCATION_ACCOUNT").IsUnique();

            builder.Property(e => e.Description).IsUnicode(false);
            builder.Property(e => e.Description).HasMaxLength(50).IsRequired();
        }
    }
}
