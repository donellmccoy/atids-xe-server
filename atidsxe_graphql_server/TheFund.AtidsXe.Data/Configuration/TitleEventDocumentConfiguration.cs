using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class TitleEventDocumentConfiguration : IEntityTypeConfiguration<TitleEventDocument>
    {
        public void Configure(EntityTypeBuilder<TitleEventDocument> builder)
        {
            builder.ToTable("TITLE_EVENT_DOCUMENT");

            builder.HasKey(e => new { e.TitleEventId, e.OfficialRecordDocumentId });

            builder.HasIndex(e => e.OfficialRecordDocumentId)
                   .HasName("I_TITLE_EVENT_DOCUMENT_OFF_REC_DOC_ID");

            builder.HasIndex(e => e.TitleEventId)
                   .HasName("UC_TITLE_EVENT_DOCUMENT")
                   .IsUnique();

            builder.Property(e => e.TitleEventId)
                   .HasColumnName("TITLE_EVENT_ID");

            builder.Property(e => e.OfficialRecordDocumentId)
                   .HasColumnName("OFFICIAL_RECORD_DOCUMENT_ID");

            builder.HasOne(d => d.OfficialRecordDocument)
                   .WithMany(p => p.TitleEventDocument)
                   .HasForeignKey(d => d.OfficialRecordDocumentId)
                   .HasConstraintName("FK_ORD_TITLE_EVENT");

            builder.HasOne(d => d.TitleEvent)
                   .WithOne(p => p.TitleEventDocument)
                   .HasForeignKey<TitleEventDocument>(d => d.TitleEventId)
                   .HasConstraintName("FK_TITLE_EVENT_DOCUMENTS");
        }
    }
}
