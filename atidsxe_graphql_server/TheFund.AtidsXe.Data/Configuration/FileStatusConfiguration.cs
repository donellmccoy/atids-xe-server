using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class FileStatusConfiguration : IEntityTypeConfiguration<FileStatus>
    {
        public void Configure(EntityTypeBuilder<FileStatus> builder)
        {
            builder.HasIndex(e => e.Description).HasName("FILE_STATUS_UC1").IsUnique();

            builder.Property(e => e.FileStatusId).ValueGeneratedNever();

            builder.Property(e => e.Description).IsUnicode(false);
        }
    }
}
