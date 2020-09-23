namespace TheFund.AtidsXe.GraphQL.Server.Mutations
{
    public class UpdateBranchLocationInput
    {
        public UpdateBranchLocationInput(int fileReferenceId, int branchLocationId)
        {
            FileReferenceId = fileReferenceId;
            BranchLocationId = branchLocationId;
        }

        public int FileReferenceId { get; }
        public int BranchLocationId { get; }
    }

}
