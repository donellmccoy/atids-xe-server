using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TheFund.AtidsXe.Data.Context;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.GraphQL.Server.Data
{
    public class DataGenerator
    {
        public static void Initialize(IServiceCollection services)
        {
            using var context = new ATIDSXEContext(services.BuildServiceProvider().GetRequiredService<DbContextOptions<ATIDSXEContext>>());
            context.BranchLocation.AddRange
            (
                new BranchLocation
                {
                    BranchLocationId = 1,
                    AccountNumber = "1",
                    Description = ""
                },
                new BranchLocation
                {
                    BranchLocationId = 2,
                    AccountNumber = "2",
                    Description = ""
                },
                new BranchLocation
                {
                    BranchLocationId = 3,
                    AccountNumber = "3",
                    Description = ""
                },
                new BranchLocation
                {
                    BranchLocationId = 4,
                    AccountNumber = "4",
                    Description = ""
                },
                new BranchLocation
                {
                    BranchLocationId = 5,
                    AccountNumber = "5",
                    Description = ""
                },
                new BranchLocation
                {
                    BranchLocationId = 6,
                    AccountNumber = "6",
                    Description = ""
                }
            );

            context.SaveChanges();
        }
    }
}
