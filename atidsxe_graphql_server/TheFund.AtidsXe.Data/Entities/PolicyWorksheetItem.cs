namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PolicyWorksheetItem
    {
        public int PolicyId { get; set; }
        public int WorksheetId { get; set; }
        public int Sequence { get; set; }

        public virtual Policy Policy { get; set; }
        public virtual Worksheet Worksheet { get; set; }
    }
}