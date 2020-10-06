using System;
using TheFund.AtidsXe.Common.Middleware;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class ChainOfTitleNotes
    {
        public int ChainOfTitleNotesId { get; set; }

        public int ChainOfTitleId { get; set; }

        [Trim]
        public string UserId { get; set; }

        public DateTime TimeStamp { get; set; }

        [Trim]
        public string Message { get; set; }

        public ChainOfTitle ChainOfTitle { get; set; }
    }
}