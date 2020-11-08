﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class RelatedCaseNumberConfiguration : IEntityTypeConfiguration<RelatedCaseNumber>
    {
        public void Configure(EntityTypeBuilder<RelatedCaseNumber> entity)
        {
            entity.HasKey(e => new { e.OfficialRecordDocumentId, e.CaseNumberReferenceId });

            entity.ToTable("RELATED_CASE_NUMBER");

            entity.HasIndex(e => e.CaseNumberReferenceId)
                .HasName("I_FK_RELATED_CASE_NUMBER_CASE_NUMBER_REFERENCE_ID");

            entity.Property(e => e.OfficialRecordDocumentId).HasColumnName("OFFICIAL_RECORD_DOCUMENT_ID");

            entity.Property(e => e.CaseNumberReferenceId).HasColumnName("CASE_NUMBER_REFERENCE_ID");

            entity.HasOne(d => d.CaseNumberReference)
                .WithMany(p => p.RelatedCaseNumbers)
                .HasForeignKey(d => d.CaseNumberReferenceId)
                .HasConstraintName("FK_CASE_NBR_REF_RELATED_CASENM");

            entity.HasOne(d => d.OfficialRecordDocument)
                .WithMany(p => p.RelatedCaseNumber)
                .HasForeignKey(d => d.OfficialRecordDocumentId)
                .HasConstraintName("FK_ORD_RELATED_CASE_NBR_REF");
        }
    }
}
