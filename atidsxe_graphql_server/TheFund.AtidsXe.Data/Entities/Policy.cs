using System;
using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class Policy
    {
        public Policy()
        {
            PolicyGovtLotLegalMql = new HashSet<PolicyGovtLotLegalMql>();
            PolicyInsuredDocument = new HashSet<PolicyInsuredDocument>();
            PolicyNotes = new HashSet<PolicyNotes>();
            PolicyOrderTracking = new HashSet<PolicyOrderTracking>();
            PolicyPlattedLegalMql = new HashSet<PolicyPlattedLegalMql>();
            PolicySearch = new HashSet<PolicySearch>();
            PolicySectionLegalMql = new HashSet<PolicySectionLegalMql>();
            PolicyWorksheetItem = new HashSet<PolicyWorksheetItem>();
        }

        public int PolicyId { get; set; }
        public string PolicyType { get; set; }
        public int PolicyNumber { get; set; }
        public int PolicyRestrictionTypeId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string MemberNumber { get; set; }
        public decimal? InsuredAmount { get; set; }
        public byte? ImageAvailable { get; set; }
        public byte? TitleBaseIndicator { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? SystemUpdateDate { get; set; }
        public DateTime? UserUpdateDate { get; set; }

        public virtual PolicyRestrictionType PolicyRestrictionType { get; set; }
        public virtual ICollection<PolicyGovtLotLegalMql> PolicyGovtLotLegalMql { get; set; }
        public virtual ICollection<PolicyInsuredDocument> PolicyInsuredDocument { get; set; }
        public virtual ICollection<PolicyNotes> PolicyNotes { get; set; }
        public virtual ICollection<PolicyOrderTracking> PolicyOrderTracking { get; set; }
        public virtual ICollection<PolicyPlattedLegalMql> PolicyPlattedLegalMql { get; set; }
        public virtual ICollection<PolicySearch> PolicySearch { get; set; }
        public virtual ICollection<PolicySectionLegalMql> PolicySectionLegalMql { get; set; }
        public virtual ICollection<PolicyWorksheetItem> PolicyWorksheetItem { get; set; }
    }
}