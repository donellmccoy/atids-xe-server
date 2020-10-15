using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class OrDocumentInformationConfiguration : IEntityTypeConfiguration<OrDocumentInformation>
    {
        public void Configure(EntityTypeBuilder<OrDocumentInformation> entity)
        {
            entity.ToTable("OR_DOCUMENT_INFORMATION");

            entity.HasKey(e => e.OfficialRecordDocumentId);

            entity.HasIndex(e => e.TypeOfInstrumentId)
                  .HasName("I_FK_TYPE_OF_INSTRUMENT");

            entity.Property(e => e.OfficialRecordDocumentId)
                  .HasColumnName("OFFICIAL_RECORD_DOCUMENT_ID")
                  .ValueGeneratedNever();

            entity.Property(e => e.Amount)
                  .HasColumnName("AMOUNT")
                  .HasColumnType("numeric(13, 2)");

            entity.Property(e => e.Comments)
                  .HasColumnName("COMMENTS")
                  .HasMaxLength(256)
                  .IsUnicode(false);

            entity.Property(e => e.CriticalItemsHash)
                  .HasColumnName("CRITICAL_ITEMS_HASH");

            entity.Property(e => e.DateOfFiling)
                  .HasColumnName("DATE_OF_FILING")
                  .HasColumnType("datetime");

            entity.Property(e => e.FullHash)
                  .HasColumnName("FULL_HASH");

            entity.Property(e => e.ImageAvailable)
                  .HasColumnName("IMAGE_AVAILABLE");

            entity.Property(e => e.LastImageUpdate)
                  .HasColumnName("LAST_IMAGE_UPDATE")
                  .HasColumnType("datetime");

            entity.Property(e => e.Md5CriticalItemsHash)
                  .HasColumnName("MD5_CRITICAL_ITEMS_HASH")
                  .HasMaxLength(50)
                  .IsUnicode(false);

            entity.Property(e => e.PageCount)
                  .HasColumnName("PAGE_COUNT");

            entity.Property(e => e.ScrivnerName)
                  .HasColumnName("SCRIVNER_NAME")
                  .HasMaxLength(50)
                  .IsUnicode(false);

            entity.Property(e => e.ToiAdditionalInformation)
                  .HasColumnName("TOI_ADDITIONAL_INFORMATION")
                  .HasMaxLength(50)
                  .IsUnicode(false);

            entity.Property(e => e.TypeOfInstrumentId)
                  .HasColumnName("TYPE_OF_INSTRUMENT_ID");

            entity.Property(e => e.UnparsedLegalDescription)
                  .HasColumnName("UNPARSED_LEGAL_DESCRIPTION")
                  .HasMaxLength(800)
                  .IsUnicode(false);

            entity.Property(e => e.UnparsedRelatedReference)
                  .HasColumnName("UNPARSED_RELATED_REFERENCE")
                  .HasMaxLength(256)
                  .IsUnicode(false);

            entity.HasOne(d => d.OfficialRecordDocument)
                  .WithOne(p => p.OrDocumentInformation)
                  .HasForeignKey<OrDocumentInformation>(d => d.OfficialRecordDocumentId)
                  .HasConstraintName("FK_ORD_ORD_INFORMATION");

            entity.HasOne(d => d.TypeOfInstrument)
                  .WithMany(p => p.OrDocumentInformation)
                  .HasForeignKey(d => d.TypeOfInstrumentId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_TYPE_OF_INSTRUMENT_ORD");
        }
    }
}
