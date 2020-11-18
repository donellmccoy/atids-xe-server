using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class NameSearchStatusCodeConfiguration : IEntityTypeConfiguration<NameSearchStatusCode>
    {
        public void Configure(EntityTypeBuilder<NameSearchStatusCode> entity)
        {
            entity.ToTable("NAME_SEARCH_STATUS_CODE");

            entity.HasKey(p => p.NameSearchStatusCodeId);

            entity.HasIndex(e => e.Description)
                  .HasName("NAME_SEARCH_STATUS_CODE_DESCRIPTION_UC1")
                  .IsUnique();

            entity.Property(e => e.NameSearchStatusCodeId)
                  .HasColumnName("NAME_SEARCH_STATUS_CODE_ID")
                  .ValueGeneratedNever();

            entity.Property(e => e.Description)
                  .IsRequired()
                  .HasColumnName("DESCRIPTION")
                  .HasMaxLength(50)
                  .IsUnicode(false);
        }
    }
}
