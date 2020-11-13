using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class RelatedOrDocumentConfiguration : IEntityTypeConfiguration<RelatedOrDocument>
    {
        public void Configure(EntityTypeBuilder<RelatedOrDocument> entity)
        {
            entity.ToTable("RELATED_OR_DOCUMENT");

            entity.HasKey(e => new { e.SearchedOrDocumentId, e.RelatedOrDocumentId });

            entity.HasIndex(e => e.RelatedOrDocumentId)
                  .HasName("I_FK_RELATED_OR_DOCUMENT_RELATED_OR_DOCUMENT_ID");

            entity.Property(e => e.SearchedOrDocumentId)
                  .HasColumnName("SEARCHED_OR_DOCUMENT_ID");

            entity.Property(e => e.RelatedOrDocumentId)
                  .HasColumnName("RELATED_OR_DOCUMENT_ID");

            entity.HasOne(d => d.RelatedOrDocumentNavigation)
                  .WithMany(p => p.RelatedOrDocumentRelatedOrDocumentNavigation)
                  .HasForeignKey(d => d.RelatedOrDocumentId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_ORD_ID_RELATED_ORD_ID");

            entity.HasOne(d => d.SearchedOrDocument)
                  .WithMany(p => p.RelatedOrDocumentSearchedOrDocument)
                  .HasForeignKey(d => d.SearchedOrDocumentId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_ORD_RELATED_ORD_SEARCHED");
        }
    }
}
