using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class MortgageTitleEventConfiguration : IEntityTypeConfiguration<MortgageTitleEvent>
    {
        public void Configure(EntityTypeBuilder<MortgageTitleEvent> entity)
        {
            entity.ToTable("MORTGAGE_TITLE_EVENT");

            entity.HasKey(e => e.TitleEventId);

            entity.HasIndex(e => e.MinNumberId)
                  .HasName("I_FK_MIN_NUMBER");

            entity.Property(e => e.TitleEventId)
                  .HasColumnName("TITLE_EVENT_ID")
                  .ValueGeneratedNever();

            entity.Property(e => e.LenderName)
                  .IsRequired()
                  .HasColumnName("LENDER_NAME")
                  .HasMaxLength(200)
                  .IsUnicode(false);

            entity.Property(e => e.MinNumberId)
                  .HasColumnName("MIN_NUMBER_ID");

            entity.HasOne(d => d.MinNumber)
                  .WithMany(p => p.MortgageTitleEvent)
                  .HasForeignKey(d => d.MinNumberId)
                  .HasConstraintName("FK_MIN_NBR_MTG_TITLE_EVENT");

            entity.HasOne(d => d.TitleEvent)
                  .WithOne(p => p.MortgageTitleEvent)
                  .HasForeignKey<MortgageTitleEvent>(d => d.TitleEventId)
                  .HasConstraintName("FK_TITLE_EVENT_MTG_TITLE_EVENT");
        }
    }
}
