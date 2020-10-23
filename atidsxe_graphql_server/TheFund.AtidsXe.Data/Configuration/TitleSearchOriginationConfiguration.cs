using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class TitleSearchOriginationConfiguration : IEntityTypeConfiguration<TitleSearchOrigination>
    {
        public void Configure(EntityTypeBuilder<TitleSearchOrigination> builder)
        {
            builder.ToTable("TITLE_SEARCH_ORIGINATION");

            builder.HasIndex(e => e.FileReferenceId)
                   .HasName("UX_TITLE_SEARCH_ORIGINATION")
                   .IsUnique();

            builder.HasIndex(e => e.TitleEventId)
                   .HasName("FK_TITLE_SEARCH_ORIGINATION_TITLE_EVENT_ID");

            builder.Property(p => p.TitleSearchOriginationId)
                   .HasColumnName("TITLE_SEARCH_ORIGINATION_ID");

            builder.Property(p => p.OrderDate)
                   .HasColumnName("ORDER_DATE");

            builder.Property(p => p.OrderReference)
                   .HasColumnName("ORDER_REFERENCE")
                   .HasMaxLength(50)
                   .IsUnicode(false);

            builder.Property(p => p.TitleEventId)
                   .HasColumnName("TITLE_EVENT_ID");

            builder.Property(p => p.FileReferenceId)
                   .HasColumnName("FILE_REFERENCE_ID");

            builder.HasOne(d => d.FileReference)
                   .WithOne(p => p.TitleSearchOrigination)
                   .HasForeignKey<TitleSearchOrigination>(d => d.FileReferenceId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_TITLE_SEARCH_ORIGINATION_FILE_REFERENCE");

            builder.HasOne(d => d.TitleEvent)
                   .WithMany(p => p.TitleSearchOriginations)
                   .HasForeignKey(d => d.TitleEventId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_TITLE_SEARCH_ORIGINATION_TITLE_EVENT");
        }
    }
}
