using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class Party
    {
        public Party()
        {
            PartyLegalEntityName = new HashSet<PartyLegalEntityName>();
            TitleEventParty = new HashSet<TitleEventParty>();
        }

        public int PartyId { get; set; }
        public int PartyRoleTypeId { get; set; }
        public string UnparsedParty { get; set; }

        public virtual PartyRoleType PartyRoleType { get; set; }
        public virtual ICollection<PartyLegalEntityName> PartyLegalEntityName { get; set; }
        public virtual ICollection<TitleEventParty> TitleEventParty { get; set; }
    }
}