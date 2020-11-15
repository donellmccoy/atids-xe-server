using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class SectionLegalConfiguration : IEntityTypeConfiguration<SectionLegal>
    {
        public void Configure(EntityTypeBuilder<SectionLegal> entity)
        {
            entity.ToTable("SECTION_LEGAL");

            entity.HasKey(e => new { e.SectionBreakdownCodeId, e.UnplattedReferenceId });

            entity.HasIndex(e => e.UnplattedReferenceId)
                  .HasName("I_FK_SECTION_LEGAL_UNPLATTED_REFERENCE_ID");

            entity.Property(e => e.SectionBreakdownCodeId)
                  .HasColumnName("SECTION_BREAKDOWN_CODE_ID");

            entity.Property(e => e.UnplattedReferenceId)
                  .HasColumnName("UNPLATTED_REFERENCE_ID");

            entity.HasOne(d => d.SectionBreakdownCode)
                  .WithMany(p => p.SectionLegals)
                  .HasForeignKey(d => d.SectionBreakdownCodeId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_SECT_BRKDWN_CD_SECT_LEGAL");

            entity.HasOne(d => d.UnplattedReference)
                  .WithMany(p => p.SectionLegals)
                  .HasForeignKey(d => d.UnplattedReferenceId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_UNPLATTED_REF_SECT_LEGAL");
        }
    }
}
