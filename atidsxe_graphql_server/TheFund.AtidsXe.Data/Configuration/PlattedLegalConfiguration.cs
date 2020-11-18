using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class PlattedLegalConfiguration : IEntityTypeConfiguration<PlattedLegal>
    {
        public void Configure(EntityTypeBuilder<PlattedLegal> builder)
        {
            builder.ToTable("PLATTED_LEGAL");

            builder.HasKey(e => new { e.PlatReferenceId, e.SubdivisionLevelId });

            builder.HasIndex(e => e.SubdivisionLevelId)
                   .HasName("I_FK_PLATTED_LEGAL_SUBDIVISION_LEVEL_ID");

            builder.Property(e => e.PlatReferenceId)
                   .HasColumnName("PLAT_REFERENCE_ID");

            builder.Property(e => e.SubdivisionLevelId)
                   .HasColumnName("SUBDIVISION_LEVEL_ID");

            builder.HasOne(d => d.PlatReference)
                   .WithMany(p => p.PlattedLegals)
                   .HasForeignKey(d => d.PlatReferenceId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_PLAT_REFERENCE_PLATTD_LEGAL");

            builder.HasOne(d => d.SubdivisionLevel)
                   .WithMany(p => p.PlattedLegals)
                   .HasForeignKey(d => d.SubdivisionLevelId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_SUBDIV_LEVELS_PLATTED_LEGAL");

            builder.HasMany(p => p.PolicyPlattedLegalMqls)
                   .WithOne(p => p.PlattedLegal)
                   .HasForeignKey(p => new { p.PlatReferenceId, p.SubdivisionLevelId });

            builder.HasMany(p => p.SubdivisionPlattedLegals)
                   .WithOne(p => p.PlattedLegal)
                   .HasForeignKey(p => new { p.PlatReferenceId, p.SubdivisionLevelId });

            builder.HasMany(p => p.TitleEventPlattedLegalMqls)
                   .WithOne(p => p.PlattedLegal)
                   .HasForeignKey(p => new { p.PlatReferenceId, p.SubdivisionLevelId });
        }
    }

}
