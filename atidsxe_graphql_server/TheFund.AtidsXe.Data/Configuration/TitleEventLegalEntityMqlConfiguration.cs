using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class TitleEventLegalEntityMqlConfiguration : IEntityTypeConfiguration<TitleEventLegalEntityMql>
    {
        public void Configure(EntityTypeBuilder<TitleEventLegalEntityMql> entity)
        {
            entity.ToTable("TITLE_EVENT_LEGAL_ENTITY_MQL");

            entity.HasKey(e => new { e.TitleEventId, e.LegalEntityNameId })
                  .HasName("PK_TITLE_EVENT_LEGAL_ENTITY");

            entity.HasIndex(e => e.LegalEntityNameId)
                  .HasName("I_FK_TITLE_EVENT_LEGAL_ENTITY_MQL_LEGAL_ENTITY_NAME_ID");

            entity.Property(e => e.TitleEventId)
                  .HasColumnName("TITLE_EVENT_ID");

            entity.Property(e => e.LegalEntityNameId)
                  .HasColumnName("LEGAL_ENTITY_NAME_ID");

            entity.HasOne(d => d.LegalEntityName)
                  .WithMany(p => p.TitleEventLegalEntityMqls)
                  .HasForeignKey(d => d.LegalEntityNameId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_LEGAL_ENTNM_TITLEVT_LGL_ENT");

            entity.HasOne(d => d.TitleEvent)
                  .WithMany(p => p.TitleEventLegalEntityMqls)
                  .HasForeignKey(d => d.TitleEventId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_TITLE_EVENT_LEGAL_ENTITY");
        }
    }
}
