using Ensure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using TheFund.AtidsXe.Data.Context;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.GraphQL.Server.Data
{
    public class DataGenerator
    {
        public static void Initialize(IServiceCollection services)
        {
            services.EnsureNotNull();

            using var context = new ApplicationDbContext(services.BuildServiceProvider().GetRequiredService<DbContextOptions<ApplicationDbContext>>());
            LoadBranchLocations(context);
            LoadFileStatuses(context);
            LoadGeographicLocales(context);
            LoadFileReferences(context);

            context.SaveChanges();
        }

        private static void LoadGeographicLocales(ApplicationDbContext context)
        {
            context.GeographicLocale.AddRange
            (
                new GeographicLocale
                {
                    GeographicLocaleId = 1,
                    GeographicLocaleTypeId = 1,
                    ParentGeographicLocaleId = 1,
                    LocaleName = "",
                    LocaleAbbreviation = ""
                },
                new GeographicLocale
                {
                    GeographicLocaleId = 2,
                    GeographicLocaleTypeId = 1,
                    ParentGeographicLocaleId = 3,
                    LocaleName = "Local Name 1",
                    LocaleAbbreviation = "Local Abbreviation 1"
                },
                new GeographicLocale
                {
                    GeographicLocaleId = 3,
                    GeographicLocaleTypeId = 1,
                    ParentGeographicLocaleId = 3,
                    LocaleName = "Local Name 1",
                    LocaleAbbreviation = "Local Abbreviation 1"
                }
            );
        }

        private static void LoadFileReferences(ApplicationDbContext context)
        {
            context.FileReference.AddRange
            (
                new FileReference
                {
                    FileReferenceId = 1,
                    Name = "fileReference 1",
                    WorkerId = "worker 1",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    DefaultGeographicLocaleId = 1,
                    IsTemporaryFile = 1,
                    FileStatus = context.FileStatus.Find(1),
                    BranchLocation = context.BranchLocation.Find(1),
                    DefaultGeographicLocale = context.GeographicLocale.Find(1)
                },
                new FileReference
                {
                    FileReferenceId = 2,
                    Name = "fileReference 2",
                    WorkerId = "worker 2",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    DefaultGeographicLocaleId = 1,
                    IsTemporaryFile = 1,
                    FileStatus = context.FileStatus.Find(2),
                    BranchLocation = context.BranchLocation.Find(2),
                    DefaultGeographicLocale = context.GeographicLocale.Find(1)
                },
                new FileReference
                {
                    FileReferenceId = 3,
                    Name = "fileReference 3",
                    WorkerId = "worker 3",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    DefaultGeographicLocaleId = 1,
                    IsTemporaryFile = 1,
                    FileStatus = context.FileStatus.Find(3),
                    BranchLocation = context.BranchLocation.Find(3),
                    DefaultGeographicLocale = context.GeographicLocale.Find(1)
                },
                new FileReference
                {
                    FileReferenceId = 4,
                    Name = "fileReference 4",
                    WorkerId = "worker 4",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    DefaultGeographicLocaleId = 1,
                    IsTemporaryFile = 1,
                    FileStatus = context.FileStatus.Find(4),
                    BranchLocation = context.BranchLocation.Find(4),
                    DefaultGeographicLocale = context.GeographicLocale.Find(2)
                },
                new FileReference
                {
                    FileReferenceId = 5,
                    Name = "fileReference 5",
                    WorkerId = "worker 5",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    DefaultGeographicLocaleId = 1,
                    IsTemporaryFile = 1,
                    FileStatus = context.FileStatus.Find(5),
                    BranchLocation = context.BranchLocation.Find(5),
                    DefaultGeographicLocale = context.GeographicLocale.Find(1)
                },
                new FileReference
                {
                    FileReferenceId = 6,
                    Name = "fileReference 6",
                    WorkerId = "worker 6",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    DefaultGeographicLocaleId = 1,
                    IsTemporaryFile = 1,
                    FileStatus = context.FileStatus.Find(6),
                    BranchLocation = context.BranchLocation.Find(6),
                    DefaultGeographicLocale = context.GeographicLocale.Find(3)
                }
            );
        }

        private static void LoadBranchLocations(ApplicationDbContext context)
        {
            context.BranchLocation.AddRange
            (
                new BranchLocation
                {
                    BranchLocationId = 1,
                    AccountNumber = "1",
                    Description = "Branch 1",
                    IsInternal = 1
                },
                new BranchLocation
                {
                    BranchLocationId = 2,
                    AccountNumber = "2",
                    Description = "Branch 2",
                    IsInternal = 1
                },
                new BranchLocation
                {
                    BranchLocationId = 3,
                    AccountNumber = "3",
                    Description = "Branch 3",
                    IsInternal = 1
                },
                new BranchLocation
                {
                    BranchLocationId = 4,
                    AccountNumber = "4",
                    Description = "Branch 4",
                    IsInternal = 1
                },
                new BranchLocation
                {
                    BranchLocationId = 5,
                    AccountNumber = "5",
                    Description = "Branch 5",
                    IsInternal = 1
                },
                new BranchLocation
                {
                    BranchLocationId = 6,
                    AccountNumber = "6",
                    Description = "Branch 6",
                    IsInternal = 1
                }
            );
        }

        private static void LoadFileStatuses(ApplicationDbContext context)
        {
            context.FileStatus.AddRange
            (
                new FileStatus 
                {
                    FileStatusId = 1,
                    Description = "Description 1"
                },
                new FileStatus
                {
                    FileStatusId = 2,
                    Description = "Description 2"
                },
                new FileStatus
                {
                    FileStatusId = 3,
                    Description = "Description 3"
                },
                new FileStatus
                {
                    FileStatusId = 4,
                    Description = "Description 4"
                },
                new FileStatus
                {
                    FileStatusId = 5,
                    Description = "Description 5"
                },
                new FileStatus
                {
                    FileStatusId = 6,
                    Description = "Description 6"
                }
            );
        }
    }
}
