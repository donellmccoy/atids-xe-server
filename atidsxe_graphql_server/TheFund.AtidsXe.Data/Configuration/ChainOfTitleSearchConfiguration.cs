using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class ChainOfTitleSearchConfiguration : IEntityTypeConfiguration<ChainOfTitleSearch>
    {
        public void Configure(EntityTypeBuilder<ChainOfTitleSearch> builder)
        {
            builder.ToTable("CHAIN_OF_TITLE_SEARCH");

            builder.HasKey(e => new { e.SearchId, e.ChainOfTitleId })
                   .HasName("PK_CHAIN_OF_TITLE_SEARCH_1");

            builder.HasIndex(e => e.SearchId);

            builder.Property(p => p.ChainOfTitleId)
                   .HasColumnName("CHAIN_OF_TITLE_ID");

            builder.Property(p => p.SearchId)
                   .HasColumnName("SEARCH_ID");

            builder.HasOne(d => d.ChainOfTitle)
                   .WithMany(p => p.ChainOfTitleSearches)
                   .HasForeignKey(d => d.ChainOfTitleId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_CHAIN_OF_TITLE_SEARCH_CHAIN_OF_TITLE");

            builder.HasOne(d => d.Search)
                   .WithMany(p => p.ChainOfTitleSearches)
                   .HasForeignKey(d => d.SearchId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_CHAIN_OF_TITLE_SEARCH_SEARCH");
        }
    }
}
