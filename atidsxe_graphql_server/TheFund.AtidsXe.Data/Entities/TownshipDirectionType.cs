using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TownshipDirectionType
    {
        public TownshipDirectionType()
        {
            UnplattedReferences = new HashSet<UnplattedReference>();
        }

        public int TownshipDirectionTypeId { get; set; }

        [Trim]
        public string Description { get; set; }

        public virtual ICollection<UnplattedReference> UnplattedReferences { get; set; }
    }
}