using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class TitleEventConfiguration : IEntityTypeConfiguration<TitleEvent>
    {
        public void Configure(EntityTypeBuilder<TitleEvent> entity)
        {
            entity.ToTable("TITLE_EVENT");

            entity.HasKey(e => e.TitleEventId);

            entity.HasIndex(e => e.CurrentExamStatusTypeId)
                  .HasName("I_CURRENT_EXAM_STATUS_TYPE");

            entity.HasIndex(e => e.OriginalExamStatusTypeId)
                  .HasName("I_ORIGINAL_EXAM_STATUS");

            entity.HasIndex(e => e.TitleEventStatusAssignorId)
                  .HasName("I_TITLE_EVT_STAT_ASSIGNOR");

            entity.HasIndex(e => e.TitleEventTypeId)
                  .HasName("I_EVENT_TYPE");

            entity.Property(e => e.TitleEventId)
                  .HasColumnName("TITLE_EVENT_ID");

            entity.Property(e => e.AdditionalInformation)
                  .HasColumnName("ADDITIONAL_INFORMATION")
                  .HasMaxLength(15)
                  .IsUnicode(false);

            entity.Property(e => e.Amount)
                  .HasColumnName("AMOUNT")
                  .HasColumnType("numeric(13, 2)");

            entity.Property(e => e.CreateDate)
                  .HasColumnName("CREATE_DATE")
                  .HasColumnType("datetime")
                  .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.CurrentExamStatusTypeId)
                  .HasColumnName("CURRENT_EXAM_STATUS_TYPE_ID");

            entity.Property(e => e.OriginalExamStatusTypeId)
                  .HasColumnName("ORIGINAL_EXAM_STATUS_TYPE_ID");

            entity.Property(e => e.Tag)
                  .HasColumnName("TAG")
                  .HasMaxLength(50)
                  .IsUnicode(false);

            entity.Property(e => e.TitleEventDate)
                  .HasColumnName("TITLE_EVENT_DATE")
                  .HasColumnType("datetime");

            entity.Property(e => e.TitleEventStatusAssignorId)
                  .HasColumnName("TITLE_EVENT_STATUS_ASSIGNOR_ID");

            entity.Property(e => e.TitleEventTypeId)
                  .HasColumnName("TITLE_EVENT_TYPE_ID");

            entity.HasMany(p => p.ChainOfTitleItems)
                  .WithOne(p => p.TitleEvent)
                  .HasForeignKey(p => p.TitleEventId);

            entity.HasMany(p => p.TitleSearchOriginations)
                  .WithOne(p => p.TitleEvent)
                  .HasForeignKey(p => p.TitleEventId);

            entity.HasMany(p => p.WorksheetItems)
                  .WithOne(p => p.TitleEvent)
                  .HasForeignKey(p => p.TitleEventId);

            entity.HasMany(p => p.NameSearchListItems)
                  .WithOne(p => p.ReferenceTitleEvent)
                  .HasForeignKey(p => p.ReferenceTitleEventId);

            entity.HasMany(p => p.TitleEventGovtLotLegalMqls)
                  .WithOne(p => p.TitleEvent)
                  .HasForeignKey(p => p.TitleEventId);

            entity.HasMany(p => p.TitleEventLegalEntityMqls)
                  .WithOne(p => p.TitleEvent)
                  .HasForeignKey(p => p.TitleEventId);

            entity.HasMany(p => p.TitleEventNotes)
                  .WithOne(p => p.TitleEvent)
                  .HasForeignKey(p => p.TitleEventId);

            entity.HasMany(p => p.TitleEventOrderTrackings)
                  .WithOne(p => p.TitleEvent)
                  .HasForeignKey(p => p.TitleEventId);

            entity.HasMany(p => p.TitleEventParties)
                  .WithOne(p => p.TitleEvent)
                  .HasForeignKey(p => p.TitleEventId);

            entity.HasMany(p => p.TitleEventPlattedLegalMqls)
                  .WithOne(p => p.TitleEvent)
                  .HasForeignKey(p => p.TitleEventId);

            entity.HasMany(p => p.TitleEventSearches)
                  .WithOne(p => p.TitleEvent)
                  .HasForeignKey(p => p.TitleEventId);

            entity.HasMany(p => p.TitleEventSectionLegalMqls)
                  .WithOne(p => p.TitleEvent)
                  .HasForeignKey(p => p.TitleEventId);
        }
    }
}
