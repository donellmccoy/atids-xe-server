using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class TitleEventOrderTrackingConfiguration : IEntityTypeConfiguration<TitleEventOrderTracking>
    {
        public void Configure(EntityTypeBuilder<TitleEventOrderTracking> entity)
        {
            entity.ToTable("TITLE_EVENT_ORDER_TRACKING");

            entity.HasKey(e => new { e.TitleEventId, e.TitleEventOrderId, e.DeliveryOrderInfoId });

            entity.HasIndex(e => e.TitleEventOrderId)
                  .HasName("IX_FKTITLE_EVENT_ORDER_TRACKING_TITLE_EVENT_ORDER_ID");

            entity.Property(e => e.TitleEventId)
                  .HasColumnName("TITLE_EVENT_ID");

            entity.Property(e => e.TitleEventOrderId)
                  .HasColumnName("TITLE_EVENT_ORDER_ID");

            entity.Property(e => e.DeliveryOrderInfoId)
                  .HasColumnName("DELIVERY_ORDER_INFO_ID");

            entity.HasOne(d => d.DeliveryOrderInfo)
                  .WithMany(p => p.TitleEventOrderTrackings)
                  .HasForeignKey(d => d.DeliveryOrderInfoId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_TITLE_EVENT_ORDER_TRACKING_DELIVERY_ORDER_INFO");

            entity.HasOne(d => d.TitleEvent)
                  .WithMany(p => p.TitleEventOrderTrackings)
                  .HasForeignKey(d => d.TitleEventId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_TE_TE_ORDER_TRACKING");

            entity.HasOne(d => d.TitleEventOrder)
                  .WithMany(p => p.TitleEventOrderTrackings)
                  .HasForeignKey(d => d.TitleEventOrderId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_TE_ORDER_TE_ORDER_TRACKING");
        }
    }
}
