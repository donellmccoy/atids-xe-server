using HotChocolate;
using HotChocolate.Types;
using System.Linq;
using TheFund.AtidsXe.Data.Context;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.GraphQL.Server.Queries
{
    [ExtendObjectType(Name = "Query")]
    public class TitleEventTypeQueries
    {
        [UseSelection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<TitleEventType> GetTitleEventTypes([Service] ATIDSXEContext context)
        {
            return context.TitleEventType;
        }

        [UseSingleOrDefault]
        [UseSelection]
        public IQueryable<TitleEventType> GetTitleEventType(int titleEventTypeId, [Service] ATIDSXEContext context)
        {
            return context.TitleEventType.Where(p => p.TitleEventTypeId == titleEventTypeId);
        }
    }
}
