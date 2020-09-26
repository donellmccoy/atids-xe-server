using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class WorksheetConfiguration : IEntityTypeConfiguration<Worksheet>
    {
        public void Configure(EntityTypeBuilder<Worksheet> builder)
        {
            builder.ToTable("WORKSHEET");

            builder.HasIndex(e => e.FileReferenceId)
                   .HasName("WORKSHEET_UC1")
                   .IsUnique();

            builder.Property(p => p.WorksheetId)
                   .HasColumnName("WORKSHEET_ID");

            builder.Property(p => p.FileReferenceId)
                   .HasColumnName("FILE_REFERENCE_ID");

            builder.HasOne(d => d.FileReference)
                   .WithOne(p => p.Worksheet)
                   .HasForeignKey<Worksheet>(d => d.FileReferenceId)
                   .HasConstraintName("FK_FILE_REFERENCE_WKSHEET");

            builder.HasMany(p => p.WorksheetItems)
                   .WithOne(p => p.Worksheet)
                   .HasForeignKey(p => new { p.TitleEventId, p.WorksheetId });
        }
    }
}
