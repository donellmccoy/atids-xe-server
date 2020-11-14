using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class LegalEntityNameType
    {
        public LegalEntityNameType()
        {
            LegalEntityNames = new HashSet<LegalEntityName>();
        }

        public int LegalEntityNameTypeId { get; set; }

        [Trim]
        public string Description { get; set; }

        public virtual ICollection<LegalEntityName> LegalEntityNames { get; set; }
    }
}