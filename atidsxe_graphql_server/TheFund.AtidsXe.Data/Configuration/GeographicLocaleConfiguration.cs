using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class GeographicLocaleConfiguration : IEntityTypeConfiguration<GeographicLocale>
    {
        public void Configure(EntityTypeBuilder<GeographicLocale> builder)
        {
            builder.ToTable("GEOGRAPHIC_LOCALE");

            builder.HasKey(p => p.GeographicLocaleId);

            builder.HasIndex(e => e.GeographicLocaleTypeId)
                   .HasName("I_FK_GEOGRAPHIC_LOCALE_TYPE");

            builder.HasIndex(e => e.ParentGeographicLocaleId)
                   .HasName("I_FK_PARENT_GEO_LOCALE_ID");

            builder.HasIndex(e => new { e.LocaleName, e.GeographicLocaleTypeId, e.ParentGeographicLocaleId })
                   .HasName("UK_GEOGRAPHIC_LOCALE")
                   .IsUnique();

            builder.Property(e => e.GeographicLocaleId)
                   .HasColumnName("GEOGRAPHIC_LOCALE_ID");

            builder.Property(e => e.LocaleName)
                   .HasColumnName("LOCALE_NAME")
                   .IsUnicode(false)
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(e => e.LocaleAbbreviation)
                   .HasColumnName("LOCALE_ABBREVIATION")
                   .HasMaxLength(50)
                   .IsUnicode(false);

            builder.Property(e => e.GeographicLocaleTypeId)
                   .HasColumnName("GEOGRAPHIC_LOCALE_TYPE_ID");

            builder.Property(e => e.ParentGeographicLocaleId)
                   .HasColumnName("PARENT_GEOGRAPHIC_LOCALE_ID");

            builder.HasOne(d => d.GeographicLocaleType)
                   .WithMany(p => p.GeographicLocale)
                   .HasForeignKey(d => d.GeographicLocaleTypeId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_GEO_LOCALETYPE_GEO_LOCALE");

            builder.HasOne(d => d.ParentGeographicLocale)
                   .WithMany(p => p.InverseParentGeographicLocale)
                   .HasForeignKey(d => d.ParentGeographicLocaleId)
                   .HasConstraintName("FK_GEO_LOCALE_PARENT_LOCALE");
        }
    }
}
