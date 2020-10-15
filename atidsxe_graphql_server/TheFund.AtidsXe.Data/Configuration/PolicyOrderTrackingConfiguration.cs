﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class PolicyOrderTrackingConfiguration : IEntityTypeConfiguration<PolicyOrderTracking>
    {
        public void Configure(EntityTypeBuilder<PolicyOrderTracking> entity)
        {
            entity.HasKey(e => new { e.PolicyId, e.PolicyOrderId, e.DeliveryOrderInfoId });

            entity.ToTable("POLICY_ORDER_TRACKING");

            entity.HasIndex(e => e.PolicyOrderId)
                .HasName("IX_FKPOLICY_ORDER_TRACKING_POLICY_ORDER_ID");

            entity.Property(e => e.PolicyId).HasColumnName("POLICY_ID");

            entity.Property(e => e.PolicyOrderId).HasColumnName("POLICY_ORDER_ID");

            entity.Property(e => e.DeliveryOrderInfoId).HasColumnName("DELIVERY_ORDER_INFO_ID");

            entity.HasOne(d => d.DeliveryOrderInfo)
                .WithMany(p => p.PolicyOrderTracking)
                .HasForeignKey(d => d.DeliveryOrderInfoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_POLICY_ORDER_TRACKING_DELIVERY_ORDER_INFO");

            entity.HasOne(d => d.Policy)
                .WithMany(p => p.PolicyOrderTracking)
                .HasForeignKey(d => d.PolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_POLICY_POLICY_ORDER_TRACKING");

            entity.HasOne(d => d.PolicyOrder)
                .WithMany(p => p.PolicyOrderTracking)
                .HasForeignKey(d => d.PolicyOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_POLICY_ORDER_POLICY_ORDER_TRACKING");
        }
    }
}