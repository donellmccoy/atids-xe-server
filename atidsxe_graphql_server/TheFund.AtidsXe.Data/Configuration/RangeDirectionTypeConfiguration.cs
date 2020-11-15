using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class RangeDirectionTypeConfiguration : IEntityTypeConfiguration<RangeDirectionType>
    {
        public void Configure(EntityTypeBuilder<RangeDirectionType> entity)
        {
            entity.ToTable("RANGE_DIRECTION_TYPE");

            entity.HasKey(e => e.RangeDirectionTypeId);

            entity.Property(e => e.RangeDirectionTypeId)
                  .HasColumnName("RANGE_DIRECTION_TYPE_ID")
                  .ValueGeneratedNever();

            entity.Property(e => e.Description)
                  .IsRequired()
                  .HasColumnName("DESCRIPTION")
                  .HasMaxLength(16)
                  .IsUnicode(false);

            entity.HasMany(p => p.UnplattedReferences)
                  .WithOne(p => p.RangeDirectionType)
                  .HasForeignKey(p => p.RangeDirectionTypeId);
        }
    }
}
