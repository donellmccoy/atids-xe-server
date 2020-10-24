using System.Collections.Generic;
using TheFund.AtidsXe.Blazor.Server.Models.DataTransferObjects;

namespace TheFund.AtidsXe.Blazor.Server.Models.Responses
{
    public sealed class WorksheetResponse
    {
        public Connection<WorksheetItemDTO> WorksheetConnection { get; set; }

        public IEnumerable<WorksheetItemDTO> WorksheetItems => WorksheetConnection?.Nodes ?? new List<WorksheetItemDTO>();

        public PageInfoDTO PageInfo => WorksheetConnection?.PageInfo ?? new PageInfoDTO();

        public int TotalCount => WorksheetConnection?.TotalCount ?? 0;
    }
}
