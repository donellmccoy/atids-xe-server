using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class PlatPropertiesConfiguration : IEntityTypeConfiguration<PlatProperties>
    {
        public void Configure(EntityTypeBuilder<PlatProperties> builder)
        {
            builder.ToTable("PLAT_PROPERTIES");

            builder.HasKey(p => p.PlatReferenceId);

            builder.Property(e => e.PlatReferenceId)
                   .HasColumnName("PLAT_REFERENCE_ID")
                   .ValueGeneratedNever();

            builder.Property(e => e.CertificationDate)
                   .HasColumnName("CERTIFICATION_DATE");

            builder.Property(e => e.PlatName)
                   .HasColumnName("PLAT_NAME")
                   .IsUnicode(false)
                   .HasMaxLength(184);

            builder.Property(e => e.PlatDate)
                   .HasColumnName("PLAT_DATE");

            builder.Property(e => e.PostingsConform)
                   .HasColumnName("POSTINGS_CONFORM");

            builder.Property(e => e.IntervalOwnership)
                   .HasColumnName("INTERVAL_OWNERSHIP");

            builder.Property(e => e.RetroCertified)
                   .HasColumnName("RETRO_CERTIFIED");

            builder.Property(e => e.PrimaryHierarchy)
                   .HasColumnName("PRIMARY_HIERARCHY")
                   .IsUnicode(false);

            builder.Property(e => e.AlternateHierarchy1)
                   .HasColumnName("ALTERNATE_HIERARCHY_1")
                   .HasMaxLength(64)
                   .IsUnicode(false);

            builder.Property(e => e.AlternateHierarchy2)
                   .HasColumnName("ALTERNATE_HIERARCHY_2")
                   .HasMaxLength(64)
                   .IsUnicode(false);

            builder.HasOne(d => d.PlatReference)
                   .WithOne(p => p.PlatProperties)
                   .HasForeignKey<PlatProperties>(d => d.PlatReferenceId)
                   .HasConstraintName("FK_PLAT_REFERENCE_PROPERTIES");
        }
    }

}
