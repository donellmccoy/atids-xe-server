using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class PolicyConfiguration : IEntityTypeConfiguration<Policy>
    {
        public void Configure(EntityTypeBuilder<Policy> entity)
        {
            entity.ToTable("POLICY");

            entity.HasKey(e => e.PolicyId);

            entity.HasIndex(e => e.PolicyRestrictionTypeId)
                  .HasDatabaseName("I_FK_POLICY_POLICY_RESTRICTION_TYPE_ID");

            entity.Property(e => e.PolicyId)
                  .HasColumnName("POLICY_ID");

            entity.Property(e => e.CreateDate)
                  .HasColumnName("CREATE_DATE")
                  .HasColumnType("datetime")
                  .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.EffectiveDate)
                  .HasColumnName("EFFECTIVE_DATE")
                  .HasColumnType("datetime");

            entity.Property(e => e.ImageAvailable)
                  .HasColumnName("IMAGE_AVAILABLE");

            entity.Property(e => e.InsuredAmount)
                  .HasColumnName("INSURED_AMOUNT")
                  .HasColumnType("numeric(11, 2)");

            entity.Property(e => e.MemberNumber)
                  .IsRequired()
                  .HasColumnName("MEMBER_NUMBER")
                  .HasMaxLength(7)
                  .IsUnicode(false);

            entity.Property(e => e.PolicyNumber)
                  .HasColumnName("POLICY_NUMBER");

            entity.Property(e => e.PolicyRestrictionTypeId)
                  .HasColumnName("POLICY_RESTRICTION_TYPE_ID");

            entity.Property(e => e.PolicyType)
                  .IsRequired()
                  .HasColumnName("POLICY_TYPE")
                  .HasMaxLength(5)
                  .IsUnicode(false);

            entity.Property(e => e.SystemUpdateDate)
                  .HasColumnName("SYSTEM_UPDATE_DATE")
                  .HasColumnType("datetime");

            entity.Property(e => e.TitleBaseIndicator)
                  .HasColumnName("TITLE_BASE_INDICATOR");

            entity.Property(e => e.UserUpdateDate)
                  .HasColumnName("USER_UPDATE_DATE")
                  .HasColumnType("datetime");

            entity.HasOne(d => d.PolicyRestrictionType)
                  .WithMany(p => p.Policies)
                  .HasForeignKey(d => d.PolicyRestrictionTypeId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_POLICY_POLICY_RESTRICTION_TYPE");

            entity.HasMany(p => p.PolicyGovtLotLegalMqls)
                  .WithOne(p => p.Policy)
                  .HasForeignKey(p => p.PolicyId);

            entity.HasMany(p => p.PolicyInsuredDocuments)
                  .WithOne(p => p.Policy)
                  .HasForeignKey(p => p.PolicyId);

            entity.HasMany(p => p.PolicyNotes)
                  .WithOne(p => p.Policy)
                  .HasForeignKey(p => p.PolicyId);

            entity.HasMany(p => p.PolicyOrderTrackings)
                  .WithOne(p => p.Policy)
                  .HasForeignKey(p => p.PolicyId);

            entity.HasMany(p => p.PolicyPlattedLegalMqls)
                  .WithOne(p => p.Policy)
                  .HasForeignKey(p => p.PolicyId);

            entity.HasMany(p => p.PolicySearches)
                  .WithOne(p => p.Policy)
                  .HasForeignKey(p => p.PolicyId);

            entity.HasMany(p => p.PolicySectionLegalMqls)
                  .WithOne(p => p.Policy)
                  .HasForeignKey(p => p.PolicyId);

            entity.HasMany(p => p.PolicyWorksheetItems)
                  .WithOne(p => p.Policy)
                  .HasForeignKey(p => p.PolicyId);
        }
    }
}
