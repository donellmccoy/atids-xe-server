﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class PolicySectionLegalMqlConfiguration : IEntityTypeConfiguration<PolicySectionLegalMql>
    {
        public void Configure(EntityTypeBuilder<PolicySectionLegalMql> entity)
        {
            entity.HasKey(e => new { e.PolicyId, e.UnplattedReferenceId, e.SectionBreakdownCodeId })
                .HasName("PK_POLICY_SECTION_LEGAL");

            entity.ToTable("POLICY_SECTION_LEGAL_MQL");

            entity.HasIndex(e => e.SectionBreakdownCodeId)
                .HasName("I_FK_POLICY_SECTION_LEGAL_MQL_SECTION_BREAKDOWN_CODE_ID");

            entity.HasIndex(e => e.UnplattedReferenceId)
                .HasName("I_FK_POLICY_SECTION_LEGAL_MQL_UNPLATTED_REFERENCE_ID");

            entity.Property(e => e.PolicyId).HasColumnName("POLICY_ID");

            entity.Property(e => e.UnplattedReferenceId).HasColumnName("UNPLATTED_REFERENCE_ID");

            entity.Property(e => e.SectionBreakdownCodeId).HasColumnName("SECTION_BREAKDOWN_CODE_ID");

            entity.HasOne(d => d.Policy)
                .WithMany(p => p.PolicySectionLegalMqls)
                .HasForeignKey(d => d.PolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_POLICY_SECTION_LEGAL");

            entity.HasOne(d => d.SectionLegal)
                .WithMany(p => p.PolicySectionLegalMql)
                .HasForeignKey(d => new { d.SectionBreakdownCodeId, d.UnplattedReferenceId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SECT_LEGAL_POLICY_SECTLEGAL");
        }
    }
}
