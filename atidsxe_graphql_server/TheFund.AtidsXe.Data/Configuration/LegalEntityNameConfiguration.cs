using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class LegalEntityNameConfiguration : IEntityTypeConfiguration<LegalEntityName>
    {
        public void Configure(EntityTypeBuilder<LegalEntityName> entity)
        {
            entity.ToTable("LEGAL_ENTITY_NAME");

            entity.HasKey(p => p.LegalEntityNameId);

            entity.HasIndex(e => e.LegalEntityNameTypeId)
                  .HasName("I_FK_LEGAL_ENTITY_NAME_TYPE");

            entity.Property(e => e.LegalEntityNameId)
                  .HasColumnName("LEGAL_ENTITY_NAME_ID");

            entity.Property(e => e.Comments)
                  .HasColumnName("COMMENTS")
                  .HasMaxLength(256)
                  .IsUnicode(false);

            entity.Property(e => e.LegalEntityNameTypeId)
                  .HasColumnName("LEGAL_ENTITY_NAME_TYPE_ID");

            entity.Property(e => e.UnparsedLegalEntityName)
                  .IsRequired()
                  .HasColumnName("UNPARSED_LEGAL_ENTITY_NAME")
                  .HasMaxLength(256)
                  .IsUnicode(false);

            entity.HasOne(d => d.LegalEntityNameType)
                  .WithMany(p => p.LegalEntityNames)
                  .HasForeignKey(d => d.LegalEntityNameTypeId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_LGLENT_NMTYP_LGLENT_NAME");

            entity.HasOne(d => d.PersonalLegalEntityName)
                  .WithOne(p => p.LegalEntityName)
                  .HasForeignKey<LegalEntityName>(d => d.LegalEntityNameId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_LGLENT_NMTYP_LGLENT_NAME");

            entity.HasMany(p => p.NameSearchListItems)
                  .WithOne(p => p.LegalEntityName)
                  .HasForeignKey(p => p.LegalEntityNameId);

            entity.HasMany(p => p.NameSearchParameters)
                  .WithOne(p => p.LegalEntityName)
                  .HasForeignKey(p => p.LegalEntityNameId);

            entity.HasMany(p => p.PartyLegalEntityNames)
                  .WithOne(p => p.LegalEntityName)
                  .HasForeignKey(p => p.LegalEntityNameId);

            entity.HasMany(p => p.TitleEventLegalEntityMqls)
                  .WithOne(p => p.LegalEntityName)
                  .HasForeignKey(p => p.LegalEntityNameId);
        }
    }
}
