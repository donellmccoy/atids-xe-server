using HotChocolate;
using HotChocolate.Types;
using System.Threading;
using System.Threading.Tasks;
using TheFund.AtidsXe.Data.Context;
using HotChocolate.Types.Relay;
using Microsoft.EntityFrameworkCore;
using System;

namespace TheFund.AtidsXe.GraphQL.Server.Mutations
{
    [ExtendObjectType(Name = "Mutation")]
    public class FileReferenceMutations
    {
        public async Task<UpdateTemporaryFileStatusPayload> UpdateTemporaryFileStatusAsync(
            UpdateTemporaryFileStatusInput input,
            [Service] ATIDSXEContext context,
            CancellationToken cancellationToken)
        {
            var fileReference = await context.FileReference.FindAsync(input.FileReferenceId);
            if (fileReference == null)
            {
                return null;
            }

            fileReference.IsTemporaryFile = (byte?)(input.IsTemporaryFile.HasValue && input.IsTemporaryFile.Value ? 1 : 0);
            fileReference.UpdateDate = DateTime.Now;

            context.Entry(fileReference).State = EntityState.Modified;

            await context.SaveChangesAsync(cancellationToken);

            return new UpdateTemporaryFileStatusPayload(fileReference);
        }

        public async Task<UpdateBranchLocationPayload> UpdateBranchLocationAsync(
            UpdateBranchLocationInput input,
            [Service] ATIDSXEContext context,
            CancellationToken cancellationToken)
        {
            var fileReference = await context.FileReference.FindAsync(input.FileReferenceId);
            if(fileReference == null)
            {
                return null;
            }

            fileReference.BranchLocationId = input.BranchLocationId;
            fileReference.UpdateDate = DateTime.Now;

            context.Entry(fileReference).State = EntityState.Modified;

            await context.SaveChangesAsync(cancellationToken);

            return new UpdateBranchLocationPayload(fileReference);
        }

        public async Task<UpdateFileStatusPayload> UpdateFileStatusAsync(
            UpdateFileStatusInput input,
            [Service] ATIDSXEContext context,
            CancellationToken cancellationToken)
        {
            var fileReference = await context.FileReference.FindAsync(input.FileReferenceId);
            if (fileReference == null)
            {
                return null;
            }

            fileReference.FileStatusId = input.FileStatusId;
            fileReference.UpdateDate = DateTime.Now;

            context.Entry(fileReference).State = EntityState.Modified;

            await context.SaveChangesAsync(cancellationToken);

            return new UpdateFileStatusPayload(fileReference);
        }
    }
}
