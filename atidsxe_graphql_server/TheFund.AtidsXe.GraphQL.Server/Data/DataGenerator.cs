using Ensure;
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
            services.EnsureNotNull();

            using (var context = new ATIDSXEContext(services.BuildServiceProvider().GetRequiredService<DbContextOptions<ATIDSXEContext>>()))
            {
                LoadBranchLocations(context);
                context.SaveChanges();
            }
        }

        private static void LoadBranchLocations(ATIDSXEContext context)
        {
            context.BranchLocation.AddRange
            (
                new BranchLocation
                {
                    BranchLocationId = 1,
                    AccountNumber = "1",
                    Description = "Branch 1"
                },
                new BranchLocation
                {
                    BranchLocationId = 2,
                    AccountNumber = "2",
                    Description = "Branch 2"
                },
                new BranchLocation
                {
                    BranchLocationId = 3,
                    AccountNumber = "3",
                    Description = "Branch 3"
                },
                new BranchLocation
                {
                    BranchLocationId = 4,
                    AccountNumber = "4",
                    Description = "Branch 4"
                },
                new BranchLocation
                {
                    BranchLocationId = 5,
                    AccountNumber = "5",
                    Description = "Branch 5"
                },
                new BranchLocation
                {
                    BranchLocationId = 6,
                    AccountNumber = "6",
                    Description = "Branch 6"
                }
            );
        }
    }
}
