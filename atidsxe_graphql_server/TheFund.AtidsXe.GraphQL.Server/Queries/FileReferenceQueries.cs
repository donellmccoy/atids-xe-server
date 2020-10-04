using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;
using System.Linq;
using TheFund.AtidsXe.Data.Context;
using TheFund.AtidsXe.Data.Entities;

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


        [UseSingleOrDefault]
        [UseSelection]
        public IQueryable<FileReference> GetFileReferenceById([Service] ATIDSXEContext context, int fileReferenceId)
        {
            return context.FileReference.Where(p => p.FileReferenceId == fileReferenceId).AsQueryable();
        }
    }
}
