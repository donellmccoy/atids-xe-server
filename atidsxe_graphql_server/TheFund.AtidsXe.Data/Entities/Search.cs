using HotChocolate.Types;
using HotChocolate.Types.Relay;
using System;
using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class Search
    {
        public Search()
        {
            ChainOfTitleSearches = new HashSet<ChainOfTitleSearch>();
            InverseParentSearches = new HashSet<Search>();
            SearchNotes = new HashSet<SearchNotes>();
            AcreageGovtLotLegals = new HashSet<AcreageGovtLotLegal>();
            AcreageSectionLegals = new HashSet<AcreageSectionLegal>();
            PolicySearches = new HashSet<PolicySearch>();
            SearchWarnings = new HashSet<SearchWarning>();
            SubdivisionPlattedLegals = new HashSet<SubdivisionPlattedLegal>();
            TitleEventSearches = new HashSet<TitleEventSearch>();
        }

        public int SearchId { get; set; }

        public int FileReferenceId { get; set; }

        [Trim]
        public string SearchReference { get; set; }

        public DateTime DateOfSearch { get; set; }

        public DateTime SearchFromDate { get; set; }

        public DateTime SearchThruDate { get; set; }

        public int SearchTypeId { get; set; }

        public int GeographicLocaleId { get; set; }

        public int? GeographicCertRangeId { get; set; }

        public int? GiCertRangeId { get; set; }

        public int? GrantorCertRangeId { get; set; }

        public int? ParentSearchId { get; set; }

        public int? SearchStatusId { get; set; }

        [Trim]
        public string InstrumentFilters { get; set; }

        public byte? LrsSearch { get; set; }

        public byte? InclMortgageeShortForm { get; set; }

        public byte? Hidden { get; set; }

        public FileReference FileReference { get; set; }

        public CertificationRange GeographicCertRange { get; set; }

        public GeographicLocale GeographicLocale { get; set; }

        public CertificationRange GiCertRange { get; set; }

        public CertificationRange GrantorCertRange { get; set; }

        public Search ParentSearch { get; set; }

        public SearchStatus SearchStatus { get; set; }

        public SearchType SearchType { get; set; }

        public NameSearchParameters NameSearchParameters { get; set; }

        public PolicyTitleStatusReport PolicyTitleStatusReport { get; set; }

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public virtual ICollection<ChainOfTitleSearch> ChainOfTitleSearches { get; set; }

        [UseFiltering]
        [UseSorting]
        public virtual ICollection<Search> InverseParentSearches { get; set; }

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public virtual ICollection<SearchNotes> SearchNotes { get; set; }

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public virtual ICollection<AcreageGovtLotLegal> AcreageGovtLotLegals { get; set; }

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public virtual ICollection<AcreageSectionLegal> AcreageSectionLegals { get; set; }

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public virtual ICollection<PolicySearch> PolicySearches { get; set; }

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public virtual ICollection<SearchWarning> SearchWarnings { get; set; }

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public virtual ICollection<SubdivisionPlattedLegal> SubdivisionPlattedLegals { get; set; }

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public virtual ICollection<TitleEventSearch> TitleEventSearches { get; set; }
    }
}