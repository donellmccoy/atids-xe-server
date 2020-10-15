using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class BreakdownCodeTypeConfiguration : IEntityTypeConfiguration<BreakdownCodeType>
    {
        public void Configure(EntityTypeBuilder<BreakdownCodeType> entity)
        {
            entity.ToTable("BREAKDOWN_CODE_TYPE");

            entity.Property(e => e.BreakdownCodeTypeId)
                  .HasColumnName("BREAKDOWN_CODE_TYPE_ID")
                  .ValueGeneratedNever();

            entity.Property(e => e.Description)
                  .IsRequired()
                  .HasColumnName("DESCRIPTION")
                  .HasMaxLength(32)
                  .IsUnicode(false);
        }
    }
}
