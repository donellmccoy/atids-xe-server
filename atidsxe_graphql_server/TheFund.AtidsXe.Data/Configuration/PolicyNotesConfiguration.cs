using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class PolicyNotesConfiguration : IEntityTypeConfiguration<PolicyNotes>
    {
        public void Configure(EntityTypeBuilder<PolicyNotes> entity)
        {
            entity.ToTable("POLICY_NOTES");

            entity.HasKey(e => e.PolicyNotesId);

            entity.HasIndex(e => e.PolicyId)
                  .HasName("I_FK_POLICY_NOTES_POLICY_ID");

            entity.Property(e => e.PolicyNotesId)
                  .HasColumnName("POLICY_NOTES_ID");

            entity.Property(e => e.Message)
                  .IsRequired()
                  .HasColumnName("MESSAGE")
                  .HasMaxLength(1024)
                  .IsUnicode(false);

            entity.Property(e => e.PolicyId)
                  .HasColumnName("POLICY_ID");

            entity.Property(e => e.TimeStamp)
                  .HasColumnName("TIME_STAMP")
                  .HasColumnType("datetime");

            entity.Property(e => e.UserId)
                  .IsRequired()
                  .HasColumnName("USER_ID")
                  .HasMaxLength(30)
                  .IsUnicode(false);

            entity.HasOne(d => d.Policy)
                  .WithMany(p => p.PolicyNotes)
                  .HasForeignKey(d => d.PolicyId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_POLICY_POLICY_NOTES");
        }
    }
}
