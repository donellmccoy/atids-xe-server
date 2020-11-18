using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class AcreageSectionLegalConfiguration : IEntityTypeConfiguration<AcreageSectionLegal>
    {
        public void Configure(EntityTypeBuilder<AcreageSectionLegal> builder)
        {
            builder.ToTable("ACREAGE_SECTION_LEGAL");

            builder.HasKey(e => new { e.SearchId, e.SectionBreakdownCodeId, e.UnplattedReferenceId });

            builder.HasIndex(e => e.SectionBreakdownCodeId)
                   .HasDatabaseName("I_FK_ACREAGE_SECTION_LEGAL_SECTION_BREAKDOWN_CODE_ID");

            builder.HasIndex(e => e.UnplattedReferenceId)
                   .HasDatabaseName("I_FK_ACREAGE_SECTION_LEGAL_UNPLATTED_REFERENCE_ID");

            builder.Property(e => e.SearchId)
                   .HasColumnName("SEARCH_ID");

            builder.Property(e => e.SectionBreakdownCodeId)
                   .HasColumnName("SECTION_BREAKDOWN_CODE_ID");

            builder.Property(e => e.UnplattedReferenceId)
                   .HasColumnName("UNPLATTED_REFERENCE_ID");

            builder.HasOne(d => d.Search)
                   .WithMany(p => p.AcreageSectionLegals)
                   .HasForeignKey(d => d.SearchId)
                   .HasConstraintName("FK_ACREAGE_SECT_LGL_SRCH");

            builder.HasOne(d => d.SectionLegal)
                   .WithMany(p => p.AcreageSectionLegals)
                   .HasForeignKey(d => new { d.SectionBreakdownCodeId, d.UnplattedReferenceId })
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_SECT_LEGAL_ACREAGE_SEARCH");
        }
    }
}
