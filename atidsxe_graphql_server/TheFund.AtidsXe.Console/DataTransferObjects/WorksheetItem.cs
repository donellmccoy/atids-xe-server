namespace TheFund.AtidsXe.Console.DataTransferObjects
{
    public sealed class WorksheetItem : DtoBase
    {
        public int TitleEventId { get; set; }

        public int WorksheetId { get; set; }

        public int Sequence { get; set; }
    }
}
