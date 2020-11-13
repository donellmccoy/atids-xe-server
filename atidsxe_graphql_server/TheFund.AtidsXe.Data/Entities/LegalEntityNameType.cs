using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class LegalEntityNameType
    {
        public LegalEntityNameType()
        {
            LegalEntityName = new HashSet<LegalEntityName>();
        }

        public int LegalEntityNameTypeId { get; set; }

        [Trim]
        public string Description { get; set; }

        public virtual ICollection<LegalEntityName> LegalEntityName { get; set; }
    }
}