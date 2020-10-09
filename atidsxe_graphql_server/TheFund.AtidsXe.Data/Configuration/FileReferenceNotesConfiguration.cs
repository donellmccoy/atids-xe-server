using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class FileReferenceNotesConfiguration : IEntityTypeConfiguration<FileReferenceNote>
    {
        public void Configure(EntityTypeBuilder<FileReferenceNote> builder)
        {
            builder.ToTable("FILE_REFERENCE_NOTES");

            builder.HasIndex(e => e.FileReferenceId)
                   .HasName("I_FK_FILE_REFERENCE");

            builder.Property(p => p.FileReferenceNotesId)
                   .HasColumnName("FILE_REFERENCE_NOTES_ID");

            builder.Property(p => p.FileReferenceId)
                   .HasColumnName("FILE_REFERENCE_ID");

            builder.Property(e => e.UserId)
                   .HasColumnName("USER_ID")
                   .HasMaxLength(30)
                   .IsUnicode(false)
                   .IsRequired();

            builder.Property(e => e.TimeStamp)
                   .HasColumnName("TIME_STAMP");

            builder.Property(e => e.Message)
                   .HasColumnName("MESSAGE")
                   .HasMaxLength(1024)
                   .IsUnicode(false)
                   .IsRequired();

            builder.HasOne(d => d.FileReference)
                   .WithMany(p => p.FileReferenceNotes)
                   .HasForeignKey(d => d.FileReferenceId)
                   .HasConstraintName("FK_FILE_REFERENCE_NOTES");
        }
    }
}
