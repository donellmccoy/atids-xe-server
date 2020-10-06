namespace TheFund.AtidsXe.Console
{
    public class PageInfo
        : IPageInfo
    {
        public PageInfo(
            string startCursor,
            string endCursor,
            bool hasPreviousPage,
            bool hasNextPage)
        {
            StartCursor = startCursor;
            EndCursor = endCursor;
            HasPreviousPage = hasPreviousPage;
            HasNextPage = hasNextPage;
        }

        public string StartCursor { get; }

        public string EndCursor { get; }

        public bool HasPreviousPage { get; }

        public bool HasNextPage { get; }
    }
}
