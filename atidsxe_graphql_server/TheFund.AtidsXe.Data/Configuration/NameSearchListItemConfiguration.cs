using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class NameSearchListItemConfiguration : IEntityTypeConfiguration<NameSearchListItem>
    {
        public void Configure(EntityTypeBuilder<NameSearchListItem> entity)
        {
            entity.ToTable("NAME_SEARCH_LIST_ITEM");

            entity.HasKey(p => p.NameSearchListItemId);

            entity.HasIndex(e => e.NameSearchStatusCodeId)
                  .HasName("I_FK_NAME_SEARCH_LIST_ITEM_NAME_SEARCH_STATUS_CODE_ID");

            entity.HasIndex(e => e.ReferenceTitleEventId)
                  .HasName("IX_TITLE_EVNTNM_SRCH_LSTITM_REFTITLE");

            entity.HasIndex(e => new { e.LegalEntityNameId, e.ChainOfTitleId, e.ReferenceTitleEventId })
                  .HasName("I_NAME_SEARCH_LIST_ITEM_ID_LOOKUP");

            entity.Property(e => e.NameSearchListItemId)
                  .HasColumnName("NAME_SEARCH_LIST_ITEM_ID");

            entity.Property(e => e.ChainOfTitleId)
                  .HasColumnName("CHAIN_OF_TITLE_ID");

            entity.Property(e => e.LegalEntityNameId)
                  .HasColumnName("LEGAL_ENTITY_NAME_ID");

            entity.Property(e => e.NameSearchStatusCodeId)
                  .HasColumnName("NAME_SEARCH_STATUS_CODE_ID");

            entity.Property(e => e.ReferenceTitleEventId)
                  .HasColumnName("REFERENCE_TITLE_EVENT_ID");

            entity.HasOne(d => d.LegalEntityName)
                  .WithMany(p => p.NameSearchListItems)
                  .HasForeignKey(d => d.LegalEntityNameId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_LEGAL_ENTITY_NAME");

            entity.HasOne(d => d.NameSearchStatusCode)
                  .WithMany(p => p.NameSearchListItems)
                  .HasForeignKey(d => d.NameSearchStatusCodeId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_NAME_SEARCH_STATUS_CODE");

            entity.HasOne(d => d.ReferenceTitleEvent)
                  .WithMany(p => p.NameSearchListItems)
                  .HasForeignKey(d => d.ReferenceTitleEventId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_NAME_SEARCH_LIST_ITEM_TITLE_EVENT");
        }
    }
}
