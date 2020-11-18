using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class TitleEventNotesConfiguration : IEntityTypeConfiguration<TitleEventNotes>
    {
        public void Configure(EntityTypeBuilder<TitleEventNotes> entity)
        {
            entity.ToTable("TITLE_EVENT_NOTES");

            entity.HasKey(e => e.TitleEventNotesId);

            entity.HasIndex(e => e.TitleEventId)
                  .HasDatabaseName("I_TITLE_EVENT");

            entity.Property(e => e.TitleEventNotesId)
                  .HasColumnName("TITLE_EVENT_NOTES_ID");

            entity.Property(e => e.Message)
                  .IsRequired()
                  .HasColumnName("MESSAGE")
                  .HasMaxLength(1024)
                  .IsUnicode(false);

            entity.Property(e => e.TimeStamp)
                  .HasColumnName("TIME_STAMP")
                  .HasColumnType("datetime");

            entity.Property(e => e.TitleEventId)
                  .HasColumnName("TITLE_EVENT_ID");

            entity.Property(e => e.UserId)
                  .IsRequired()
                  .HasColumnName("USER_ID")
                  .HasMaxLength(30)
                  .IsUnicode(false);

            entity.HasOne(d => d.TitleEvent)
                  .WithMany(p => p.TitleEventNotes)
                  .HasForeignKey(d => d.TitleEventId)
                  .HasConstraintName("FK_TITLE_EVENT_NOTES");
        }
    }
}
