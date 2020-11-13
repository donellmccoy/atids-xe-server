using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class LegalEntityName
    {
        public LegalEntityName()
        {
            NameSearchListItems = new HashSet<NameSearchListItem>();
            NameSearchParameters = new HashSet<NameSearchParameters>();
            PartyLegalEntityNames = new HashSet<PartyLegalEntityName>();
            TitleEventLegalEntityMqls = new HashSet<TitleEventLegalEntityMql>();
        }

        public int LegalEntityNameId { get; set; }

        [Trim]
        public string UnparsedLegalEntityName { get; set; }

        public int LegalEntityNameTypeId { get; set; }

        [Trim]
        public string Comments { get; set; }

        public virtual LegalEntityNameType LegalEntityNameType { get; set; }

        public virtual PersonalLegalEntityName PersonalLegalEntityName { get; set; }

        public virtual ICollection<NameSearchListItem> NameSearchListItems { get; set; }

        public virtual ICollection<NameSearchParameters> NameSearchParameters { get; set; }

        public virtual ICollection<PartyLegalEntityName> PartyLegalEntityNames { get; set; }

        public virtual ICollection<TitleEventLegalEntityMql> TitleEventLegalEntityMqls { get; set; }
    }
}