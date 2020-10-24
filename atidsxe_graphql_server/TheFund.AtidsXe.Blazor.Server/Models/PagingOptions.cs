namespace TheFund.AtidsXe.Blazor.Server.Models
{
    public sealed class PagingOptions
    {
        public PagingOptions() : this(pageSize: 10)
        {
        }

        public PagingOptions(int pageSize)
        {
            PageSize = pageSize;
        }

        public int PageSize { get; }
    }
}
