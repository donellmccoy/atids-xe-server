using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;
using System.Linq;
using TheFund.AtidsXe.Data.Context;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.GraphQL.Server.Queries
{
    [ExtendObjectType(Name = "Query")]
    public class BranchLocationQueries
    {
        [UsePaging]
        [UseSelection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<BranchLocation> GetBranchLocations([Service] ATIDSXEContext context)
        {
            return context.BranchLocation;
        }

        [UseFirstOrDefault]
        [UseSelection]
        public IQueryable<BranchLocation> GetBranchLocationByAccountNumber(string accountNumber, [Service] ATIDSXEContext context)
        {
            return context.BranchLocation.Where(p => p.AccountNumber == accountNumber);
        }

        [UseFirstOrDefault]
        [UseSelection]
        public IQueryable<BranchLocation> GetBranchLocationById(int branchLocationId, [Service] ATIDSXEContext context)
        {
            return context.BranchLocation.Where(p => p.BranchLocationId == branchLocationId);
        }
    }
}
