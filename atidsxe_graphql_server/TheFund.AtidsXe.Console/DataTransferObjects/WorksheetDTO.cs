namespace TheFund.AtidsXe.Console.DataTransferObjects
{
    public sealed class WorksheetDTO : DtoBase
    {
        public int WorksheetId { get; set; }

        public int FileReferenceId { get; set; }

        public Connection<WorksheetItemDTO> WorksheetItemsConnection { get; set; }
    }
}
