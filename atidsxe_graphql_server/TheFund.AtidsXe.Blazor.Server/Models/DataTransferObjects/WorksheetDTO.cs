namespace TheFund.AtidsXe.Blazor.Server.Models.DataTransferObjects
{
    public sealed class WorksheetDTO : BaseDTO
    {
        public int WorksheetId { get; set; }

        public int FileReferenceId { get; set; }

        public Connection<WorksheetItemDTO> WorksheetItemsConnection { get; set; }
    }
}
