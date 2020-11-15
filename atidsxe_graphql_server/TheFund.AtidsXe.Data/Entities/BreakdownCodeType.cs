using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class BreakdownCodeType
    {
        public BreakdownCodeType()
        {
            UnplattedReferences = new HashSet<UnplattedReference>();
        }

        public int BreakdownCodeTypeId { get; set; }

        [Trim]
        public string Description { get; set; }

        public virtual ICollection<UnplattedReference> UnplattedReferences { get; set; }
    }
}