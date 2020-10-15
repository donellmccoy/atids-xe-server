using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;
using System.Linq;
using TheFund.AtidsXe.Data.Context;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.GraphQL.Server.Queries
{
    [ExtendObjectType(Name = "Query")]
    public class TitleEventSearchQueries
    {
        [UsePaging]
        [UseSelection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<TitleEventSearch> GetTitleEventSearches([Service] ATIDSXEContext context)
        {
            return context.TitleEventSearch;
        }

        [UseSingleOrDefault]
        [UseSelection]
        public IQueryable<TitleEventSearch> GetTitleEventSearchById(int searchId, int titleEventId, [Service] ATIDSXEContext context)
        {
            return context.TitleEventSearch.Where(p => p.SearchId == searchId && p.TitleEventId == titleEventId);
        }
    }
}
