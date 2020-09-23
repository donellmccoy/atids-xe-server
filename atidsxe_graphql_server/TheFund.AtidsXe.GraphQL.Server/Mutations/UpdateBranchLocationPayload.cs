
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.GraphQL.Server.Mutations
{
    public class UpdateBranchLocationPayload
    {
        public UpdateBranchLocationPayload(FileReference fileReference) => FileReference = fileReference;

        public FileReference FileReference { get; }
    }

}
