﻿using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class SubdivisionLevels
    {
        public SubdivisionLevels()
        {
            PlattedLegals = new HashSet<PlattedLegal>();
        }

        public int SubdivisionLevelId { get; set; }

        public string Level1 { get; set; }

        public string Level2 { get; set; }

        public string Level3 { get; set; }

        public virtual ICollection<PlattedLegal> PlattedLegals { get; set; }
    }
}