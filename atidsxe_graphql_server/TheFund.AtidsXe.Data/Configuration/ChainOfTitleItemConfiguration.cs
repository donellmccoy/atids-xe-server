using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class ChainOfTitleItemConfiguration : IEntityTypeConfiguration<ChainOfTitleItem>
    {
        public void Configure(EntityTypeBuilder<ChainOfTitleItem> builder)
        {
            builder.ToTable("CHAIN_OF_TITLE_ITEM");

            builder.HasIndex(e => e.ChainOfTitleCategoryId)
                   .HasName("I_FK_CHAIN_OF_TITLE_ITEM_CHAIN_OF_TITLE_CATEGORY_ID");

            builder.HasIndex(e => e.ChainOfTitleId)
                   .HasName("I_FK_CHAIN_OF_TITLE_ITEM_CHAIN_OF_TITLE_ID");

            builder.HasIndex(e => e.TitleEventId)
                   .HasName("I_FK_CHAIN_OF_TITLE_ITEM_TITLE_EVENT_ID");

            builder.Property(p => p.ChainOfTitleItemId)
                   .HasColumnName("CHAIN_OF_TITLE_ITEM_ID");

            builder.Property(p => p.ChainOfTitleId)
                   .HasColumnName("CHAIN_OF_TITLE_ID");

            builder.Property(p => p.TitleEventId)
                   .HasColumnName("TITLE_EVENT_ID");

            builder.Property(p => p.ParentTitleEventId)
                   .HasColumnName("PARENT_TITLE_EVENT_ID");

            builder.Property(p => p.OrderIndex)
                   .HasColumnName("ORDER_INDEX");

            builder.Property(p => p.UserModified)
                   .HasColumnName("USER_MODIFIED");

            builder.Property(p => p.StartingTitleEvent)
                   .HasColumnName("STARTING_TITLE_EVENT");

            builder.Property(p => p.ChainOfTitleCategoryId)
                   .HasColumnName("CHAIN_OF_TITLE_CATEGORY_ID");

            builder.HasOne(d => d.ChainOfTitleCategory)
                   .WithMany(p => p.ChainOfTitleItem)
                   .HasForeignKey(d => d.ChainOfTitleCategoryId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_CHAIN_OF_TITLE_ITEM_CHAIN_OF_TITLE_CATEGORY");

            builder.HasOne(d => d.ChainOfTitle)
                   .WithMany(p => p.ChainOfTitleItems)
                   .HasForeignKey(d => d.ChainOfTitleId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_CHAIN_OF_TITLE_ITEM_CHAIN_OF_TITLE");

            builder.HasOne(d => d.TitleEvent)
                   .WithMany(p => p.ChainOfTitleItems)
                   .HasForeignKey(d => d.TitleEventId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_CHAIN_OF_TITLE_ITEM_TITLE_EVENT");
        }
    }
}
