using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class NameSearchParametersConfiguration : IEntityTypeConfiguration<NameSearchParameters>
    {
        public void Configure(EntityTypeBuilder<NameSearchParameters> builder)
        {
            builder.ToTable("NAME_SEARCH_PARAMETERS");

            builder.HasKey(p => p.SearchId);

            builder.HasIndex(e => e.LegalEntityNameId)
                   .HasDatabaseName("I_FK_LEGAL_ENTITY");

            builder.HasIndex(e => e.OwnerBuyerRelationshipId)
                   .HasDatabaseName("I_FK_NAME_SEARCH_PARAMETERS_OWNER_BUYER_RELATIONSHIP_ID");

            builder.Property(e => e.SearchId)
                   .HasColumnName("SEARCH_ID")
                   .ValueGeneratedNever();

            builder.Property(e => e.LegalEntityNameId)
                   .HasColumnName("LEGAL_ENTITY_NAME_ID");

            builder.Property(e => e.SearchGiNames)
                   .HasColumnName("SEARCH_GI_NAMES");

            builder.Property(e => e.SearchGrantorNames)
                   .HasColumnName("SEARCH_GRANTOR_NAMES");

            builder.Property(e => e.SearchGranteeNames)
                   .HasColumnName("SEARCH_GRANTEE_NAMES");

            builder.Property(e => e.SearchNickNames)
                   .HasColumnName("SEARCH_NICK_NAMES");

            builder.Property(e => e.SearchSimilarSoundingNames)
                   .HasColumnName("SEARCH_SIMILAR_SOUNDING_NAMES");

            builder.Property(e => e.FlipNames)
                   .HasColumnName("FLIP_NAMES");

            builder.Property(e => e.LastNamePctOfLikeness)
                   .HasColumnName("LAST_NAME_PCT_OF_LIKENESS");

            builder.Property(e => e.FirstNamePctOfLikeness)
                   .HasColumnName("FIRST_NAME_PCT_OF_LIKENESS");

            builder.Property(e => e.OwnerBuyerRelationshipId)
                   .HasColumnName("OWNER_BUYER_RELATIONSHIP_ID");

            builder.Property(e => e.LegalFilter)
                   .HasColumnName("LEGAL_FILTER")
                   .HasMaxLength(10)
                   .IsUnicode(false);

            builder.HasOne(d => d.LegalEntityName)
                   .WithMany(p => p.NameSearchParameters)
                   .HasForeignKey(d => d.LegalEntityNameId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_LEGAL_ENT_NAME_NAME_SRCH");

            builder.HasOne(d => d.OwnerBuyerRelationship)
                   .WithMany(p => p.NameSearchParameters)
                   .HasForeignKey(d => d.OwnerBuyerRelationshipId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_OWNER_BUYER");

            builder.HasOne(d => d.Search)
                   .WithOne(p => p.NameSearchParameters)
                   .HasForeignKey<NameSearchParameters>(d => d.SearchId)
                   .HasConstraintName("FK_SEARCH_NAME_SRCH_PARMS");
        }
    }
}
