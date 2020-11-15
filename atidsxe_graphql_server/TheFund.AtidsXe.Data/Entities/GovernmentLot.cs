using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class GovernmentLot
    {
        public GovernmentLot()
        {
            GovernmentLotLegals = new HashSet<GovernmentLotLegal>();
        }

        public int GovernmentLotId { get; set; }

        [Trim]
        public string GovernmentLotNumber { get; set; }

        public virtual ICollection<GovernmentLotLegal> GovernmentLotLegals { get; set; }
    }
}