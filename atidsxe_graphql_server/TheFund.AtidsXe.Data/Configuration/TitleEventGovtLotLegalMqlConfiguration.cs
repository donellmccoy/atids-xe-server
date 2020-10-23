﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class TitleEventGovtLotLegalMqlConfiguration : IEntityTypeConfiguration<TitleEventGovtLotLegalMql>
    {
        public void Configure(EntityTypeBuilder<TitleEventGovtLotLegalMql> entity)
        {
            entity.HasKey(e => new { e.UnplattedReferenceId, e.GovernmentLotId, e.TitleEventId })
                .HasName("PK_TITLE_EVENT_GOVT_LOT_LEGAL");

            entity.ToTable("TITLE_EVENT_GOVT_LOT_LEGAL_MQL");

            entity.HasIndex(e => e.GovernmentLotId)
                .HasName("I_FK_TITLE_EVENT_GOVT_LOT_LEGAL_MQL_GOVERNMENT_LOT_ID");

            entity.HasIndex(e => e.TitleEventId);

            entity.Property(e => e.UnplattedReferenceId).HasColumnName("UNPLATTED_REFERENCE_ID");

            entity.Property(e => e.GovernmentLotId).HasColumnName("GOVERNMENT_LOT_ID");

            entity.Property(e => e.TitleEventId).HasColumnName("TITLE_EVENT_ID");

            entity.HasOne(d => d.TitleEvent)
                .WithMany(p => p.TitleEventGovtLotLegalMqls)
                .HasForeignKey(d => d.TitleEventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TITLE_EVENT_GOVT_LOT_LEGAL");

            entity.HasOne(d => d.GovernmentLotLegal)
                .WithMany(p => p.TitleEventGovtLotLegalMql)
                .HasForeignKey(d => new { d.UnplattedReferenceId, d.GovernmentLotId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GOVT_LOT_LEGAL_TITLE_EVENT");
        }
    }
}
