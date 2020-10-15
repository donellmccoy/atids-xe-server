using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class BookPageReferenceConfiguration : IEntityTypeConfiguration<BookPageReference>
    {
        public void Configure(EntityTypeBuilder<BookPageReference> entity)
        {
            entity.HasKey(e => e.OfficialRecordDocumentId);

            entity.ToTable("BOOK_PAGE_REFERENCE");

            entity.Property(e => e.OfficialRecordDocumentId)
                  .HasColumnName("OFFICIAL_RECORD_DOCUMENT_ID")
                  .ValueGeneratedNever();

            entity.Property(e => e.Book)
                  .IsRequired()
                  .HasColumnName("BOOK")
                  .HasMaxLength(5)
                  .IsUnicode(false);

            entity.Property(e => e.BookSuffix)
                  .HasColumnName("BOOK_SUFFIX")
                  .HasMaxLength(1)
                  .IsUnicode(false)
                  .IsFixedLength();

            entity.Property(e => e.Page)
                  .IsRequired()
                  .HasColumnName("PAGE")
                  .HasMaxLength(5)
                  .IsUnicode(false);

            entity.Property(e => e.PageSuffix)
                  .HasColumnName("PAGE_SUFFIX")
                  .HasMaxLength(1)
                  .IsUnicode(false)
                  .IsFixedLength();

            entity.Property(e => e.Source)
                  .IsRequired()
                  .HasColumnName("SOURCE")
                  .HasMaxLength(2)
                  .IsUnicode(false)
                  .IsFixedLength();

            entity.HasOne(d => d.OfficialRecordDocument)
                  .WithOne(p => p.BookPageReference)
                  .HasForeignKey<BookPageReference>(d => d.OfficialRecordDocumentId)
                  .HasConstraintName("FK_ORD_BOOK_PAGE_REFERENCE");
        }
    }
}
