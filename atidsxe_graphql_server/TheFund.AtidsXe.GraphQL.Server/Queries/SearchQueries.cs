﻿using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;
using System.Linq;
using TheFund.AtidsXe.Data.Context;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.GraphQL.Server.Queries
{
    [ExtendObjectType(Name = "Query")]
    public class SearchQueries
    {
        [UsePaging]
        [UseSelection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Search> GetSearches([Service] ATIDSXEContext context)
        {
            return context.Search;
        }

        [UseSingleOrDefault]
        [UseSelection]
        public IQueryable<Search> GetSearchById([Service] ATIDSXEContext context, int searchId)
        {
            return context.Search.Where(p => p.SearchId == searchId);
        }
    }
}