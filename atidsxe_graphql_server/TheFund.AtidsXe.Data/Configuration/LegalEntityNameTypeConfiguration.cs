﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class LegalEntityNameTypeConfiguration : IEntityTypeConfiguration<LegalEntityNameType>
    {
        public void Configure(EntityTypeBuilder<LegalEntityNameType> entity)
        {
            entity.ToTable("LEGAL_ENTITY_NAME_TYPE");

            entity.HasIndex(e => e.Description)
                  .HasName("IX_LEGAL_ENTITY_NAME_DESC");

            entity.Property(e => e.LegalEntityNameTypeId)
                  .HasColumnName("LEGAL_ENTITY_NAME_TYPE_ID")
                  .ValueGeneratedNever();

            entity.Property(e => e.Description)
                  .IsRequired()
                  .HasColumnName("DESCRIPTION")
                  .HasMaxLength(50)
                  .IsUnicode(false);
        }
    }
}
