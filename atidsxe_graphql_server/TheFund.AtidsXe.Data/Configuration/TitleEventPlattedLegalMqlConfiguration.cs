using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class TitleEventPlattedLegalMqlConfiguration : IEntityTypeConfiguration<TitleEventPlattedLegalMql>
    {
        public void Configure(EntityTypeBuilder<TitleEventPlattedLegalMql> entity)
        {
            entity.ToTable("TITLE_EVENT_PLATTED_LEGAL_MQL");

            entity.HasKey(e => new { e.SubdivisionLevelId, e.PlatReferenceId, e.TitleEventId })
                  .HasName("PK_TITLE_EVENT_PLATTED_LEGAL");

            entity.HasIndex(e => e.PlatReferenceId)
                  .HasName("I_FK_TITLE_EVENT_PLATTED_LEGAL_MQL_PLAT_REFERENCE_ID");

            entity.HasIndex(e => e.TitleEventId);

            entity.Property(e => e.SubdivisionLevelId)
                  .HasColumnName("SUBDIVISION_LEVEL_ID");

            entity.Property(e => e.PlatReferenceId)
                  .HasColumnName("PLAT_REFERENCE_ID");

            entity.Property(e => e.TitleEventId)
                  .HasColumnName("TITLE_EVENT_ID");

            entity.HasOne(d => d.TitleEvent)
                  .WithMany(p => p.TitleEventPlattedLegalMqls)
                  .HasForeignKey(d => d.TitleEventId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_TITLE_EVENT_PLATTED_LEGAL");

            entity.HasOne(d => d.PlattedLegal)
                  .WithMany(p => p.TitleEventPlattedLegalMql)
                  .HasForeignKey(d => new { d.PlatReferenceId, d.SubdivisionLevelId })
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_PLATTED_LEGAL_TITLE_EVENT");
        }
    }
}
