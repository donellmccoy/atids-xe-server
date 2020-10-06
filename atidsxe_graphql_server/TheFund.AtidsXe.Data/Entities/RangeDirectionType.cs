using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class RangeDirectionType
    {
        public RangeDirectionType()
        {
            UnplattedReference = new HashSet<UnplattedReference>();
        }

        public int RangeDirectionTypeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UnplattedReference> UnplattedReference { get; set; }
    }
}