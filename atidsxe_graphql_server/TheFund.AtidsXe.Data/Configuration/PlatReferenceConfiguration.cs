﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class PlatReferenceConfiguration : IEntityTypeConfiguration<PlatReference>
    {
        public void Configure(EntityTypeBuilder<PlatReference> entity)
        {
            entity.ToTable("PLAT_REFERENCE");

            entity.HasKey(e => e.PlatReferenceId);

            entity.Property(e => e.PlatReferenceId)
                  .HasColumnName("PLAT_REFERENCE_ID");

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
                  .HasMaxLength(7)
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
        }
    }
}
