using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class LegalEntityNameType
    {
        public LegalEntityNameType()
        {
            LegalEntityName = new HashSet<LegalEntityName>();
        }

        public int LegalEntityNameTypeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LegalEntityName> LegalEntityName { get; set; }
    }
}