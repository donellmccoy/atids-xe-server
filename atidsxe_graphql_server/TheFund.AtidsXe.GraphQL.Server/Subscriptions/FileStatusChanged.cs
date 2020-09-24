namespace TheFund.AtidsXe.GraphQL.Server.Subscriptions
{
    public class FileStatusChanged
    {
        public FileStatusChanged(int fileStatusId, int fileReferenceId)
        {
            FileStatusId = fileStatusId;
            FileReferenceId = fileReferenceId;
        }

        public int FileStatusId { get; }
        public int FileReferenceId { get; }
    }
}
