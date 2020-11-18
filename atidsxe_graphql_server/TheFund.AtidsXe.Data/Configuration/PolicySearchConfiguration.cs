using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class PolicySearchConfiguration : IEntityTypeConfiguration<PolicySearch>
    {
        public void Configure(EntityTypeBuilder<PolicySearch> entity)
        {
            entity.ToTable("POLICY_SEARCH");

            entity.HasKey(e => new { e.PolicyId, e.SearchId });

            entity.HasIndex(e => e.SearchId)
                  .HasDatabaseName("I_FK_POLICY_SEARCH_SEARCH_ID");

            entity.Property(e => e.PolicyId)
                  .HasColumnName("POLICY_ID");

            entity.Property(e => e.SearchId)
                  .HasColumnName("SEARCH_ID");

            entity.HasOne(d => d.Policy)
                  .WithMany(p => p.PolicySearches)
                  .HasForeignKey(d => d.PolicyId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_POLICY_POLICY_SEARCH");

            entity.HasOne(d => d.Search)
                  .WithMany(p => p.PolicySearches)
                  .HasForeignKey(d => d.SearchId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_SEARCH_POLICY_SEARCH");
        }
    }
}
