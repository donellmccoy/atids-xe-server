namespace TheFund.AtidsXe.Blazor.Server.Models.DataTransferObjects
{
    public sealed class WorksheetItem : DtoBase
    {
        public int TitleEventId { get; set; }

        public int WorksheetId { get; set; }

        public int Sequence { get; set; }
    }
}
