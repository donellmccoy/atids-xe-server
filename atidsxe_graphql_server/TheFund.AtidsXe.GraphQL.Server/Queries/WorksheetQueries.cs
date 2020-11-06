using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;
using System.Linq;
using TheFund.AtidsXe.Data.Context;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.GraphQL.Server.Queries
{
    [ExtendObjectType(Name = "Query")]
    public class WorksheetQueries
    {
        [UsePaging]
        [UseSelection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Worksheet> GetWorksheets([Service] ApplicationDbContext context)
        {
            return context.Worksheet;
        }

        [UseSingleOrDefault]
        [UseSelection]
        public IQueryable<Worksheet> GetWorksheet([Service] ApplicationDbContext context, int fileReferenceId, int worksheetId)
        {
            return context.Worksheet.Where(p => p.FileReferenceId == fileReferenceId && p.WorksheetId == worksheetId);
        }
    }
}
