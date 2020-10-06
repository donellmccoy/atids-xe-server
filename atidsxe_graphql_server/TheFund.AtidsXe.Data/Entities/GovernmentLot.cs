using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class GovernmentLot
    {
        public GovernmentLot()
        {
            GovernmentLotLegal = new HashSet<GovernmentLotLegal>();
        }

        public int GovernmentLotId { get; set; }
        public string GovernmentLotNumber { get; set; }

        public virtual ICollection<GovernmentLotLegal> GovernmentLotLegal { get; set; }
    }
}