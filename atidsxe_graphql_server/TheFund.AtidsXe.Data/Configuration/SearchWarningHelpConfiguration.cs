using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class SearchWarningHelpConfiguration : IEntityTypeConfiguration<SearchWarningHelp>
    {
        public void Configure(EntityTypeBuilder<SearchWarningHelp> entity)
        {
            entity.ToTable("SEARCH_WARNING_HELP");

            entity.HasKey(e => e.SearchWarningTypeId);

            entity.Property(e => e.SearchWarningTypeId)
                  .HasColumnName("SEARCH_WARNING_TYPE_ID")
                  .ValueGeneratedNever();

            entity.Property(e => e.HelpText)
                  .IsRequired()
                  .HasColumnName("HELP_TEXT")
                  .HasMaxLength(256)
                  .IsUnicode(false);

            entity.HasOne(d => d.SearchWarningType)
                  .WithOne(p => p.SearchWarningHelp)
                  .HasForeignKey<SearchWarningHelp>(d => d.SearchWarningTypeId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_SEARCH_WARNING_HELP_SEARCH_WARNING_TYPE");
        }
    }
}
