
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.GraphQL.Server.Mutations
{
    public class UpdateTemporaryFileStatusPayload
    {
        public UpdateTemporaryFileStatusPayload(FileReference fileReference) => FileReference = fileReference;

        public FileReference FileReference { get; }
    }
}
