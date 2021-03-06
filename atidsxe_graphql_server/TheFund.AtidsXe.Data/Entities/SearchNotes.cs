﻿using System;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class SearchNotes
    {
        public int SearchNotesId { get; set; }

        public int SearchId { get; set; }

        [Trim]
        public string UserId { get; set; }

        public DateTime TimeStamp { get; set; }

        [Trim]
        public string Message { get; set; }

        public virtual Search Search { get; set; }
    }
}