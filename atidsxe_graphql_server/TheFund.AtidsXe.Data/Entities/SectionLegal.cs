using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class SectionLegal
    {
        public SectionLegal()
        {
            AcreageSectionLegals = new HashSet<AcreageSectionLegal>();
            PolicySectionLegalMqls = new HashSet<PolicySectionLegalMql>();
            TitleEventSectionLegalMqls = new HashSet<TitleEventSectionLegalMql>();
        }

        public int SectionBreakdownCodeId { get; set; }

        public int UnplattedReferenceId { get; set; }

        public virtual SectionBreakdownCode SectionBreakdownCode { get; set; }

        public virtual UnplattedReference UnplattedReference { get; set; }

        public virtual ICollection<AcreageSectionLegal> AcreageSectionLegals { get; set; }

        public virtual ICollection<PolicySectionLegalMql> PolicySectionLegalMqls { get; set; }

        public virtual ICollection<TitleEventSectionLegalMql> TitleEventSectionLegalMqls { get; set; }
    }
}