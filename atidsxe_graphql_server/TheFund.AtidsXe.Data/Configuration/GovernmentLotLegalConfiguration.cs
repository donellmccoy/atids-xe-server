using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class GovernmentLotLegalConfiguration : IEntityTypeConfiguration<GovernmentLotLegal>
    {
        public void Configure(EntityTypeBuilder<GovernmentLotLegal> builder)
        {
            builder.ToTable("GOVERNMENT_LOT_LEGAL");

            builder.HasKey(e => new { e.UnplattedReferenceId, e.GovernmentLotId });

            builder.HasIndex(e => e.GovernmentLotId)
                   .HasName("I_FK_GOVERNMENT_LOT_LEGAL_GOVERNMENT_LOT_ID");

            builder.HasIndex(e => e.UnplattedReferenceId)
                   .HasName("I_FK_ACREAGE_SECTION_LEGAL_UNPLATTED_REFERENCE_ID");

            builder.Property(e => e.UnplattedReferenceId)
                   .HasColumnName("UNPLATTED_REFERENCE_ID");

            builder.Property(e => e.GovernmentLotId)
                   .HasColumnName("GOVERNMENT_LOT_ID");

            builder.HasOne(d => d.GovernmentLot)
                   .WithMany(p => p.GovernmentLotLegals)
                   .HasForeignKey(d => d.GovernmentLotId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_GOVT_LOT_GOVT_LOT_LEGAL");

            builder.HasOne(d => d.UnplattedReference)
                   .WithMany(p => p.GovernmentLotLegals)
                   .HasForeignKey(d => d.UnplattedReferenceId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_UNPLAT_REF_GOVT_LOT_LEGAL");
        }
    }
}
