using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class BookPageReferenceConfiguration : IEntityTypeConfiguration<BookPageReference>
    {
        public void Configure(EntityTypeBuilder<BookPageReference> builder)
        {
            builder.ToTable("BOOK_PAGE_REFERENCE");

            builder.HasKey(e => e.OfficialRecordDocumentId);

            builder.Property(e => e.OfficialRecordDocumentId)
                   .HasColumnName("OFFICIAL_RECORD_DOCUMENT_ID")
                   .ValueGeneratedNever();

            builder.Property(e => e.Book)
                   .IsRequired()
                   .HasColumnName("BOOK")
                   .HasMaxLength(5)
                   .IsUnicode(false);

            builder.Property(e => e.BookSuffix)
                   .HasColumnName("BOOK_SUFFIX")
                   .HasMaxLength(1)
                   .IsUnicode(false)
                   .IsFixedLength();

            builder.Property(e => e.Page)
                   .IsRequired()
                   .HasColumnName("PAGE")
                   .HasMaxLength(5)
                   .IsUnicode(false);

            builder.Property(e => e.PageSuffix)
                   .HasColumnName("PAGE_SUFFIX")
                   .HasMaxLength(1)
                   .IsUnicode(false)
                   .IsFixedLength();

            builder.Property(e => e.Source)
                   .IsRequired()
                   .HasColumnName("SOURCE")
                   .HasMaxLength(2)
                   .IsUnicode(false)
                   .IsFixedLength();

            builder.HasOne(d => d.OfficialRecordDocument)
                   .WithOne(p => p.BookPageReference)
                   .HasForeignKey<BookPageReference>(d => d.OfficialRecordDocumentId)
                   .HasConstraintName("FK_ORD_BOOK_PAGE_REFERENCE");
        }
    }
}
