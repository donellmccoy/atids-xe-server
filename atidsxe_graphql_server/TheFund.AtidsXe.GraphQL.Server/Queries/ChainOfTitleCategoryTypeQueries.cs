using HotChocolate;
using HotChocolate.Types;
using System.Linq;
using TheFund.AtidsXe.Data.Context;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.GraphQL.Server.Queries
{
    [ExtendObjectType(Name = "Query")]
    public class ChainOfTitleCategoryTypeQueries
    {
        [UseSelection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<ChainOfTitleCategory> GetChainOfTitleCategoryTypes([Service] ApplicationDbContext context)
        {
            return context.ChainOfTitleCategory;
        }

        [UseSingleOrDefault]
        [UseSelection]
        public IQueryable<ChainOfTitleCategory> GetChainOfTitleCategoryType(int chainOfTitleCategoryId, [Service] ApplicationDbContext context)
        {
            return context.ChainOfTitleCategory.Where(p => p.ChainOfTitleCategoryId == chainOfTitleCategoryId);
        }
    }
}
