using HotChocolate.Types;
using HotChocolate.Types.Relay;
using System;
using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class Policy
    {
        public Policy()
        {
            PolicyGovtLotLegalMqls = new HashSet<PolicyGovtLotLegalMql>();
            PolicyInsuredDocuments = new HashSet<PolicyInsuredDocument>();
            PolicyNotes = new HashSet<PolicyNotes>();
            PolicyOrderTrackings = new HashSet<PolicyOrderTracking>();
            PolicyPlattedLegalMqls = new HashSet<PolicyPlattedLegalMql>();
            PolicySearches = new HashSet<PolicySearch>();
            PolicySectionLegalMqls = new HashSet<PolicySectionLegalMql>();
            PolicyWorksheetItems = new HashSet<PolicyWorksheetItem>();
        }

        public int PolicyId { get; set; }

        [Trim]
        public string PolicyType { get; set; }

        public int PolicyNumber { get; set; }

        public int PolicyRestrictionTypeId { get; set; }

        public DateTime EffectiveDate { get; set; }

        [Trim]
        public string MemberNumber { get; set; }

        public decimal? InsuredAmount { get; set; }

        public byte? ImageAvailable { get; set; }

        public byte? TitleBaseIndicator { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? SystemUpdateDate { get; set; }

        public DateTime? UserUpdateDate { get; set; }

        public virtual PolicyRestrictionType PolicyRestrictionType { get; set; }

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public virtual ICollection<PolicyGovtLotLegalMql> PolicyGovtLotLegalMqls { get; set; }

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public virtual ICollection<PolicyInsuredDocument> PolicyInsuredDocuments { get; set; }

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public virtual ICollection<PolicyNotes> PolicyNotes { get; set; }

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public virtual ICollection<PolicyOrderTracking> PolicyOrderTrackings { get; set; }

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public virtual ICollection<PolicyPlattedLegalMql> PolicyPlattedLegalMqls { get; set; }

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public virtual ICollection<PolicySearch> PolicySearches { get; set; }

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public virtual ICollection<PolicySectionLegalMql> PolicySectionLegalMqls { get; set; }

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public virtual ICollection<PolicyWorksheetItem> PolicyWorksheetItems { get; set; }
    }
}