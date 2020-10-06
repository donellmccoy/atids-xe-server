namespace TheFund.AtidsXe.Console
{
    public interface IPageInfo
    {
        string StartCursor { get; }

        string EndCursor { get; }

        bool HasPreviousPage { get; }

        bool HasNextPage { get; }
    }
}
