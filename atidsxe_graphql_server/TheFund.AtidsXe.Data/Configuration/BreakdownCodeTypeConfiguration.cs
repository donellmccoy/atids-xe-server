using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class BreakdownCodeTypeConfiguration : IEntityTypeConfiguration<BreakdownCodeType>
    {
        public void Configure(EntityTypeBuilder<BreakdownCodeType> builder)
        {
            builder.ToTable("BREAKDOWN_CODE_TYPE");

            builder.HasKey(p => p.BreakdownCodeTypeId)
                   .HasName("PK_BREAKDOWN_CODE_TYPE");

            builder.Property(e => e.BreakdownCodeTypeId)
                   .HasColumnName("BREAKDOWN_CODE_TYPE_ID")
                   .ValueGeneratedNever();

            builder.Property(e => e.Description)
                   .HasColumnName("DESCRIPTION")
                   .HasMaxLength(32)
                   .IsUnicode(false)
                   .IsRequired();

            builder.HasMany(p => p.UnplattedReference)
                   .WithOne(p => p.BreakdownCodeType)
                   .HasForeignKey(p => p.UnplattedReferenceId);
        }
    }
}
