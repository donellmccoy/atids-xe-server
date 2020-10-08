﻿using System;
using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TitleEventOrder
    {
        public TitleEventOrder()
        {
            TitleEventOrderTracking = new HashSet<TitleEventOrderTracking>();
        }

        public int TitleEventOrderId { get; set; }
        public string TrackingIdentifier { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual ICollection<TitleEventOrderTracking> TitleEventOrderTracking { get; set; }
    }
}