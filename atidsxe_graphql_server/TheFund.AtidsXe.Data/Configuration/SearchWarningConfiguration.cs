using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class SearchWarningConfiguration : IEntityTypeConfiguration<SearchWarning>
    {
        public void Configure(EntityTypeBuilder<SearchWarning> entity)
        {
            entity.ToTable("SEARCH_WARNING");

            entity.HasIndex(e => e.SearchId)
                  .HasName("I_FK_SEARCH");

            entity.HasIndex(e => e.SearchWarningTypeId)
                  .HasName("I_FK_SEARCH_WARNING_TYPE");

            entity.Property(e => e.SearchWarningId)
                  .HasColumnName("SEARCH_WARNING_ID");

            entity.Property(e => e.CreateDate)
                  .HasColumnName("CREATE_DATE")
                  .HasColumnType("datetime")
                  .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.SearchId)
                  .HasColumnName("SEARCH_ID");

            entity.Property(e => e.SearchWarningTypeId)
                  .HasColumnName("SEARCH_WARNING_TYPE_ID");

            entity.Property(e => e.UnparsedSearchWarning)
                  .IsRequired()
                  .HasColumnName("UNPARSED_SEARCH_WARNING")
                  .HasMaxLength(1024)
                  .IsUnicode(false);

            entity.HasOne(d => d.Search)
                  .WithMany(p => p.SearchWarnings)
                  .HasForeignKey(d => d.SearchId)
                  .HasConstraintName("FK_SEARCH_SEARCH_WARNING");

            entity.HasOne(d => d.SearchWarningType)
                  .WithMany(p => p.SearchWarning)
                  .HasForeignKey(d => d.SearchWarningTypeId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_SRCH_WARN_TYPE_SRCH_WARNING");
        }
    }
}
