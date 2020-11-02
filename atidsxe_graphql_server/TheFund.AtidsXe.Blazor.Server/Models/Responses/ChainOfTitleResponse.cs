using System.Collections.Generic;
using TheFund.AtidsXe.Blazor.Server.Models.DataTransferObjects;

namespace TheFund.AtidsXe.Blazor.Server.Models.Responses
{
    public sealed class ChainOfTitleResponse
    {
        public Connection<ChainOfTitleDTO> ChainOfTitleConnection { get; set; }

        public IEnumerable<ChainOfTitleDTO> ChainOfTitle => ChainOfTitleConnection?.Nodes ?? new List<ChainOfTitleDTO>();

        public PageInfo PageInfo => ChainOfTitleConnection?.PageInfo ?? new PageInfo();

        public int TotalCount => ChainOfTitleConnection?.TotalCount ?? 0;
    }
}
