using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class PolicyOrderTrackingConfiguration : IEntityTypeConfiguration<PolicyOrderTracking>
    {
        public void Configure(EntityTypeBuilder<PolicyOrderTracking> entity)
        {
            entity.ToTable("POLICY_ORDER_TRACKING");

            entity.HasKey(e => new { e.PolicyId, e.PolicyOrderId, e.DeliveryOrderInfoId });

            entity.HasIndex(e => e.PolicyOrderId)
                  .HasDatabaseName("IX_FKPOLICY_ORDER_TRACKING_POLICY_ORDER_ID");

            entity.Property(e => e.PolicyId)
                  .HasColumnName("POLICY_ID");

            entity.Property(e => e.PolicyOrderId)
                  .HasColumnName("POLICY_ORDER_ID");

            entity.Property(e => e.DeliveryOrderInfoId)
                  .HasColumnName("DELIVERY_ORDER_INFO_ID");

            entity.HasOne(d => d.DeliveryOrderInfo)
                  .WithMany(p => p.PolicyOrderTrackings)
                  .HasForeignKey(d => d.DeliveryOrderInfoId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_POLICY_ORDER_TRACKING_DELIVERY_ORDER_INFO");

            entity.HasOne(d => d.Policy)
                  .WithMany(p => p.PolicyOrderTrackings)
                  .HasForeignKey(d => d.PolicyId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_POLICY_POLICY_ORDER_TRACKING");

            entity.HasOne(d => d.PolicyOrder)
                  .WithMany(p => p.PolicyOrderTrackings)
                  .HasForeignKey(d => d.PolicyOrderId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_POLICY_ORDER_POLICY_ORDER_TRACKING");
        }
    }
}
