using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class FileReferenceNotesConfiguration : IEntityTypeConfiguration<FileReferenceNotes>
    {
        public void Configure(EntityTypeBuilder<FileReferenceNotes> builder)
        {
            builder.ToTable("FILE_REFERENCE_NOTES");

            builder.HasIndex(e => e.FileReferenceId)
                    .HasName("I_FK_FILE_REFERENCE");

            builder.Property(e => e.Message).IsUnicode(false);

            builder.Property(e => e.UserId).IsUnicode(false);

            //builder.HasOne(d => d.FileReference)
            //    .WithMany(p => p.FileReferenceNotes)
            //    .HasForeignKey(d => d.FileReferenceId)
            //    .HasConstraintName("FK_FILE_REFERENCE_NOTES");
        }
    }
}
