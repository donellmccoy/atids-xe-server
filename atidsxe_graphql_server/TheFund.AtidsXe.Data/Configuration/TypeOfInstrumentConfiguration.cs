using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class TypeOfInstrumentConfiguration : IEntityTypeConfiguration<TypeOfInstrument>
    {
        public void Configure(EntityTypeBuilder<TypeOfInstrument> entity)
        {
            entity.ToTable("TYPE_OF_INSTRUMENT");

            entity.HasKey(e => e.TypeOfInstrumentId);

            entity.HasIndex(e => e.TypeOfInstrument1)
                  .HasName("TYPE_OF_INSTRUMENT_UC1")
                  .IsUnique();

            entity.Property(e => e.TypeOfInstrumentId)
                  .HasColumnName("TYPE_OF_INSTRUMENT_ID");

            entity.Property(e => e.Description)
                  .IsRequired()
                  .HasColumnName("DESCRIPTION")
                  .HasMaxLength(50)
                  .IsUnicode(false);

            entity.Property(e => e.TypeOfInstrument1)
                  .IsRequired()
                  .HasColumnName("TYPE_OF_INSTRUMENT")
                  .HasMaxLength(3)
                  .IsUnicode(false);
        }
    }
}
