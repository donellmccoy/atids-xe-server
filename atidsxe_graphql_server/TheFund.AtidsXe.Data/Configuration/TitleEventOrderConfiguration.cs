using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class TitleEventOrderConfiguration : IEntityTypeConfiguration<TitleEventOrder>
    {
        public void Configure(EntityTypeBuilder<TitleEventOrder> entity)
        {
            entity.ToTable("TITLE_EVENT_ORDER");

            entity.HasKey(e => e.TitleEventOrderId);

            entity.HasIndex(e => e.TrackingIdentifier);

            entity.Property(e => e.TitleEventOrderId)
                  .HasColumnName("TITLE_EVENT_ORDER_ID");

            entity.Property(e => e.OrderDate)
                  .HasColumnName("ORDER_DATE")
                  .HasColumnType("datetime");

            entity.Property(e => e.TrackingIdentifier)
                  .IsRequired()
                  .HasColumnName("TRACKING_IDENTIFIER")
                  .HasMaxLength(60)
                  .IsUnicode(false);
        }
    }
}
