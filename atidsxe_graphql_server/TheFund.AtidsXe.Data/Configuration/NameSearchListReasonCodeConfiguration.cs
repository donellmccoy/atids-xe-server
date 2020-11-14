using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class NameSearchListReasonCodeConfiguration : IEntityTypeConfiguration<NameSearchListReasonCode>
    {
        public void Configure(EntityTypeBuilder<NameSearchListReasonCode> builder)
        {
            builder.ToTable("NAME_SEARCH_LIST_REASON_CODE");

            builder.HasKey(e => new { e.NameSearchListItemId, e.NameReasonCodeId });

            builder.HasIndex(e => e.NameReasonCodeId)
                   .HasName("I_FK_NAME_SEARCH_LIST_REASON_CODE_NAME_REASON_CODE_ID");

            builder.Property(e => e.NameSearchListItemId)
                   .HasColumnName("NAME_SEARCH_LIST_ITEM_ID");

            builder.Property(e => e.NameReasonCodeId)
                   .HasColumnName("NAME_REASON_CODE_ID");

            builder.HasOne(d => d.NameReasonCode)
                   .WithMany(p => p.NameSearchListReasonCodes)
                   .HasForeignKey(d => d.NameReasonCodeId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_NAME_SEARCH_LIST_REASON_CODE_NAME_REASON_CODE");

            builder.HasOne(d => d.NameSearchListItem)
                   .WithMany(p => p.NameSearchListReasonCodes)
                   .HasForeignKey(d => d.NameSearchListItemId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_NAME_SEARCH_LIST_REASON_CODE_NAME_SEARCH_LIST_ITEM ");
        }
    }
}
