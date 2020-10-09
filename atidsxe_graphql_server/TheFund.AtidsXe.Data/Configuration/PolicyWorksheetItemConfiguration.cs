﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class PolicyWorksheetItemConfiguration : IEntityTypeConfiguration<PolicyWorksheetItem>
    {
        public void Configure(EntityTypeBuilder<PolicyWorksheetItem> entity)
        {
            entity.HasKey(e => new { e.PolicyId, e.WorksheetId });

            entity.ToTable("POLICY_WORKSHEET_ITEM");

            entity.HasIndex(e => e.WorksheetId)
                .HasName("IX_FKPOLICY_WORKSHEET_ITEM_WORKSHEET_ID");

            entity.Property(e => e.PolicyId).HasColumnName("POLICY_ID");

            entity.Property(e => e.WorksheetId).HasColumnName("WORKSHEET_ID");

            entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

            entity.HasOne(d => d.Policy)
                .WithMany(p => p.PolicyWorksheetItem)
                .HasForeignKey(d => d.PolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_POLICY_POLICY_WORKSHEET_ITEM");

            entity.HasOne(d => d.Worksheet)
                .WithMany(p => p.PolicyWorksheetItem)
                .HasForeignKey(d => d.WorksheetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WORKSHEET_POLICY_WORKSHEET_ITEM");
        }
    }
}
