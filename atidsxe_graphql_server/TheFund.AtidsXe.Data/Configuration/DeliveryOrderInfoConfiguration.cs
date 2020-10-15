using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class DeliveryOrderInfoConfiguration : IEntityTypeConfiguration<DeliveryOrderInfo>
    {
        public void Configure(EntityTypeBuilder<DeliveryOrderInfo> entity)
        {
            entity.ToTable("DELIVERY_ORDER_INFO");

            entity.Property(e => e.DeliveryOrderInfoId)
                  .HasColumnName("DELIVERY_ORDER_INFO_ID");

            entity.Property(e => e.CreateDate)
                  .HasColumnName("CREATE_DATE")
                  .HasColumnType("datetime")
                  .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Email)
                  .HasColumnName("EMAIL")
                  .HasMaxLength(50)
                  .IsUnicode(false);

            entity.Property(e => e.ImagedFlag)
                  .HasColumnName("IMAGED_FLAG");

            entity.Property(e => e.ModifiedDate)
                  .HasColumnName("MODIFIED_DATE")
                  .HasColumnType("datetime")
                  .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.PageCount)
                  .HasColumnName("PAGE_COUNT")
                  .HasDefaultValueSql("((0))");
        }
    }
}
