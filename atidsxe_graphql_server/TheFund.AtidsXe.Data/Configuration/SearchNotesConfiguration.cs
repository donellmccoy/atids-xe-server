using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class SearchNotesConfiguration : IEntityTypeConfiguration<SearchNotes>
    {
        public void Configure(EntityTypeBuilder<SearchNotes> builder)
        {
            builder.ToTable("SEARCH_NOTES");

            builder.HasKey(p => p.SearchNotesId);

            builder.HasIndex(e => e.SearchId)
                   .HasDatabaseName("I_FK_SEARCH");

            builder.Property(p => p.SearchNotesId)
                   .HasColumnName("SEARCH_NOTES_ID");

            builder.Property(p => p.SearchId)
                   .HasColumnName("SEARCH_ID");

            builder.Property(e => e.Message)
                   .HasColumnName("MESSAGE")
                   .HasMaxLength(1024)
                   .IsUnicode(false)
                   .IsRequired();

            builder.Property(e => e.UserId)
                   .HasColumnName("USER_ID")
                   .HasMaxLength(30)
                   .IsUnicode(false)
                   .IsRequired();

            builder.Property(e => e.TimeStamp)
                   .HasColumnName("TIME_STAMP");

            builder.HasOne(d => d.Search)
                   .WithMany(p => p.SearchNotes)
                   .HasForeignKey(d => d.SearchId)
                   .HasConstraintName("FK_SEARCH_SEARCH_NOTES");
        }
    }

}
