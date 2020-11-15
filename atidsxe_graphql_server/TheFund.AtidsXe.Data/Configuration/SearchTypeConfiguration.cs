using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class SearchTypeConfiguration : IEntityTypeConfiguration<SearchType>
    {
        public void Configure(EntityTypeBuilder<SearchType> builder)
        {
            builder.ToTable("SEARCH_TYPE");

            builder.HasKey(p => p.SearchTypeId);

            builder.Property(e => e.SearchTypeId)
                   .HasColumnName("SEARCH_TYPE_ID");

            builder.Property(e => e.Description)
                   .HasColumnName("DESCRIPTION")
                   .HasMaxLength(25)
                   .IsUnicode(false)
                   .IsRequired();

            builder.HasMany(p => p.Searches)
                   .WithOne(p => p.SearchType)
                   .HasForeignKey(p => p.SearchTypeId);
        }
    }
}
