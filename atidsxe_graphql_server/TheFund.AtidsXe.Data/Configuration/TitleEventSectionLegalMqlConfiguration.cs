using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class TitleEventSectionLegalMqlConfiguration : IEntityTypeConfiguration<TitleEventSectionLegalMql>
    {
        public void Configure(EntityTypeBuilder<TitleEventSectionLegalMql> entity)
        {
            entity.ToTable("TITLE_EVENT_SECTION_LEGAL_MQL");

            entity.HasKey(e => new { e.SectionBreakdownCodeId, e.UnplattedReferenceId, e.TitleEventId })
                  .HasName("PK_TITLE_EVENT_SECTION_LEGAL");

            entity.HasIndex(e => e.TitleEventId);

            entity.HasIndex(e => e.UnplattedReferenceId)
                  .HasName("I_FK_TITLE_EVENT_SECTION_LEGAL_MQL_UNPLATTED_REFERENCE_ID");

            entity.Property(e => e.SectionBreakdownCodeId)
                  .HasColumnName("SECTION_BREAKDOWN_CODE_ID");

            entity.Property(e => e.UnplattedReferenceId)
                  .HasColumnName("UNPLATTED_REFERENCE_ID");

            entity.Property(e => e.TitleEventId)
                  .HasColumnName("TITLE_EVENT_ID");

            entity.HasOne(d => d.TitleEvent)
                  .WithMany(p => p.TitleEventSectionLegalMqls)
                  .HasForeignKey(d => d.TitleEventId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_TITLE_EVENT_SECTION_LEGAL");

            entity.HasOne(d => d.SectionLegal)
                  .WithMany(p => p.TitleEventSectionLegalMqls)
                  .HasForeignKey(d => new { d.SectionBreakdownCodeId, d.UnplattedReferenceId })
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_SECT_LEGAL_TEVENT_SECTLEGAL");
        }
    }
}
