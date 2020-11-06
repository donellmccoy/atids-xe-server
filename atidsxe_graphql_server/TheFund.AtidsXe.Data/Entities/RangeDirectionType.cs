using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class RangeDirectionType
    {
        public RangeDirectionType()
        {
            UnplattedReference = new HashSet<UnplattedReference>();
        }

        public int RangeDirectionTypeId { get; set; }

        [Trim]
        public string Description { get; set; }

        public virtual ICollection<UnplattedReference> UnplattedReference { get; set; }
    }
}