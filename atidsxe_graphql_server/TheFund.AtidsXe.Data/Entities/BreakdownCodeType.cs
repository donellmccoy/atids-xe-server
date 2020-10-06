using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class BreakdownCodeType
    {
        public BreakdownCodeType()
        {
            UnplattedReference = new HashSet<UnplattedReference>();
        }

        public int BreakdownCodeTypeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UnplattedReference> UnplattedReference { get; set; }
    }
}