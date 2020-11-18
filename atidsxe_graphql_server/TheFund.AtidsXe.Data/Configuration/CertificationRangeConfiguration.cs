using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class CertificationRangeConfiguration : IEntityTypeConfiguration<CertificationRange>
    {
        public void Configure(EntityTypeBuilder<CertificationRange> builder)
        {
            builder.ToTable("CERTIFICATION_RANGE");

            builder.HasKey(p => p.CertificationRangeId);

            builder.HasIndex(e => e.ToOrDocumentId)
                   .HasDatabaseName("I_FK_CERTIFICATION_RANGE_TO_OR_DOCUMENT_ID");

            builder.HasIndex(e => new { e.FromOrDocumentId, e.ToOrDocumentId })
                   .HasDatabaseName("I_FK_DOCUMENT");

            builder.Property(e => e.CertificationRangeId)
                   .HasColumnName("CERTIFICATION_RANGE_ID");

            builder.Property(e => e.FromDate)
                   .HasColumnName("FROM_DATE");

            builder.Property(e => e.FromOrDocumentId)
                   .HasColumnName("FROM_OR_DOCUMENT_ID");

            builder.Property(e => e.ToDate)
                   .HasColumnName("TO_DATE");

            builder.Property(e => e.ToOrDocumentId)
                   .HasColumnName("TO_OR_DOCUMENT_ID");

            builder.HasMany(p => p.SearchGeographicCertRanges)
                   .WithOne(p => p.GeographicCertRange)
                   .HasForeignKey(p => p.GeographicCertRangeId);

            builder.HasMany(p => p.SearchGiCertRanges)
                   .WithOne(p => p.GiCertRange)
                   .HasForeignKey(p => p.GiCertRangeId);

            builder.HasMany(p => p.SearchGrantorCertRanges)
                   .WithOne(p => p.GrantorCertRange)
                   .HasForeignKey(p => p.GrantorCertRangeId);

            builder.HasOne(d => d.FromOrDocument)
                   .WithMany(p => p.CertificationRangeFromOrDocuments)
                   .HasForeignKey(d => d.FromOrDocumentId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_ORD_CERT_RANGE_FROM");

            builder.HasOne(d => d.ToOrDocument)
                   .WithMany(p => p.CertificationRangeToOrDocuments)
                   .HasForeignKey(d => d.ToOrDocumentId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_ORD_CERT_RANGE_TO");
        }
    }
}
