using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class GovernmentLotConfiguration : IEntityTypeConfiguration<GovernmentLot>
    {
        public void Configure(EntityTypeBuilder<GovernmentLot> builder)
        {
            builder.ToTable("GOVERNMENT_LOT");

            builder.HasKey(p => p.GovernmentLotId);

            builder.HasIndex(e => e.GovernmentLotNumber)
                   .HasName("GOVERNMENT_LOT_UC1")
                   .IsUnique();

            builder.Property(e => e.GovernmentLotId)
                   .HasColumnName("GOVERNMENT_LOT_ID")
                   .ValueGeneratedNever();

            builder.Property(e => e.GovernmentLotNumber)
                   .HasColumnName("GOVERNMENT_LOT_NUMBER")
                   .HasMaxLength(10)
                   .IsUnicode(false)
                   .IsRequired();

            builder.HasMany(p => p.GovernmentLotLegal)
                   .WithOne(p => p.GovernmentLot)
                   .HasForeignKey(p => p.GovernmentLotId);
        }
    }
}
