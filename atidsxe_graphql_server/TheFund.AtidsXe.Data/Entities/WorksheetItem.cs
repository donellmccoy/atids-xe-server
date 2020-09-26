namespace TheFund.AtidsXe.Data.Entities
{
    public partial class WorksheetItem
    {
        public int TitleEventId { get; set; }

        public int WorksheetId { get; set; }

        public int Sequence { get; set; }

        public TitleEvent TitleEvent { get; set; }

        public Worksheet Worksheet { get; set; }
    }
}