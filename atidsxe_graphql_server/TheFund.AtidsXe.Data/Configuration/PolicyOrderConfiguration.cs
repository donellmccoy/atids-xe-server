using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class PolicyOrderConfiguration : IEntityTypeConfiguration<PolicyOrder>
    {
        public void Configure(EntityTypeBuilder<PolicyOrder> entity)
        {
            entity.ToTable("POLICY_ORDER");

            entity.HasKey(e => e.PolicyOrderId);

            entity.Property(e => e.PolicyOrderId)
                  .HasColumnName("POLICY_ORDER_ID");

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
