using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class CaseNumberReferenceConfiguration : IEntityTypeConfiguration<CaseNumberReference>
    {
        public void Configure(EntityTypeBuilder<CaseNumberReference> builder)
        {
            builder.ToTable("CASE_NUMBER_REFERENCE");

            builder.HasKey(p => p.CaseNumberReferenceId);

            builder.HasIndex(e => e.GeographicLocaleId)
                   .HasName("I_FK_GEOGRAPHIC_LOCALE");

            builder.HasIndex(e => new { e.Source, e.RecordingYear, e.RecordingNumber, e.Suffix, e.SeriesCode, e.GeographicLocaleId })
                   .HasName("CASE_NUMBER_REFERENCE_UC1")
                   .IsUnique();

            builder.Property(e => e.CaseNumberReferenceId)
                   .HasColumnName("CASE_NUMBER_REFERENCE_ID");

            builder.Property(e => e.GeographicLocaleId)
                   .HasColumnName("GEOGRAPHIC_LOCALE_ID");

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

            builder.HasOne(d => d.GeographicLocale)
                   .WithMany(p => p.CaseNumberReference)
                   .HasForeignKey(d => d.GeographicLocaleId)
                   .HasConstraintName("FK_GEO_LOCALE_CASE_NBR_REF");

            builder.HasMany(p => p.RelatedCaseNumbers)
                   .WithOne(p => p.CaseNumberReference)
                   .HasForeignKey(p => p.CaseNumberReferenceId);
        }
    }
}
