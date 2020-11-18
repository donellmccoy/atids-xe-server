using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class PolicyRestrictionTypeConfiguration : IEntityTypeConfiguration<PolicyRestrictionType>
    {
        public void Configure(EntityTypeBuilder<PolicyRestrictionType> entity)
        {
            entity.ToTable("POLICY_RESTRICTION_TYPE");

            entity.HasKey(e => e.PolicyRestrictionTypeId);

            entity.Property(e => e.PolicyRestrictionTypeId)
                  .HasColumnName("POLICY_RESTRICTION_TYPE_ID");

            entity.Property(e => e.Description)
                  .IsRequired()
                  .HasColumnName("DESCRIPTION")
                  .HasMaxLength(25)
                  .IsUnicode(false);
        }
    }
}
