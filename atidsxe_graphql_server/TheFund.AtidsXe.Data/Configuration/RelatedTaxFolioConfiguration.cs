using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class RelatedTaxFolioConfiguration : IEntityTypeConfiguration<RelatedTaxFolio>
    {
        public void Configure(EntityTypeBuilder<RelatedTaxFolio> entity)
        {
            entity.ToTable("RELATED_TAX_FOLIO");

            entity.HasKey(e => new { e.OfficialRecordDocumentId, e.TaxFolioReferenceId });

            entity.HasIndex(e => e.TaxFolioReferenceId)
                  .HasName("I_FK_RELATED_TAX_FOLIO_TAX_FOLIO_REFERENCE_ID");

            entity.Property(e => e.OfficialRecordDocumentId)
                  .HasColumnName("OFFICIAL_RECORD_DOCUMENT_ID");

            entity.Property(e => e.TaxFolioReferenceId)
                  .HasColumnName("TAX_FOLIO_REFERENCE_ID");

            entity.HasOne(d => d.OfficialRecordDocument)
                  .WithMany(p => p.RelatedTaxFolios)
                  .HasForeignKey(d => d.OfficialRecordDocumentId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_ORD_RELATED_TAX_FOLIO");

            entity.HasOne(d => d.TaxFolioReference)
                  .WithMany(p => p.RelatedTaxFolio)
                  .HasForeignKey(d => d.TaxFolioReferenceId)
                  .HasConstraintName("FK_TAX_FOLIO_REF_RELATED_ID");
        }
    }
}
