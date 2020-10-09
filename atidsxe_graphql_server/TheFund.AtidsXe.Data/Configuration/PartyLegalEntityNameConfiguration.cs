using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class PartyLegalEntityNameConfiguration : IEntityTypeConfiguration<PartyLegalEntityName>
    {
        public void Configure(EntityTypeBuilder<PartyLegalEntityName> builder)
        {
            builder.ToTable("PARTY_LEGAL_ENTITY_NAME");

            builder.HasKey(e => new { e.PartyId, e.LegalEntityNameId });

            builder.HasIndex(e => e.LegalEntityNameId)
                   .HasName("I_FK_PARTY_LEGAL_ENTITY_NAME_LEGAL_ENTITY_NAME_ID");

            builder.Property(e => e.PartyId)
                   .HasColumnName("PARTY_ID");

            builder.Property(e => e.LegalEntityNameId)
                   .HasColumnName("LEGAL_ENTITY_NAME_ID");

            builder.HasOne(d => d.LegalEntityName)
                   .WithMany(p => p.PartyLegalEntityName)
                   .HasForeignKey(d => d.LegalEntityNameId)
                   .HasConstraintName("FK_LGL_ENTNM_PARTY_LGL_ENTNM");

            builder.HasOne(d => d.Party)
                   .WithMany(p => p.PartyLegalEntityName)
                   .HasForeignKey(d => d.PartyId)
                   .HasConstraintName("FK_PARTY_PARTY_LGL_ENT_NAME");
        }
    }

}
