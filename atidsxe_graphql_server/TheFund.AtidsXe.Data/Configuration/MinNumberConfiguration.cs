﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class MinNumberConfiguration : IEntityTypeConfiguration<MinNumber>
    {
        public void Configure(EntityTypeBuilder<MinNumber> entity)
        {
            entity.ToTable("MIN_NUMBER");

            entity.HasKey(p => p.MinNumberId);

            entity.HasIndex(e => new { e.MinLender, e.MinSerial, e.MinCheckDigit })
                  .HasDatabaseName("MIN_NUMBER_UC1")
                  .IsUnique();

            entity.Property(e => e.MinNumberId)
                  .HasColumnName("MIN_NUMBER_ID");

            entity.Property(e => e.MinCheckDigit)
                  .IsRequired()
                  .HasColumnName("MIN_CHECK_DIGIT")
                  .HasMaxLength(1)
                  .IsUnicode(false)
                  .IsFixedLength();

            entity.Property(e => e.MinLender)
                  .IsRequired()
                  .HasColumnName("MIN_LENDER")
                  .HasMaxLength(7)
                  .IsUnicode(false);

            entity.Property(e => e.MinSerial)
                  .IsRequired()
                  .HasColumnName("MIN_SERIAL")
                  .HasMaxLength(10)
                  .IsUnicode(false);
        }
    }
}
