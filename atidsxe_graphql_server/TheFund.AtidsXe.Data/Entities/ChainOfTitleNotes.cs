using System;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class ChainOfTitleNotes
    {
        public int ChainOfTitleNotesId { get; set; }

        public int ChainOfTitleId { get; set; }

        public string UserId { get; set; }

        public DateTime TimeStamp { get; set; }

        public string Message { get; set; }

        public ChainOfTitle ChainOfTitle { get; set; }
    }
}