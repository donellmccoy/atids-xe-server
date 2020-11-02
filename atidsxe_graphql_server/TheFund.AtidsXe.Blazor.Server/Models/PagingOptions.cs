namespace TheFund.AtidsXe.Blazor.Server.Models
{
    public sealed class PagingOptions
    {
        public PagingOptions() : this(pageSize: 10, startCursor: null)
        {
        }

        public PagingOptions(int pageSize)
        {
            PageSize = pageSize;
        }

        public PagingOptions(int pageSize, string startCursor)
        {
            PageSize = pageSize;
            StartCursor = startCursor;
        }

        public int PageSize { get; }

        public string StartCursor { get; }
    }
}
