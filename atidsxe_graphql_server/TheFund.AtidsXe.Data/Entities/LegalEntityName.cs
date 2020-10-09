using System.Collections.Generic;
using TheFund.AtidsXe.Common.Middleware;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class LegalEntityName
    {
        public LegalEntityName()
        {
            NameSearchListItem = new HashSet<NameSearchListItem>();
            NameSearchParameters = new HashSet<NameSearchParameters>();
            PartyLegalEntityName = new HashSet<PartyLegalEntityName>();
            TitleEventLegalEntityMql = new HashSet<TitleEventLegalEntityMql>();
        }

        public int LegalEntityNameId { get; set; }

        [Trim]
        public string UnparsedLegalEntityName { get; set; }

        public int LegalEntityNameTypeId { get; set; }

        [Trim]
        public string Comments { get; set; }

        public virtual LegalEntityNameType LegalEntityNameType { get; set; }

        public virtual PersonalLegalEntityName PersonalLegalEntityName { get; set; }

        public virtual ICollection<NameSearchListItem> NameSearchListItem { get; set; }

        public virtual ICollection<NameSearchParameters> NameSearchParameters { get; set; }

        public virtual ICollection<PartyLegalEntityName> PartyLegalEntityName { get; set; }

        public virtual ICollection<TitleEventLegalEntityMql> TitleEventLegalEntityMql { get; set; }
    }
}