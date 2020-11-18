using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class ChainOfTitleConfiguration : IEntityTypeConfiguration<ChainOfTitle>
    {
        public void Configure(EntityTypeBuilder<ChainOfTitle> builder)
        {
            builder.ToTable("CHAIN_OF_TITLE");

            builder.HasKey(p => p.ChainOfTitleId);

            builder.HasIndex(e => e.FileReferenceId)
                   .HasName("I_FK_CHAIN_OF_TITLE_FILE_REFERENCE_ID");

            builder.Property(p => p.ChainOfTitleId)
                   .HasColumnName("CHAIN_OF_TITLE_ID");

            builder.Property(p => p.FileReferenceId)
                   .HasColumnName("FILE_REFERENCE_ID");

            builder.HasOne(d => d.FileReference)
                   .WithMany(p => p.ChainOfTitles)
                   .HasForeignKey(d => d.FileReferenceId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_CHAIN_OF_TITLE_FILE_REFERENCE");
        }
    }
}
