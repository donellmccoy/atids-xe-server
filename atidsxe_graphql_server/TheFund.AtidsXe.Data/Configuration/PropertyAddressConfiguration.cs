﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class PropertyAddressConfiguration : IEntityTypeConfiguration<PropertyAddress>
    {
        public void Configure(EntityTypeBuilder<PropertyAddress> entity)
        {
            entity.ToTable("PROPERTY_ADDRESS");

            entity.HasKey(e => e.OfficialRecordDocumentId);

            entity.Property(e => e.OfficialRecordDocumentId)
                  .HasColumnName("OFFICIAL_RECORD_DOCUMENT_ID")
                  .ValueGeneratedNever();

            entity.Property(e => e.AddressLine1)
                  .IsRequired()
                  .HasColumnName("ADDRESS_LINE_1")
                  .HasMaxLength(50)
                  .IsUnicode(false);

            entity.Property(e => e.AddressLine2)
                  .HasColumnName("ADDRESS_LINE_2")
                  .HasMaxLength(50)
                  .IsUnicode(false);

            entity.Property(e => e.City)
                  .IsRequired()
                  .HasColumnName("CITY")
                  .HasMaxLength(50)
                  .IsUnicode(false);

            entity.Property(e => e.Country)
                  .IsRequired()
                  .HasColumnName("COUNTRY")
                  .HasMaxLength(50)
                  .IsUnicode(false);

            entity.Property(e => e.PostalCode)
                  .IsRequired()
                  .HasColumnName("POSTAL_CODE")
                  .HasMaxLength(50)
                  .IsUnicode(false);

            entity.Property(e => e.State)
                  .IsRequired()
                  .HasColumnName("STATE")
                  .HasMaxLength(50)
                  .IsUnicode(false);

            entity.Property(e => e.UnparsedAddress)
                  .IsRequired()
                  .HasColumnName("UNPARSED_ADDRESS")
                  .HasMaxLength(310)
                  .IsUnicode(false);

            entity.HasOne(d => d.OfficialRecordDocument)
                  .WithOne(p => p.PropertyAddress)
                  .HasForeignKey<PropertyAddress>(d => d.OfficialRecordDocumentId)
                  .HasConstraintName("FK_ORD_PROPERTY_ADDRESS");
        }
    }
}
