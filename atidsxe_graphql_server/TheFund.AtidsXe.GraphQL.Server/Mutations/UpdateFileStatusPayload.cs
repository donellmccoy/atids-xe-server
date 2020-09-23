
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.GraphQL.Server.Mutations
{
    public class UpdateFileStatusPayload
    {
        public UpdateFileStatusPayload(FileReference fileReference) => FileReference = fileReference;

        public FileReference FileReference { get; }
    }
}
