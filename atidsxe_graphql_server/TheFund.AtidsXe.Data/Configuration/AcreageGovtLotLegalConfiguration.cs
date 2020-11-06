using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class AcreageGovtLotLegalConfiguration : IEntityTypeConfiguration<AcreageGovtLotLegal>
    {
        public void Configure(EntityTypeBuilder<AcreageGovtLotLegal> builder)
        {
            builder.ToTable("ACREAGE_GOVT_LOT_LEGAL");

            builder.HasKey(e => new { e.SearchId, e.GovernmentLotId, e.UnplattedReferenceId });

            builder.HasIndex(e => e.GovernmentLotId)
                   .HasName("I_FK_ACREAGE_GOVT_LOT_LEGAL_GOVERNMENT_LOT_ID");

            builder.HasIndex(e => e.UnplattedReferenceId)
                   .HasName("I_FK_ACREAGE_GOVT_LOT_LEGAL_UNPLATTED_REFERENCE_ID");

            builder.Property(e => e.SearchId)
                   .HasColumnName("SEARCH_ID");

            builder.Property(e => e.GovernmentLotId)
                   .HasColumnName("GOVERNMENT_LOT_ID");

            builder.Property(e => e.UnplattedReferenceId)
                   .HasColumnName("UNPLATTED_REFERENCE_ID");

            builder.HasOne(d => d.Search)
                   .WithMany(p => p.AcreageGovtLotLegals)
                   .HasForeignKey(d => d.SearchId)
                   .HasConstraintName("FK_ACRE_GOVT_LOT_LGL_SRCH");

            builder.HasOne(d => d.GovernmentLotLegal)
                   .WithMany(p => p.AcreageGovtLotLegal)
                   .HasForeignKey(d => new { d.UnplattedReferenceId, d.GovernmentLotId })
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_ACREAGE_GOVT_LOT_LEGAL_GOVERNMENT_LOT_LEGAL");
        }
    }
}
