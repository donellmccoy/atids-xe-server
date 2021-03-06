﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class TaxFolioReferenceConfiguration : IEntityTypeConfiguration<TaxFolioReference>
    {
        public void Configure(EntityTypeBuilder<TaxFolioReference> entity)
        {
            entity.ToTable("TAX_FOLIO_REFERENCE");

            entity.HasKey(e => e.TaxFolioReferenceId);

            entity.HasIndex(e => e.GeographicLocaleId)
                  .HasDatabaseName("I_FK_GEOGRAPHIC_LOCALE");

            entity.HasIndex(e => new { e.FolioNumber, e.GeographicLocaleId })
                  .HasDatabaseName("TAX_FOLIO_REFERENCE_UC1")
                  .IsUnique();

            entity.Property(e => e.TaxFolioReferenceId)
                  .HasColumnName("TAX_FOLIO_REFERENCE_ID");

            entity.Property(e => e.FolioNumber)
                  .IsRequired()
                  .HasColumnName("FOLIO_NUMBER")
                  .HasMaxLength(50)
                  .IsUnicode(false);

            entity.Property(e => e.GeographicLocaleId)
                  .HasColumnName("GEOGRAPHIC_LOCALE_ID");

            entity.HasOne(d => d.GeographicLocale)
                  .WithMany(p => p.TaxFolioReferences)
                  .HasForeignKey(d => d.GeographicLocaleId)
                  .HasConstraintName("FK_GEO_LOCALE_TAX_FOLIO_REF");
        }
    }
}
