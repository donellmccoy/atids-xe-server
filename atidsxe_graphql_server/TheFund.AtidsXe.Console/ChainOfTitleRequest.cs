namespace TheFund.AtidsXe.Console
{
    public class ChainOfTitleRequest
    {
        public ChainOfTitleRequest(int fileReferenceId, int chainOfTitleId, PagingOptions pagingOptions)
        {
            FileReferenceId = fileReferenceId;
            ChainOfTitleId = chainOfTitleId;
            PagingOptions = pagingOptions;
        }

        public int FileReferenceId { get; }

        public int ChainOfTitleId { get; }

        public (int fileReferenceId, int chainOfTitleId) Key => (FileReferenceId, ChainOfTitleId);

        public PagingOptions PagingOptions { get; }
    }
}
