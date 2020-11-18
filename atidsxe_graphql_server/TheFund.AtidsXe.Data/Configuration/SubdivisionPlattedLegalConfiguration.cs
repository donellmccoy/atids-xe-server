using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class SubdivisionPlattedLegalConfiguration : IEntityTypeConfiguration<SubdivisionPlattedLegal>
    {
        public void Configure(EntityTypeBuilder<SubdivisionPlattedLegal> entity)
        {
            entity.ToTable("SUBDIVISION_PLATTED_LEGAL");

            entity.HasKey(e => new { e.SearchId, e.PlatReferenceId, e.SubdivisionLevelId });

            entity.HasIndex(e => e.PlatReferenceId)
                  .HasDatabaseName("IX_SBDV_PLT_LGL_PLT_REF_ID");

            entity.HasIndex(e => e.SearchId)
                  .HasDatabaseName("IX_SBDV_PLT_LGL_SBDV_SRCH_ID");

            entity.HasIndex(e => e.SubdivisionLevelId)
                  .HasDatabaseName("IX_SBDV_PLT_LGL_SBDV_LVL_ID");

            entity.Property(e => e.SearchId)
                  .HasColumnName("SEARCH_ID");

            entity.Property(e => e.PlatReferenceId)
                  .HasColumnName("PLAT_REFERENCE_ID");

            entity.Property(e => e.SubdivisionLevelId)
                  .HasColumnName("SUBDIVISION_LEVEL_ID");

            entity.HasOne(d => d.Search)
                  .WithMany(p => p.SubdivisionPlattedLegals)
                  .HasForeignKey(d => d.SearchId)
                  .HasConstraintName("FK_SUBD_PLATTED_LGL_SRCH");

            entity.HasOne(d => d.PlattedLegal)
                  .WithMany(p => p.SubdivisionPlattedLegals)
                  .HasForeignKey(d => new { d.PlatReferenceId, d.SubdivisionLevelId })
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_SBDV_PLT_LGL_PLT_LGL");
        }
    }
}
