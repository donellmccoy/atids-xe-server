using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class SectionBreakdownCodeConfiguration : IEntityTypeConfiguration<SectionBreakdownCode>
    {
        public void Configure(EntityTypeBuilder<SectionBreakdownCode> entity)
        {
            entity.ToTable("SECTION_BREAKDOWN_CODE");

            entity.HasKey(e => e.SectionBreakdownCodeId);

            entity.HasIndex(e => new { e.SectionQuarter, e.Section16th, e.Section64th, e.Section256th, e.SectionBreakdownCodeId })
                  .HasName("IX_SECTION_BREAKDOWN");

            entity.Property(e => e.SectionBreakdownCodeId)
                  .HasColumnName("SECTION_BREAKDOWN_CODE_ID");

            entity.Property(e => e.Section16th)
                  .HasColumnName("SECTION_16TH");

            entity.Property(e => e.Section256th)
                  .HasColumnName("SECTION_256TH");

            entity.Property(e => e.Section64th)
                  .HasColumnName("SECTION_64TH");

            entity.Property(e => e.SectionQuarter)
                  .HasColumnName("SECTION_QUARTER");
        }
    }
}
