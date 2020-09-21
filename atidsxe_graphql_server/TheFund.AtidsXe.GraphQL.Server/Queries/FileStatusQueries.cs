using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;
using System.Linq;
using TheFund.AtidsXe.Data.Context;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.GraphQL.Server.Queries
{
    [ExtendObjectType(Name = "Query")]
    public class FileStatusQueries
    {
        [UsePaging]
        [UseSelection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<FileStatus> GetFileStatuses([Service] ATIDSXEContext context)
        {
            return context.FileStatus;
        }

        [UseFirstOrDefault]
        [UseSelection]
        public IQueryable<FileStatus> GetFileStatusById(int fileStatusId, [Service] ATIDSXEContext context)
        {
            return context.FileStatus.Where(p => p.FileStatusId == fileStatusId);
        }
    }
}
