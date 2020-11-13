namespace TheFund.AtidsXe.Console
{
    public class WorksheetRequest
    {
        public WorksheetRequest(int fileReferenceId, int worksheetId, PagingOptions pagingOptions)
        {
            FileReferenceId = fileReferenceId;
            WorksheetId = worksheetId;
            PagingOptions = pagingOptions;
        }

        public int FileReferenceId { get; }

        public int WorksheetId { get; }

        public (int fileReferenceId, int worksheetId) Key => (FileReferenceId, WorksheetId);

        public PagingOptions PagingOptions { get; }
    }
}
