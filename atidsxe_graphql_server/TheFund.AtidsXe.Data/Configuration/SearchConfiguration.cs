using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Configuration
{
    public sealed class SearchConfiguration : IEntityTypeConfiguration<Search>
    {
        public void Configure(EntityTypeBuilder<Search> builder)
        {
            builder.ToTable("SEARCH");

            builder.HasIndex(e => e.FileReferenceId)
                   .HasDatabaseName("I_FILE_REFERENCE_ID");

            builder.HasIndex(e => e.GeographicLocaleId)
                   .HasDatabaseName("I_FK_GEO_LOCALE");

            builder.HasIndex(e => e.GiCertRangeId)
                   .HasDatabaseName("I_FK_SEARCH_GI_CERT_RANGE_ID");

            builder.HasIndex(e => e.GrantorCertRangeId)
                   .HasDatabaseName("I_FK_GRANTOR_CERT_RANGE");

            builder.HasIndex(e => e.ParentSearchId)
                   .HasDatabaseName("IX_SEARCH_PARENTID");

            builder.HasIndex(e => e.SearchStatusId)
                   .HasDatabaseName("I_FK_SEARCH_STATUS_ID");

            builder.HasIndex(e => e.SearchTypeId)
                   .HasDatabaseName("I_FK_SEARCH_TYPE");

            builder.HasIndex(e => new { e.GeographicCertRangeId, e.GiCertRangeId })
                   .HasDatabaseName("I_FK_GI_CERT_RANGE_ID");

            builder.Property(e => e.SearchId)
                   .HasColumnName("SEARCH_ID");

            builder.Property(e => e.FileReferenceId)
                   .HasColumnName("FILE_REFERENCE_ID");

            builder.Property(e => e.SearchReference)
                   .HasMaxLength(256)
                   .HasColumnName("SEARCH_REFERENCE")
                   .IsRequired();

            builder.Property(e => e.DateOfSearch)
                   .HasColumnName("DATE_OF_SEARCH");

            builder.Property(e => e.SearchFromDate)
                   .HasColumnName("SEARCH_FROM_DATE");

            builder.Property(e => e.SearchThruDate)
                   .HasColumnName("SEARCH_THRU_DATE");

            builder.Property(e => e.SearchTypeId)
                   .HasColumnName("SEARCH_TYPE_ID");

            builder.Property(e => e.GeographicLocaleId)
                   .HasColumnName("GEOGRAPHIC_LOCALE_ID");

            builder.Property(e => e.GeographicCertRangeId)
                   .HasColumnName("GEOGRAPHIC_CERT_RANGE_ID");

            builder.Property(e => e.GiCertRangeId)
                   .HasColumnName("GI_CERT_RANGE_ID");

            builder.Property(e => e.GrantorCertRangeId)
                   .HasColumnName("GRANTOR_CERT_RANGE_ID");

            builder.Property(e => e.ParentSearchId)
                   .HasColumnName("PARENT_SEARCH_ID");

            builder.Property(e => e.SearchStatusId)
                   .HasDefaultValueSql("((0))")
                   .HasColumnName("SEARCH_STATUS_ID");

            builder.Property(e => e.InstrumentFilters)
                   .HasColumnName("INSTRUMENT_FILTERS")
                   .HasMaxLength(150)
                   .IsUnicode(false);

            builder.Property(e => e.LrsSearch)
                   .HasColumnName("LRS_SEARCH");

            builder.Property(e => e.InclMortgageeShortForm)
                   .HasColumnName("INCL_MORTGAGEE_SHORT_FORM");

            builder.Property(e => e.Hidden)
                   .HasColumnName("HIDDEN");

            builder.HasOne(d => d.FileReference)
                   .WithMany(p => p.Searches)
                   .HasForeignKey(d => d.FileReferenceId)
                   .HasConstraintName("FK_FILE_REFERENCE_SEARCH");

            builder.HasOne(d => d.GeographicCertRange)
                   .WithMany(p => p.SearchGeographicCertRanges)
                   .HasForeignKey(d => d.GeographicCertRangeId)
                   .HasConstraintName("FK_SEARCH_CERTIFICATION_RANGE");

            builder.HasOne(d => d.GeographicLocale)
                   .WithMany(p => p.Searches)
                   .HasForeignKey(d => d.GeographicLocaleId)
                   .HasConstraintName("FK_LOCATION_SEARCH");

            builder.HasOne(d => d.GiCertRange)
                   .WithMany(p => p.SearchGiCertRanges)
                   .HasForeignKey(d => d.GiCertRangeId)
                   .HasConstraintName("FK_SEARCH_CERTIFICATION_RANGE1");

            builder.HasOne(d => d.GrantorCertRange)
                   .WithMany(p => p.SearchGrantorCertRanges)
                   .HasForeignKey(d => d.GrantorCertRangeId)
                   .HasConstraintName("FK_GRANTOR_CERT_RANGE_SEARCH");

            builder.HasOne(d => d.ParentSearch)
                   .WithMany(p => p.InverseParentSearches)
                   .HasForeignKey(d => d.ParentSearchId)
                   .HasConstraintName("FK_SEARCH_ID_PARENT_SEARCH_ID");

            builder.HasOne(d => d.SearchStatus)
                   .WithMany(p => p.Searches)
                   .HasForeignKey(d => d.SearchStatusId)
                   .HasConstraintName("FK_SEARCH_SEARCH_STATUS");

            builder.HasOne(d => d.SearchType)
                   .WithMany(p => p.Searches)
                   .HasForeignKey(d => d.SearchTypeId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_SEARCH_TYPE_SEARCH");

            builder.HasMany(p => p.ChainOfTitleSearches)
                   .WithOne(p => p.Search)
                   .HasForeignKey(p => p.SearchId);

            builder.HasMany(p => p.InverseParentSearches)
                   .WithOne(p => p.ParentSearch)
                   .HasForeignKey(p => p.SearchId);

            builder.HasMany(p => p.SearchNotes)
                   .WithOne(p => p.Search)
                   .HasForeignKey(p => p.SearchId);

            builder.HasMany(p => p.AcreageGovtLotLegals)
                   .WithOne(p => p.Search)
                   .HasForeignKey(p => p.SearchId);

            builder.HasMany(p => p.AcreageSectionLegals)
                   .WithOne(p => p.Search)
                   .HasForeignKey(p => p.SearchId);

            builder.HasMany(p => p.PolicySearches)
                   .WithOne(p => p.Search)
                   .HasForeignKey(p => p.SearchId);

            builder.HasMany(p => p.SearchWarnings)
                   .WithOne(p => p.Search)
                   .HasForeignKey(p => p.SearchId);

            builder.HasMany(p => p.SubdivisionPlattedLegals)
                   .WithOne(p => p.Search)
                   .HasForeignKey(p => p.SearchId);

            builder.HasMany(p => p.TitleEventSearches)
                   .WithOne(p => p.Search)
                   .HasForeignKey(p => p.SearchId);
        }
    }
}
