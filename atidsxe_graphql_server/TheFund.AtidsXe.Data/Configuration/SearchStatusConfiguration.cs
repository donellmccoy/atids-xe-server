using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class SearchStatusConfiguration : IEntityTypeConfiguration<SearchStatus>
    {
        public void Configure(EntityTypeBuilder<SearchStatus> builder)
        {
            builder.ToTable("SEARCH_STATUS");

            builder.HasKey(p => p.SearchStatusId);

            builder.Property(e => e.SearchStatusId)
                   .HasColumnName("SEARCH_STATUS_ID");

            builder.Property(e => e.Description)
                   .HasColumnName("DESCRIPTION")
                   .HasMaxLength(25)
                   .IsUnicode(false)
                   .IsRequired();

            builder.HasMany(p => p.Searches)
                   .WithOne(p => p.SearchStatus)
                   .HasForeignKey(p => p.SearchStatusId);
        }
    }

}
