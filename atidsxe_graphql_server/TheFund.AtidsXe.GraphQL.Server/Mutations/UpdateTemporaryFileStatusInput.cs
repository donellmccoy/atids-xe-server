namespace TheFund.AtidsXe.GraphQL.Server.Mutations
{
    public class UpdateTemporaryFileStatusInput
    {
        public UpdateTemporaryFileStatusInput(int fileReferenceId, bool? isTemporaryFile)
        {
            FileReferenceId = fileReferenceId;
            IsTemporaryFile = isTemporaryFile;
        }

        public int FileReferenceId { get; }
        public bool? IsTemporaryFile { get; }
    }

}
