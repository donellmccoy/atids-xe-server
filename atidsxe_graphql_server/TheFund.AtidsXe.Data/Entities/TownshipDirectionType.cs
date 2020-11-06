using System.Collections.Generic;
using TheFund.AtidsXe.Common.Middleware;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TownshipDirectionType
    {
        public TownshipDirectionType()
        {
            UnplattedReference = new HashSet<UnplattedReference>();
        }

        public int TownshipDirectionTypeId { get; set; }

        [Trim]
        public string Description { get; set; }

        public virtual ICollection<UnplattedReference> UnplattedReference { get; set; }
    }
}