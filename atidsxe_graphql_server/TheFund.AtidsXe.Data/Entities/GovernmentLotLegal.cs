using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class GovernmentLotLegal
    {
        public GovernmentLotLegal()
        {
            AcreageGovtLotLegals = new HashSet<AcreageGovtLotLegal>();
            PolicyGovtLotLegalMqls = new HashSet<PolicyGovtLotLegalMql>();
            TitleEventGovtLotLegalMqls = new HashSet<TitleEventGovtLotLegalMql>();
        }

        public int UnplattedReferenceId { get; set; }

        public int GovernmentLotId { get; set; }

        public virtual GovernmentLot GovernmentLot { get; set; }

        public virtual UnplattedReference UnplattedReference { get; set; }

        public virtual ICollection<AcreageGovtLotLegal> AcreageGovtLotLegals { get; set; }

        public virtual ICollection<PolicyGovtLotLegalMql> PolicyGovtLotLegalMqls { get; set; }

        public virtual ICollection<TitleEventGovtLotLegalMql> TitleEventGovtLotLegalMqls { get; set; }
    }
}