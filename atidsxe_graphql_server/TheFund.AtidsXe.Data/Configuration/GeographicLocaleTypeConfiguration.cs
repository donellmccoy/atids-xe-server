using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class GeographicLocaleTypeConfiguration : IEntityTypeConfiguration<GeographicLocaleType>
    {
        public void Configure(EntityTypeBuilder<GeographicLocaleType> builder)
        {
            builder.ToTable("GEOGRAPHIC_LOCALE_TYPE");

            builder.HasKey(p => p.GeographicLocaleTypeId);

            builder.HasIndex(e => e.TypeName)
                   .HasName("GEOGRAPHIC_LOCALE_TYPE_UC1")
                   .IsUnique();

            builder.Property(e => e.GeographicLocaleTypeId)
                   .HasColumnName("GEOGRAPHIC_LOCALE_TYPE_ID")
                   .ValueGeneratedNever();

            builder.Property(e => e.TypeName)
                   .HasColumnName("TYPE_NAME")
                   .HasMaxLength(50)
                   .IsUnicode(false)
                   .IsRequired();

            builder.HasMany(p => p.GeographicLocales)
                   .WithOne(p => p.GeographicLocaleType)
                   .HasForeignKey(p => p.GeographicLocaleTypeId);
        }
    }
}
