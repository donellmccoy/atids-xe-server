using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public class PolicyTitleStatusReportConfiguration : IEntityTypeConfiguration<PolicyTitleStatusReport>
    {
        public void Configure(EntityTypeBuilder<PolicyTitleStatusReport> entity)
        {
            entity.ToTable("POLICY_TITLE_STATUS_REPORT");

            entity.HasKey(e => e.SearchId);

            entity.Property(e => e.SearchId)
                  .HasColumnName("SEARCH_ID")
                  .ValueGeneratedNever();

            entity.Property(e => e.TitleStatusReportCode)
                  .IsRequired()
                  .HasColumnName("TITLE_STATUS_REPORT_CODE")
                  .HasMaxLength(4)
                  .IsUnicode(false);

            entity.Property(e => e.TitleStatusReportNumber)
                  .HasColumnName("TITLE_STATUS_REPORT_NUMBER")
                  .HasMaxLength(20)
                  .IsUnicode(false);

            entity.HasOne(d => d.Search)
                  .WithOne(p => p.PolicyTitleStatusReport)
                  .HasForeignKey<PolicyTitleStatusReport>(d => d.SearchId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_SEARCH_POLICY_TSR");
        }
    }
}
