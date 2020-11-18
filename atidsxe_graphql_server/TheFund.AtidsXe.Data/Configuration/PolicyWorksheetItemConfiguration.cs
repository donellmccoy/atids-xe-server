using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class PolicyWorksheetItemConfiguration : IEntityTypeConfiguration<PolicyWorksheetItem>
    {
        public void Configure(EntityTypeBuilder<PolicyWorksheetItem> entity)
        {
            entity.ToTable("POLICY_WORKSHEET_ITEM");

            entity.HasKey(e => new { e.PolicyId, e.WorksheetId });

            entity.HasIndex(e => e.WorksheetId)
                  .HasName("IX_FKPOLICY_WORKSHEET_ITEM_WORKSHEET_ID");

            entity.Property(e => e.PolicyId)
                  .HasColumnName("POLICY_ID");

            entity.Property(e => e.WorksheetId)
                  .HasColumnName("WORKSHEET_ID");

            entity.Property(e => e.Sequence)
                  .HasColumnName("SEQUENCE");

            entity.HasOne(d => d.Policy)
                  .WithMany(p => p.PolicyWorksheetItems)
                  .HasForeignKey(d => d.PolicyId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_POLICY_POLICY_WORKSHEET_ITEM");

            entity.HasOne(d => d.Worksheet)
                  .WithMany(p => p.PolicyWorksheetItems)
                  .HasForeignKey(d => d.WorksheetId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_WORKSHEET_POLICY_WORKSHEET_ITEM");
        }
    }
}
