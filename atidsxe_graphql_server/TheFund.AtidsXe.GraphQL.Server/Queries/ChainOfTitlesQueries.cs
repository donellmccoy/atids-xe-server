using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;
using System;
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
        public IQueryable<ChainOfTitle> GetChainOfTitles(int fileReferenceId, [Service] ATIDSXEContext context)
        {
            return context.ChainOfTitle.Where(p => p.FileReferenceId == fileReferenceId);
        }

        [UseSingleOrDefault]
        [UseSelection]
        public IQueryable<ChainOfTitle> GetChainOfTitle(int fileReferenceId, int chainOfTitleId, [Service] ATIDSXEContext context)
        {
            return context.ChainOfTitle.Where(p => p.FileReferenceId == fileReferenceId && p.ChainOfTitleId == chainOfTitleId);
        }
    }
}
