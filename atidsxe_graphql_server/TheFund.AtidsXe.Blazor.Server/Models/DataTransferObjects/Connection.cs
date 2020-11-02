using System.Collections.Generic;
using System.Linq;

namespace TheFund.AtidsXe.Blazor.Server.Models.DataTransferObjects
{
    public sealed class Connection<T> where T : class 
    {
        public Connection()
        {
            Nodes = Enumerable.Empty<T>();
        }

        public string __TypeName { get; set; }

        public IEnumerable<T> Nodes { get; set; }

        //public IEnumerable<Edge> Edges { get; set; }

        public int TotalCount { get; set; }

        public PageInfo PageInfo { get; set; }
    }

    public sealed class Edge<T>
    {
        public string Cusor { get; set; }

        public T Node { get; set; }
    }
}
