using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class BranchLocationConfiguration : IEntityTypeConfiguration<BranchLocation>
    {
        public void Configure(EntityTypeBuilder<BranchLocation> builder)
        {
            builder.ToTable("BRANCH_LOCATION");

            builder.HasKey(p => p.BranchLocationId);

            builder.HasIndex(e => e.AccountNumber)
                   .HasDatabaseName("IX_BRANCH_LOCATION_ACCOUNT")
                   .IsUnique();

            builder.Property(e => e.BranchLocationId)
                   .HasColumnName("BRANCH_LOCATION_ID")
                   .ValueGeneratedOnAdd();

            builder.Property(e => e.AccountNumber)
                   .HasColumnName("ACCOUNT_NUMBER")
                   .HasMaxLength(5)
                   .IsUnicode(false)
                   .IsRequired();

            builder.Property(e => e.Description)
                   .HasColumnName("DESCRIPTION")
                   .IsUnicode(false)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(e => e.IsInternal)
                   .HasColumnName("IS_INTERNAL")
                   .IsRequired(false);

            builder.HasMany(p => p.FileReference)
                   .WithOne(p => p.BranchLocation)
                   .HasForeignKey(p => p.BranchLocationId);
        }
    }
}
