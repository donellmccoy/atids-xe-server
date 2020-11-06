using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class YearNumberReferenceConfiguration : IEntityTypeConfiguration<YearNumberReference>
    {
        public void Configure(EntityTypeBuilder<YearNumberReference> builder)
        {
            builder.ToTable("YEAR_NUMBER_REFERENCE");

            builder.HasKey(e => e.OfficialRecordDocumentId);

            builder.Property(e => e.OfficialRecordDocumentId)
                   .HasColumnName("OFFICIAL_RECORD_DOCUMENT_ID")
                   .ValueGeneratedNever();

            builder.Property(e => e.RecordingNumber)
                   .HasColumnName("RECORDING_NUMBER");

            builder.Property(e => e.RecordingYear)
                   .HasColumnName("RECORDING_YEAR");

            builder.Property(e => e.SeriesCode)
                   .HasColumnName("SERIES_CODE")
                   .HasMaxLength(1)
                   .IsUnicode(false)
                   .IsFixedLength();

            builder.Property(e => e.Source)
                   .IsRequired()
                   .HasColumnName("SOURCE")
                   .HasMaxLength(2)
                   .IsUnicode(false)
                   .IsFixedLength();

            builder.Property(e => e.Suffix)
                   .HasColumnName("SUFFIX")
                   .HasMaxLength(1)
                   .IsUnicode(false)
                   .IsFixedLength();

            builder.HasOne(d => d.OfficialRecordDocument)
                   .WithOne(p => p.YearNumberReference)
                   .HasForeignKey<YearNumberReference>(d => d.OfficialRecordDocumentId)
                   .HasConstraintName("FK_ORD_YEAR_NUMBER_REF");
        }
    }
}
