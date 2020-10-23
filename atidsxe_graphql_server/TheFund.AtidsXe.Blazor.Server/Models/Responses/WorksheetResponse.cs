using System.Collections.Generic;
using TheFund.AtidsXe.Blazor.Server.Models.DataTransferObjects;

namespace TheFund.AtidsXe.Blazor.Server.Models.Responses
{
    public sealed class WorksheetResponse
    {
        public Connection<WorksheetItem> WorksheetConnection { get; set; }

        public IEnumerable<WorksheetItem> WorksheetItems => WorksheetConnection?.Nodes ?? new List<WorksheetItem>();

        public PageInfo PageInfo => WorksheetConnection?.PageInfo ?? new PageInfo();

        public int TotalCount => WorksheetConnection?.TotalCount ?? 0;
    }
}
