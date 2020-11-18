using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class TitleEventSearchConfiguration : IEntityTypeConfiguration<TitleEventSearch>
    {
        public void Configure(EntityTypeBuilder<TitleEventSearch> entity)
        {
            entity.ToTable("TITLE_EVENT_SEARCH");

            entity.HasKey(e => new { e.TitleEventId, e.SearchId });

            entity.HasIndex(e => new { e.SearchId, e.TitleEventId })
                  .HasName("IX_SEARCH_ID_TITLE_EVENT_ID");

            entity.Property(e => e.TitleEventId)
                  .HasColumnName("TITLE_EVENT_ID");

            entity.Property(e => e.SearchId)
                  .HasColumnName("SEARCH_ID");

            entity.HasOne(d => d.Search)
                  .WithMany(p => p.TitleEventSearches)
                  .HasForeignKey(d => d.SearchId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_TITLE_EVENT_SEARCH_ID");

            entity.HasOne(d => d.TitleEvent)
                  .WithMany(p => p.TitleEventSearches)
                  .HasForeignKey(d => d.TitleEventId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_TITLE_EVENT_TITLE_EVENT_ID");
        }
    }
}
