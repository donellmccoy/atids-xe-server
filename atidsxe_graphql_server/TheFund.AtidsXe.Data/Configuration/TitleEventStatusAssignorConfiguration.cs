using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class TitleEventStatusAssignorConfiguration : IEntityTypeConfiguration<TitleEventStatusAssignor>
    {
        public void Configure(EntityTypeBuilder<TitleEventStatusAssignor> builder)
        {
            builder.ToTable("TITLE_EVENT_STATUS_ASSIGNOR");

            builder.HasKey(p => p.TitleEventStatusAssignorId);

            builder.Property(e => e.TitleEventStatusAssignorId)
                   .HasColumnName("TITLE_EVENT_STATUS_ASSIGNOR_ID")
                   .ValueGeneratedNever();

            builder.Property(e => e.Description)
                   .HasColumnName("DESCRIPTION")
                   .HasMaxLength(32)
                   .IsUnicode(false)
                   .IsRequired();

            builder.HasMany(p => p.TitleEvents)
                   .WithOne(p => p.TitleEventStatusAssignor)
                   .HasForeignKey(p => p.TitleEventStatusAssignorId);
        }
    }
}
