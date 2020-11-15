using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class PolicyInsuredDocumentConfiguration : IEntityTypeConfiguration<PolicyInsuredDocument>
    {
        public void Configure(EntityTypeBuilder<PolicyInsuredDocument> builder)
        {
            builder.ToTable("POLICY_INSURED_DOCUMENT");

            builder.HasKey(e => new { e.PolicyId, e.GeographicLocaleId });

            builder.HasIndex(e => e.GeographicLocaleId)
                   .HasName("IX_FKPOLICY_INSURED_DOCUMENT_GEOGRAPHIC_LOCALE_ID");

            builder.Property(e => e.PolicyId)
                   .HasColumnName("POLICY_ID");

            builder.Property(e => e.GeographicLocaleId)
                   .HasColumnName("GEOGRAPHIC_LOCALE_ID");

            builder.Property(e => e.UnparsedInsuredDocument)
                   .HasColumnName("UNPARSED_INSURED_DOCUMENT")
                   .HasMaxLength(24)
                   .IsUnicode(false)
                   .IsRequired();

            builder.HasOne(d => d.GeographicLocale)
                   .WithMany(p => p.PolicyInsuredDocuments)
                   .HasForeignKey(d => d.GeographicLocaleId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_LOCATION_POLICY_INSURED_DOCUMENT");

            builder.HasOne(d => d.Policy)
                   .WithMany(p => p.PolicyInsuredDocuments)
                   .HasForeignKey(d => d.PolicyId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_POLICY_POLICY_INSURED_DOCUMENT");
        }
    }

}
