using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class SectionLegal
    {
        public SectionLegal()
        {
            AcreageSectionLegal = new HashSet<AcreageSectionLegal>();
            PolicySectionLegalMql = new HashSet<PolicySectionLegalMql>();
            TitleEventSectionLegalMql = new HashSet<TitleEventSectionLegalMql>();
        }

        public int SectionBreakdownCodeId { get; set; }

        public int UnplattedReferenceId { get; set; }

        public virtual SectionBreakdownCode SectionBreakdownCode { get; set; }

        public virtual UnplattedReference UnplattedReference { get; set; }

        public virtual ICollection<AcreageSectionLegal> AcreageSectionLegal { get; set; }

        public virtual ICollection<PolicySectionLegalMql> PolicySectionLegalMql { get; set; }

        public virtual ICollection<TitleEventSectionLegalMql> TitleEventSectionLegalMql { get; set; }
    }
}