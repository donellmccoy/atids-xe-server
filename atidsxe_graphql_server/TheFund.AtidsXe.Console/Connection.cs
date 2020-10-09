using System.Collections.Generic;

namespace TheFund.AtidsXe.Console
{
    public class Connection<T> : IConnection<T> where T: class
    {
        public Connection(
            int totalCount,
            IPageInfo pageInfo,
            IReadOnlyList<T> nodes)
        {
            TotalCount = totalCount;
            PageInfo = pageInfo;
            Nodes = nodes;
        }

        public int TotalCount { get; }

        public IPageInfo PageInfo { get; }

        public IReadOnlyList<T> Nodes { get; }
    }
}
