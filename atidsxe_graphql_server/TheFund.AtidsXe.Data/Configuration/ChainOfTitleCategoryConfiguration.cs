﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class ChainOfTitleCategoryConfiguration : IEntityTypeConfiguration<ChainOfTitleCategory>
    {
        public void Configure(EntityTypeBuilder<ChainOfTitleCategory> builder)
        {
            builder.ToTable("CHAIN_OF_TITLE_CATEGORY");

            builder.HasKey(p => p.ChainOfTitleCategoryId);

            builder.HasIndex(e => e.ChainOfTitleCategoryId)
                   .HasDatabaseName("COT_CATEGORY_DESCRIPTION_UC1")
                   .IsUnique();

            builder.Property(e => e.ChainOfTitleCategoryId)
                   .HasColumnName("CHAIN_OF_TITLE_CATEGORY_ID")
                   .ValueGeneratedNever();

            builder.Property(e => e.Description)
                   .HasColumnName("DESCRIPTION")
                   .HasMaxLength(50)
                   .IsUnicode(false);

            builder.HasMany(p => p.ChainOfTitleItems)
                   .WithOne(p => p.ChainOfTitleCategory)
                   .HasForeignKey(p => p.ChainOfTitleCategoryId);
        }
    }
}
