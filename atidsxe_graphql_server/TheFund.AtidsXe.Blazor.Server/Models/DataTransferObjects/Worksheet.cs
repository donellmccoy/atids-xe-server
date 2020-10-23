namespace TheFund.AtidsXe.Blazor.Server.Models.DataTransferObjects
{
    public sealed class Worksheet : DtoBase
    {
        public int WorksheetId { get; set; }

        public int FileReferenceId { get; set; }

        public Connection<WorksheetItem> WorksheetItemsConnection { get; set; }
    }
}
