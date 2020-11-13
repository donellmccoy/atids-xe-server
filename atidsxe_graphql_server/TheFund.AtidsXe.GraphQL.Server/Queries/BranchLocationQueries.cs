using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;
using Microsoft.EntityFrameworkCore;
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
        public IQueryable<BranchLocation> GetBranchLocations([Service] ApplicationDbContext context)
        {
            return context.BranchLocation.Include(p => p.FileReference);
        }

        [UseFirstOrDefault]
        [UseSelection]
        public IQueryable<BranchLocation> GetBranchLocationByAccountNumber(string accountNumber, [Service] ApplicationDbContext context)
        {
            if (string.IsNullOrWhiteSpace(accountNumber))
            {
                throw new System.ArgumentException($"'{nameof(accountNumber)}' cannot be null or whitespace", nameof(accountNumber));
            }

            return context.BranchLocation.Where(p => p.AccountNumber == accountNumber);
        }

        [UseFirstOrDefault]
        [UseSelection]
        public IQueryable<BranchLocation> GetBranchLocationById(int branchLocationId, [Service] ApplicationDbContext context)
        {
            return context.BranchLocation.Where(p => p.BranchLocationId == branchLocationId);
        }
    }
}
