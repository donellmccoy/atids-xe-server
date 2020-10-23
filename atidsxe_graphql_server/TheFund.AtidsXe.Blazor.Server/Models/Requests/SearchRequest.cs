namespace TheFund.AtidsXe.Blazor.Server.Models.Requests
{
    public class SearchRequest
    {
        public SearchRequest(int fileReferenceId, int searchId, PagingOptions pagingOptions)
        {
            FileReferenceId = fileReferenceId;
            SearchId = searchId;
            PagingOptions = pagingOptions;
        }

        public int FileReferenceId { get; }

        public int SearchId { get; }

        public (int fileReferenceId, int searchId) Key => (FileReferenceId, SearchId);

        public PagingOptions PagingOptions { get; }
    }
}
