using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class PersonalLegalEntityNameConfiguration : IEntityTypeConfiguration<PersonalLegalEntityName>
    {
        public void Configure(EntityTypeBuilder<PersonalLegalEntityName> builder)
        {
            builder.ToTable("PERSONAL_LEGAL_ENTITY_NAME");

            builder.HasKey(p => p.LegalEntityNameId);

            builder.Property(e => e.LegalEntityNameId)
                   .HasColumnName("LEGAL_ENTITY_NAME_ID")
                   .ValueGeneratedNever();

            builder.Property(e => e.FirstName)
                   .HasColumnName("FIRST_NAME")
                   .HasMaxLength(50)
                   .IsUnicode(false)
                   .IsRequired();

            builder.Property(e => e.LastName)
                   .HasColumnName("LAST_NAME")
                   .HasMaxLength(50)
                   .IsUnicode(false)
                   .IsRequired();

            builder.Property(e => e.Lineage)
                   .HasColumnName("LINEAGE")
                   .HasMaxLength(10)
                   .IsUnicode(false);

            builder.Property(e => e.MiddleName)
                   .HasColumnName("MIDDLE_NAME")
                   .HasMaxLength(50)
                   .IsUnicode(false);

            builder.Property(e => e.Prefix)
                   .HasColumnName("PREFIX")
                   .HasMaxLength(10)
                   .IsUnicode(false);

            builder.Property(e => e.Suffix)
                   .HasColumnName("SUFFIX")
                   .HasMaxLength(10)
                   .IsUnicode(false);

            builder.HasOne(d => d.LegalEntityName)
                   .WithOne(p => p.PersonalLegalEntityName)
                   .HasForeignKey<PersonalLegalEntityName>(d => d.LegalEntityNameId)
                   .HasConstraintName("FK_LGL_ENTNM_PERS_LGL_ENTNM");
        }
    }

}
