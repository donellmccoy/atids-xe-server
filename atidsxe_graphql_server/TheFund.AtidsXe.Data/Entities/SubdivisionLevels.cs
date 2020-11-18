using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class SubdivisionLevels
    {
        public SubdivisionLevels()
        {
            PlattedLegals = new HashSet<PlattedLegal>();
        }

        public int SubdivisionLevelId { get; set; }

        [Trim]
        public string Level1 { get; set; }

        [Trim]
        public string Level2 { get; set; }

        [Trim]
        public string Level3 { get; set; }

        public virtual ICollection<PlattedLegal> PlattedLegals { get; set; }
    }
}