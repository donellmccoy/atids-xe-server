using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class SubdivisionLevelsConfiguration : IEntityTypeConfiguration<SubdivisionLevels>
    {
        public void Configure(EntityTypeBuilder<SubdivisionLevels> entity)
        {
            entity.ToTable("SUBDIVISION_LEVELS");

            entity.HasKey(e => e.SubdivisionLevelId);

            entity.HasIndex(e => new { e.Level1, e.Level2, e.Level3 })
                  .HasName("SUBDIVISION_LEVELS_UC1")
                  .IsUnique();

            entity.Property(e => e.SubdivisionLevelId)
                  .HasColumnName("SUBDIVISION_LEVEL_ID");

            entity.Property(e => e.Level1)
                  .IsRequired()
                  .HasColumnName("LEVEL1")
                  .HasMaxLength(6)
                  .IsUnicode(false);

            entity.Property(e => e.Level2)
                  .IsRequired()
                  .HasColumnName("LEVEL2")
                  .HasMaxLength(6)
                  .IsUnicode(false);

            entity.Property(e => e.Level3)
                  .IsRequired()
                  .HasColumnName("LEVEL3")
                  .HasMaxLength(6)
                  .IsUnicode(false);
        }
    }
}
