using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class FileReferenceConfiguration : IEntityTypeConfiguration<FileReference>
    {
        public void Configure(EntityTypeBuilder<FileReference> builder)
        {
            builder.ToTable("FILE_REFERENCE");

            builder.HasIndex(e => e.BranchLocationId)
                   .HasName("I_FK_BRANCH_LOCATION")
                   .IsCreatedOnline();

            builder.HasIndex(e => e.DefaultGeographicLocaleId)
                   .HasName("I_FK_FILE_REFERENCE_DEFAULT_GEOGRAPHIC_LOCALE_ID")
                   .IsCreatedOnline();

            builder.HasIndex(e => e.FileStatusId)
                   .HasName("I_FK_STATUS")
                   .IsCreatedOnline();

            builder.HasIndex(e => new { e.Name, e.BranchLocationId })
                   .HasName("I_FILE_REFERENCE")
                   .IsUnique()
                   .IsCreatedOnline();

            builder.Property(e => e.FileReferenceId)
                   .HasColumnName("FILE_REFERENCE_ID");

            builder.Property(e => e.BranchLocationId)
                   .HasColumnName("BRANCH_LOCATION_ID");

            builder.Property(e => e.Name)
                   .HasColumnName("FILE_REFERENCE")
                   .IsUnicode(false)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(e => e.FileStatusId)
                   .HasColumnName("FILE_STATUS_ID");

            builder.Property(e => e.WorkerId)
                   .HasColumnName("WORKER_ID")
                   .IsUnicode(false)
                   .HasMaxLength(50);

            builder.Property(e => e.CreateDate)
                   .HasColumnName("CREATE_DATE")
                   .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.UpdateDate)
                   .HasColumnName("UPDATE_DATE")
                   .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.DefaultGeographicLocaleId)
                   .HasColumnName("DEFAULT_GEOGRAPHIC_LOCALE_ID")
                   .IsRequired(false);

            builder.Property(e => e.IsTemporaryFile)
                   .HasColumnName("IS_TEMPORARY_FILE")
                   .IsRequired(false);

            builder.HasOne(d => d.BranchLocation)
                   .WithMany(p => p.FileReference)
                   .HasForeignKey(d => d.BranchLocationId)
                   .HasConstraintName("FK_BRANCH_LOC_FILE_REFERENCE");

            builder.HasOne(d => d.DefaultGeographicLocale)
                   .WithMany(p => p.FileReferences)
                   .HasForeignKey(d => d.DefaultGeographicLocaleId)
                   .HasConstraintName("FK_LOCATION_FILE_REFERENCE");

            builder.HasOne(d => d.FileStatus)
                   .WithMany(p => p.FileReferences)
                   .HasForeignKey(d => d.FileStatusId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_FILE_STATUS_FILE_REFERENCE");

            builder.HasOne(d => d.TitleSearchOrigination)
                   .WithOne(p => p.FileReference)
                   .HasForeignKey<TitleSearchOrigination>(d => d.FileReferenceId);

            builder.HasOne(d => d.Worksheet)
                   .WithOne(p => p.FileReference)
                   .HasForeignKey<Worksheet>(d => d.FileReferenceId);
        }
    }
}
