using System.Collections.Generic;

namespace TheFund.AtidsXe.Console.DataTransferObjects
{
    public sealed class ChainOfTitleResponse
    {
        public Connection<ChainOfTitle> ChainOfTitleConnection { get; set; }

        public IEnumerable<ChainOfTitle> ChainOfTitle => ChainOfTitleConnection?.Nodes ?? new List<ChainOfTitle>();

        public PageInfo PageInfo => ChainOfTitleConnection?.PageInfo ?? new PageInfo();

        public int TotalCount => ChainOfTitleConnection?.TotalCount ?? 0;
    }
}
