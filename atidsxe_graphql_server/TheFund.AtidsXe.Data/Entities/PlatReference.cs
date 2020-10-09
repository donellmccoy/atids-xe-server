﻿using HotChocolate.Types;
using System.Collections.Generic;
using TheFund.AtidsXe.Common.Middleware;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PlatReference
    {
        public PlatReference()
        {
            PlattedLegal = new HashSet<PlattedLegal>();
        }

        public int PlatReferenceId { get; set; }

        [Trim]
        public string Source { get; set; }

        [Trim]
        public string Book { get; set; }

        [Trim]
        public string BookSuffix { get; set; }

        [Trim]
        public string Page { get; set; }

        [Trim]
        public string PageSuffix { get; set; }

        public virtual PlatProperties PlatProperties { get; set; }

        [UseFiltering]
        [UseSorting]
        public virtual ICollection<PlattedLegal> PlattedLegal { get; set; }
    }
}