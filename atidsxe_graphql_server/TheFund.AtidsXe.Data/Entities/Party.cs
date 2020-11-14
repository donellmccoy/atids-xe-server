using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class Party
    {
        public Party()
        {
            PartyLegalEntityNames = new HashSet<PartyLegalEntityName>();
            TitleEventParties = new HashSet<TitleEventParty>();
        }

        public int PartyId { get; set; }

        public int PartyRoleTypeId { get; set; }

        [Trim]
        public string UnparsedParty { get; set; }

        public virtual PartyRoleType PartyRoleType { get; set; }

        public virtual ICollection<PartyLegalEntityName> PartyLegalEntityNames { get; set; }

        public virtual ICollection<TitleEventParty> TitleEventParties { get; set; }
    }
}