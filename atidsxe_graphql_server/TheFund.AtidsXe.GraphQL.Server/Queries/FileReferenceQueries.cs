using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TheFund.AtidsXe.Data.Context;
using TheFund.AtidsXe.Data.Entities;
using TheFund.AtidsXe.GraphQL.Server.DataLoaders;

namespace TheFund.AtidsXe.GraphQL.Server.Queries
{
    [ExtendObjectType(Name = "Query")]
    public class FileReferenceQueries
    {
        [UsePaging]
        [UseSelection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<FileReference> GetFileReferences([Service] ATIDSXEContext context)
        {
            return context.FileReference;
        }

        public async Task<FileReference> GetFileReferenceByIdAsync(
            int id,
            FileReferenceByIdDataLoader loader,
            CancellationToken cancellationToken)
        {
            return await loader.LoadAsync(id, cancellationToken);
        }

        public async Task<IEnumerable<FileReference>> GetFileReferencesByIdAsync(
            int[] ids,
            FileReferenceByIdDataLoader loader,
            CancellationToken cancellationToken)
        {
            return await loader.LoadAsync(ids, cancellationToken);
        }
    }
}
