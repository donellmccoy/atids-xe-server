using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class DeliveryOrderInfoConfiguration : IEntityTypeConfiguration<DeliveryOrderInfo>
    {
        public void Configure(EntityTypeBuilder<DeliveryOrderInfo> builder)
        {
            builder.ToTable("DELIVERY_ORDER_INFO");

            builder.HasKey(e => e.DeliveryOrderInfoId);

            builder.Property(e => e.DeliveryOrderInfoId)
                   .HasColumnName("DELIVERY_ORDER_INFO_ID");

            builder.Property(e => e.CreateDate)
                   .HasColumnName("CREATE_DATE")
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.Email)
                   .HasColumnName("EMAIL")
                   .HasMaxLength(50)
                   .IsUnicode(false);

            builder.Property(e => e.ImagedFlag)
                   .HasColumnName("IMAGED_FLAG");

            builder.Property(e => e.ModifiedDate)
                   .HasColumnName("MODIFIED_DATE")
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.PageCount)
                   .HasColumnName("PAGE_COUNT")
                   .HasDefaultValueSql("((0))");
        }
    }
}
