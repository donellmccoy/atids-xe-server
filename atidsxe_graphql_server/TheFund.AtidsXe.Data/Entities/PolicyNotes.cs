using System;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PolicyNotes
    {
        public int PolicyNotesId { get; set; }
        public int PolicyId { get; set; }
        public string UserId { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Message { get; set; }

        public virtual Policy Policy { get; set; }
    }
}