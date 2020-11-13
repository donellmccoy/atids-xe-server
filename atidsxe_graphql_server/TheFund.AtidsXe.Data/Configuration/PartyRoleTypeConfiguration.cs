using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class PartyRoleTypeConfiguration : IEntityTypeConfiguration<PartyRoleType>
    {
        public void Configure(EntityTypeBuilder<PartyRoleType> entity)
        {
            entity.ToTable("PARTY_ROLE_TYPE");

            entity.HasKey(e => e.PartyRoleTypeId);

            entity.HasIndex(e => e.Description)
                  .HasName("IX_PARTY_DESC");

            entity.Property(e => e.PartyRoleTypeId)
                  .HasColumnName("PARTY_ROLE_TYPE_ID")
                  .ValueGeneratedNever();

            entity.Property(e => e.Description)
                  .IsRequired()
                  .HasColumnName("DESCRIPTION")
                  .HasMaxLength(50)
                  .IsUnicode(false);
        }
    }
}
