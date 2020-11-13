using System;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TitleEventNotes
    {
        public int TitleEventNotesId { get; set; }

        public int TitleEventId { get; set; }

        [Trim]
        public string UserId { get; set; }

        public DateTime TimeStamp { get; set; }

        [Trim]
        public string Message { get; set; }

        public virtual TitleEvent TitleEvent { get; set; }
    }
}