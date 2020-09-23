namespace TheFund.AtidsXe.GraphQL.Server.Mutations
{
    public class UpdateFileStatusInput
    {
        public UpdateFileStatusInput(int fileReferenceId, int fileStatusId)
        {
            FileReferenceId = fileReferenceId;
            FileStatusId = fileStatusId;
        }

        public int FileReferenceId { get; }
        public int FileStatusId { get; }
    }
}
