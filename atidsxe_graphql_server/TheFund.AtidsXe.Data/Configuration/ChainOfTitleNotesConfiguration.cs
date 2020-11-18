using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class ChainOfTitleNotesConfiguration : IEntityTypeConfiguration<ChainOfTitleNotes>
    {
        public void Configure(EntityTypeBuilder<ChainOfTitleNotes> builder)
        {
            builder.ToTable("CHAIN_OF_TITLE_NOTES");

            builder.HasKey(e => e.ChainOfTitleNotesId);

            builder.HasIndex(e => e.ChainOfTitleId)
                   .HasDatabaseName("I_FK_CHAIN_OF_TITLE_NOTES_CHAIN_OF_TITLE_ID");

            builder.Property(e => e.ChainOfTitleNotesId)
                   .HasColumnName("CHAIN_OF_TITLE_NOTES_ID");

            builder.Property(e => e.ChainOfTitleId)
                   .HasColumnName("CHAIN_OF_TITLE_ID");

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

            builder.HasOne(d => d.ChainOfTitle)
                   .WithMany(p => p.ChainOfTitleNotes)
                   .HasForeignKey(d => d.ChainOfTitleId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_CHAIN_OF_TITLE_NOTES_CHAIN_OF_TITLE");
        }
    }
}
