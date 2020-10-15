﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class TitleEventTypeCategoryConfiguration : IEntityTypeConfiguration<TitleEventTypeCategory>
    {
        public void Configure(EntityTypeBuilder<TitleEventTypeCategory> entity)
        {
            entity.HasKey(e => e.TitleEventCategoryId);

            entity.ToTable("TITLE_EVENT_TYPE_CATEGORY");

            entity.HasIndex(e => e.Description)
                .HasName("TITLE_EVENT_TYPE_CATEGORY_UC1")
                .IsUnique();

            entity.Property(e => e.TitleEventCategoryId)
                .HasColumnName("TITLE_EVENT_CATEGORY_ID")
                .ValueGeneratedNever();

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}