using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class WorksheetItemConfiguration : IEntityTypeConfiguration<WorksheetItem>
    {
        public void Configure(EntityTypeBuilder<WorksheetItem> builder)
        {
            builder.ToTable("WORKSHEET_ITEM");

            builder.HasKey(e => new { e.TitleEventId, e.WorksheetId });

            builder.HasIndex(e => e.WorksheetId)
                   .HasName("I_FK_WORKSHEET_ITEM_WORKSHEET_ID");

            builder.Property(p => p.TitleEventId)
                   .HasColumnName("TITLE_EVENT_ID");

            builder.Property(p => p.WorksheetId)
                   .HasColumnName("WORKSHEET_ID");

            builder.Property(p => p.Sequence)
                   .HasColumnName("SEQUENCE");

            builder.HasOne(d => d.TitleEvent)
                   .WithMany(p => p.WorksheetItems)
                   .HasForeignKey(d => d.TitleEventId)
                   .HasConstraintName("FK_TITLE_EVENT_WORKSHEET_ITEM");

            builder.HasOne(d => d.Worksheet)
                   .WithMany(p => p.WorksheetItems)
                   .HasForeignKey(d => d.WorksheetId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_WORKSHEET_WORKSHEET_ITEM");
        }
    }
}
