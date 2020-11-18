using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class TitleEventPartyConfiguration : IEntityTypeConfiguration<TitleEventParty>
    {
        public void Configure(EntityTypeBuilder<TitleEventParty> entity)
        {
            entity.ToTable("TITLE_EVENT_PARTY");

            entity.HasKey(e => new { e.TitleEventId, e.PartyId });

            entity.HasIndex(e => e.PartyId)
                  .HasDatabaseName("I_FK_TITLE_EVENT_PARTY_PARTY_ID");

            entity.Property(e => e.TitleEventId)
                  .HasColumnName("TITLE_EVENT_ID");

            entity.Property(e => e.PartyId)
                  .HasColumnName("PARTY_ID");

            entity.HasOne(d => d.Party)
                  .WithMany(p => p.TitleEventParties)
                  .HasForeignKey(d => d.PartyId)
                  .HasConstraintName("FK_PARTY_TITLE_EVENT_PARTY");

            entity.HasOne(d => d.TitleEvent)
                  .WithMany(p => p.TitleEventParties)
                  .HasForeignKey(d => d.TitleEventId)
                  .HasConstraintName("FK_TITLE_EVENT_PARTY");
        }
    }
}
