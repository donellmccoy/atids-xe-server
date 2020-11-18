using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class OwnerBuyerRelationshipConfiguration : IEntityTypeConfiguration<OwnerBuyerRelationship>
    {
        public void Configure(EntityTypeBuilder<OwnerBuyerRelationship> entity)
        {
            entity.ToTable("OWNER_BUYER_RELATIONSHIP");

            entity.HasKey(e => e.OwnerBuyerRelationshipId);

            entity.Property(e => e.OwnerBuyerRelationshipId)
                  .HasColumnName("OWNER_BUYER_RELATIONSHIP_ID")
                  .ValueGeneratedNever();

            entity.Property(e => e.Description)
                  .HasColumnName("DESCRIPTION")
                  .HasMaxLength(50)
                  .IsUnicode(false);
        }
    }
}
