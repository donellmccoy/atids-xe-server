using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class PolicyGovtLotLegalMqlConfiguration : IEntityTypeConfiguration<PolicyGovtLotLegalMql>
    {
        public void Configure(EntityTypeBuilder<PolicyGovtLotLegalMql> builder)
        {
            builder.ToTable("POLICY_GOVT_LOT_LEGAL_MQL");

            builder.HasKey(e => new { e.PolicyId, e.GovernmentLotId, e.UnplattedReferenceId })
                   .HasName("PK_POLICY_GOVT_LOT_LEGAL");

            builder.HasIndex(e => e.GovernmentLotId)
                   .HasDatabaseName("I_FK_POLICY_GOVT_LOT_LEGAL_MQL_GOVERNMENT_LOT_ID");

            builder.HasIndex(e => e.UnplattedReferenceId)
                   .HasDatabaseName("I_FK_POLICY_GOVT_LOT_LEGAL_MQL_UNPLATTED_REFERENCE_ID");

            builder.Property(e => e.PolicyId)
                   .HasColumnName("POLICY_ID");

            builder.Property(e => e.GovernmentLotId)
                   .HasColumnName("GOVERNMENT_LOT_ID");

            builder.Property(e => e.UnplattedReferenceId)
                   .HasColumnName("UNPLATTED_REFERENCE_ID");

            builder.HasOne(d => d.Policy)
                   .WithMany(p => p.PolicyGovtLotLegalMqls)
                   .HasForeignKey(d => d.PolicyId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_POLICY_GOVT_LOT_LEGAL");

            builder.HasOne(d => d.GovernmentLotLegal)
                   .WithMany(p => p.PolicyGovtLotLegalMqls)
                   .HasForeignKey(d => new { d.UnplattedReferenceId, d.GovernmentLotId })
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_GOVT_LOT_LEGAL_POLICY");
        }
    }

}
