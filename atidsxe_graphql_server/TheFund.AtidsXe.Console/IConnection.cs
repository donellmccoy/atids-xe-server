using System.Collections.Generic;

namespace TheFund.AtidsXe.Console
{
    public interface IConnection<T> 
    {
        int TotalCount { get; }

        IPageInfo PageInfo { get; }

        IReadOnlyList<T> Nodes { get; }
    }
}
