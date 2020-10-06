using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TownshipDirectionType
    {
        public TownshipDirectionType()
        {
            UnplattedReference = new HashSet<UnplattedReference>();
        }

        public int TownshipDirectionTypeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UnplattedReference> UnplattedReference { get; set; }
    }
}