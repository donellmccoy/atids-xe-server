using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class ExaminationStatusTypeConfiguration : IEntityTypeConfiguration<ExaminationStatusType>
    {
        public void Configure(EntityTypeBuilder<ExaminationStatusType> builder)
        {
            builder.ToTable("EXAMINATION_STATUS_TYPE");

            builder.HasIndex(e => e.Description)
                   .HasName("EXAMINATION_STATUS_TYPE_UC1")
                   .IsUnique();

            builder.Property(e => e.ExaminationStatusTypeId)
                   .HasColumnName("EXAMINATION_STATUS_TYPE_ID")
                   .ValueGeneratedNever();

            builder.Property(e => e.Description)
                   .HasColumnName("DESCRIPTION")
                   .HasMaxLength(50)
                   .IsUnicode(false);

            builder.HasMany(p => p.TitleEventCurrentExamStatusTypes)
                   .WithOne(p => p.CurrentExamStatusType)
                   .HasForeignKey(p => p.CurrentExamStatusTypeId);

            builder.HasMany(p => p.TitleEventOriginalExamStatusTypes)
                   .WithOne(p => p.OriginalExamStatusType)
                   .HasForeignKey(p => p.OriginalExamStatusTypeId);
        }
    }
}
