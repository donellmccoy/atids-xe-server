using System.Collections.Generic;

namespace TheFund.AtidsXe.Console.DataTransferObjects
{
    public class Connection<T> where T : class 
    {
        public Connection()
        {
            Nodes = new List<T>();
        }

        public string __TypeName { get; set; }

        public IEnumerable<T> Nodes { get; set; }

        public int TotalCount { get; set; }

        public PageInfo PageInfo { get; set; }
    }
}
