using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class PartyConfiguration : IEntityTypeConfiguration<Party>
    {
        public void Configure(EntityTypeBuilder<Party> entity)
        {
            entity.ToTable("PARTY");

            entity.HasKey(e => e.PartyId);

            entity.HasIndex(e => e.PartyRoleTypeId)
                  .HasName("I_FK_PARTY_ROLE_TYPE");

            entity.Property(e => e.PartyId)
                  .HasColumnName("PARTY_ID");

            entity.Property(e => e.PartyRoleTypeId)
                  .HasColumnName("PARTY_ROLE_TYPE_ID");

            entity.Property(e => e.UnparsedParty)
                  .IsRequired()
                  .HasColumnName("UNPARSED_PARTY")
                  .HasMaxLength(256)
                  .IsUnicode(false);

            entity.HasOne(d => d.PartyRoleType)
                  .WithMany(p => p.Party)
                  .HasForeignKey(d => d.PartyRoleTypeId)
                  .HasConstraintName("FK_PARTY_ROLETYPE_PARTY");
        }
    }
}
