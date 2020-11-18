using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class TitleEventTypeCategoryConfiguration : IEntityTypeConfiguration<TitleEventTypeCategory>
    {
        public void Configure(EntityTypeBuilder<TitleEventTypeCategory> entity)
        {
            entity.ToTable("TITLE_EVENT_TYPE_CATEGORY");

            entity.HasKey(e => e.TitleEventCategoryId);

            entity.HasIndex(e => e.Description)
                  .HasDatabaseName("TITLE_EVENT_TYPE_CATEGORY_UC1")
                  .IsUnique();

            entity.Property(e => e.TitleEventCategoryId)
                  .HasColumnName("TITLE_EVENT_CATEGORY_ID")
                  .ValueGeneratedNever();

            entity.Property(e => e.Description)
                  .IsRequired()
                  .HasColumnName("DESCRIPTION")
                  .HasMaxLength(50)
                  .IsUnicode(false);
        }
    }
}
