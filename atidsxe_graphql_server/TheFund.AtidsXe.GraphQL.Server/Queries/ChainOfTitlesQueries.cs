using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;
using System.Linq;
using TheFund.AtidsXe.Data.Context;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.GraphQL.Server.Queries
{
    [ExtendObjectType(Name = "Query")]
    public class ChainOfTitlesQueries
    {
        [UsePaging]
        [UseSelection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<ChainOfTitle> GetChainOfTitles([Service] ATIDSXEContext context)
        {
            return context.ChainOfTitle;
        }

        [UseSingleOrDefault]
        [UseSelection]
        public IQueryable<ChainOfTitle> GetChainOfTitleById(int chainOfTitleId, [Service] ATIDSXEContext context)
        {
            return context.ChainOfTitle.Where(p => p.ChainOfTitleId == chainOfTitleId);
        }
    }
}
