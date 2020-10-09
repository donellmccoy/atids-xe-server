using System.Collections.Generic;
using TheFund.AtidsXe.Common.Middleware;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class BreakdownCodeType
    {
        public BreakdownCodeType()
        {
            UnplattedReference = new HashSet<UnplattedReference>();
        }

        public int BreakdownCodeTypeId { get; set; }

        [Trim]
        public string Description { get; set; }

        public virtual ICollection<UnplattedReference> UnplattedReference { get; set; }
    }
}