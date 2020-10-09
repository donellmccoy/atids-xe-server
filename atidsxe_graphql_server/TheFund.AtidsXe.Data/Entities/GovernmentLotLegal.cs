using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class GovernmentLotLegal
    {
        public GovernmentLotLegal()
        {
            AcreageGovtLotLegal = new HashSet<AcreageGovtLotLegal>();
            PolicyGovtLotLegalMql = new HashSet<PolicyGovtLotLegalMql>();
            TitleEventGovtLotLegalMql = new HashSet<TitleEventGovtLotLegalMql>();
        }

        public int UnplattedReferenceId { get; set; }

        public int GovernmentLotId { get; set; }

        public virtual GovernmentLot GovernmentLot { get; set; }

        public virtual UnplattedReference UnplattedReference { get; set; }

        public virtual ICollection<AcreageGovtLotLegal> AcreageGovtLotLegal { get; set; }

        public virtual ICollection<PolicyGovtLotLegalMql> PolicyGovtLotLegalMql { get; set; }

        public virtual ICollection<TitleEventGovtLotLegalMql> TitleEventGovtLotLegalMql { get; set; }
    }
}