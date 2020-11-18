using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class UnplattedReferenceConfiguration : IEntityTypeConfiguration<UnplattedReference>
    {
        public void Configure(EntityTypeBuilder<UnplattedReference> entity)
        {
            entity.ToTable("UNPLATTED_REFERENCE");

            entity.HasKey(e => e.UnplattedReferenceId);

            entity.HasIndex(e => e.BreakdownCodeTypeId)
                  .HasName("I_FK_BRKDWN_CODE_TYPE");

            entity.HasIndex(e => e.RangeDirectionTypeId)
                  .HasName("I_FK_RANGE_DIRECTION_TYPE");

            entity.HasIndex(e => e.TownshipDirectionTypeId)
                  .HasName("I_FK_TOWNSHIP_DIRECTION");

            entity.HasIndex(e => new { e.Meridian, e.Range, e.RangeDirectionTypeId, e.Township, e.TownshipDirectionTypeId, e.Section, e.UnplattedReferenceId })
                  .HasName("IX_UNPLATTED_REFERENCE_SMQ1");

            entity.Property(e => e.UnplattedReferenceId)
                  .HasColumnName("UNPLATTED_REFERENCE_ID");

            entity.Property(e => e.BreakdownCodeTypeId)
                  .HasColumnName("BREAKDOWN_CODE_TYPE_ID");

            entity.Property(e => e.Meridian)
                  .IsRequired()
                  .HasColumnName("MERIDIAN")
                  .HasMaxLength(50)
                  .IsUnicode(false);

            entity.Property(e => e.Range)
                  .IsRequired()
                  .HasColumnName("RANGE")
                  .HasMaxLength(50)
                  .IsUnicode(false);

            entity.Property(e => e.RangeDirectionTypeId)
                  .HasColumnName("RANGE_DIRECTION_TYPE_ID");

            entity.Property(e => e.Section)
                  .IsRequired()
                  .HasColumnName("SECTION")
                  .HasMaxLength(50)
                  .IsUnicode(false);

            entity.Property(e => e.Township)
                  .IsRequired()
                  .HasColumnName("TOWNSHIP")
                  .HasMaxLength(50)
                  .IsUnicode(false);

            entity.Property(e => e.TownshipDirectionTypeId)
                  .HasColumnName("TOWNSHIP_DIRECTION_TYPE_ID");

            entity.HasOne(d => d.BreakdownCodeType)
                  .WithMany(p => p.UnplattedReferences)
                  .HasForeignKey(d => d.BreakdownCodeTypeId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_BRKDWN_CD_TYPE_UNPLAT_REF");

            entity.HasOne(d => d.RangeDirectionType)
                  .WithMany(p => p.UnplattedReferences)
                  .HasForeignKey(d => d.RangeDirectionTypeId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_RNG_DIR_TYPE_UNPLATTED_REF");

            entity.HasOne(d => d.TownshipDirectionType)
                  .WithMany(p => p.UnplattedReferences)
                  .HasForeignKey(d => d.TownshipDirectionTypeId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_TWNSHP_DIR_TYPE_UNPLAT_REF");
        }
    }
}
