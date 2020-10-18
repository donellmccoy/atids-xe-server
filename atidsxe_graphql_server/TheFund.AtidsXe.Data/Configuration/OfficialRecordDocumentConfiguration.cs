using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class OfficialRecordDocumentConfiguration : IEntityTypeConfiguration<OfficialRecordDocument>
    {
        public void Configure(EntityTypeBuilder<OfficialRecordDocument> entity)
        {
            entity.ToTable("OFFICIAL_RECORD_DOCUMENT");

            entity.HasKey(p => p.OfficialRecordDocumentId);

            entity.HasIndex(e => e.GeographicLocaleId)
                  .HasName("I_FK_GEOGRAPHIC_LOCALE_ID");

            entity.Property(e => e.OfficialRecordDocumentId)
                  .HasColumnName("OFFICIAL_RECORD_DOCUMENT_ID");

            entity.Property(e => e.GeographicLocaleId)
                  .HasColumnName("GEOGRAPHIC_LOCALE_ID");

            entity.HasOne(d => d.GeographicLocale)
                  .WithMany(p => p.OfficialRecordDocument)
                  .HasForeignKey(d => d.GeographicLocaleId)
                  .HasConstraintName("FK_GEO_LOCALE_ORD");
        }
    }
}
