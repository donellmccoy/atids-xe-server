using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class NameReasonCodeConfiguration : IEntityTypeConfiguration<NameReasonCode>
    {
        public void Configure(EntityTypeBuilder<NameReasonCode> entity)
        {
            entity.ToTable("NAME_REASON_CODE");

            entity.HasKey(p => p.NameReasonCodeId);

            entity.HasIndex(e => e.NameReasonCodeId)
                  .HasName("NAME_REASON_CODE_DESCRIPTION_UC1")
                  .IsUnique();

            entity.Property(e => e.NameReasonCodeId)
                  .HasColumnName("NAME_REASON_CODE_ID")
                  .ValueGeneratedNever();

            entity.Property(e => e.Description)
                  .IsRequired()
                  .HasColumnName("DESCRIPTION")
                  .HasMaxLength(50)
                  .IsUnicode(false);
        }
    }
}
