using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class TownshipDirectionTypeConfiguration : IEntityTypeConfiguration<TownshipDirectionType>
    {
        public void Configure(EntityTypeBuilder<TownshipDirectionType> entity)
        {
            entity.ToTable("TOWNSHIP_DIRECTION_TYPE");

            entity.HasKey(e => e.TownshipDirectionTypeId);

            entity.Property(e => e.TownshipDirectionTypeId)
                  .HasColumnName("TOWNSHIP_DIRECTION_TYPE_ID")
                  .ValueGeneratedNever();

            entity.Property(e => e.Description)
                  .IsRequired()
                  .HasColumnName("DESCRIPTION")
                  .HasMaxLength(16)
                  .IsUnicode(false);
        }
    }
}
