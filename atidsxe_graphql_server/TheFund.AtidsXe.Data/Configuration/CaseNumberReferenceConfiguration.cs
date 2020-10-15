﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class CaseNumberReferenceConfiguration : IEntityTypeConfiguration<CaseNumberReference>
    {
        public void Configure(EntityTypeBuilder<CaseNumberReference> entity)
        {
            entity.ToTable("CASE_NUMBER_REFERENCE");

            entity.HasIndex(e => e.GeographicLocaleId)
                  .HasName("I_FK_GEOGRAPHIC_LOCALE");

            entity.HasIndex(e => new { e.Source, e.RecordingYear, e.RecordingNumber, e.Suffix, e.SeriesCode, e.GeographicLocaleId })
                  .HasName("CASE_NUMBER_REFERENCE_UC1")
                  .IsUnique();

            entity.Property(e => e.CaseNumberReferenceId)
                  .HasColumnName("CASE_NUMBER_REFERENCE_ID");

            entity.Property(e => e.GeographicLocaleId)
                  .HasColumnName("GEOGRAPHIC_LOCALE_ID");

            entity.Property(e => e.RecordingNumber)
                  .HasColumnName("RECORDING_NUMBER");

            entity.Property(e => e.RecordingYear)
                  .HasColumnName("RECORDING_YEAR");

            entity.Property(e => e.SeriesCode)
                  .HasColumnName("SERIES_CODE")
                  .HasMaxLength(1)
                  .IsUnicode(false)
                  .IsFixedLength();

            entity.Property(e => e.Source)
                  .IsRequired()
                  .HasColumnName("SOURCE")
                  .HasMaxLength(2)
                  .IsUnicode(false)
                  .IsFixedLength();

            entity.Property(e => e.Suffix)
                  .HasColumnName("SUFFIX")
                  .HasMaxLength(1)
                  .IsUnicode(false)
                  .IsFixedLength();

            entity.HasOne(d => d.GeographicLocale)
                  .WithMany(p => p.CaseNumberReference)
                  .HasForeignKey(d => d.GeographicLocaleId)
                  .HasConstraintName("FK_GEO_LOCALE_CASE_NBR_REF");
        }
    }
}