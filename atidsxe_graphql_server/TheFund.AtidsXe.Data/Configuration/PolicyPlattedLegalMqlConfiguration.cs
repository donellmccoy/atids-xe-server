using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class PolicyPlattedLegalMqlConfiguration : IEntityTypeConfiguration<PolicyPlattedLegalMql>
    {
        public void Configure(EntityTypeBuilder<PolicyPlattedLegalMql> entity)
        {
            entity.ToTable("POLICY_PLATTED_LEGAL_MQL");

            entity.HasKey(e => new { e.PolicyId, e.PlatReferenceId, e.SubdivisionLevelId })
                  .HasName("PK_POLICY_PLATTED_LEGAL");

            entity.HasIndex(e => e.PlatReferenceId)
                  .HasName("I_FK_POLICY_PLATTED_LEGAL_MQL_PLAT_REFERENCE_ID");

            entity.HasIndex(e => e.SubdivisionLevelId)
                  .HasName("I_FK_POLICY_PLATTED_LEGAL_MQL_SUBDIVISION_LEVEL_ID");

            entity.Property(e => e.PolicyId)
                  .HasColumnName("POLICY_ID");

            entity.Property(e => e.PlatReferenceId)
                  .HasColumnName("PLAT_REFERENCE_ID");

            entity.Property(e => e.SubdivisionLevelId)
                  .HasColumnName("SUBDIVISION_LEVEL_ID");

            entity.HasOne(d => d.Policy)
                  .WithMany(p => p.PolicyPlattedLegalMqls)
                  .HasForeignKey(d => d.PolicyId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_POLICY_PLATTED_LEGAL");

            entity.HasOne(d => d.PlattedLegal)
                  .WithMany(p => p.PolicyPlattedLegalMqls)
                  .HasForeignKey(d => new { d.PlatReferenceId, d.SubdivisionLevelId })
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_PLATTED_LEGAL_POLICY");
        }
    }
}
