using HotChocolate.DataLoader;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TheFund.AtidsXe.Data.Context;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.GraphQL.Server.DataLoaders
{
    public class FileReferenceByIdDataLoader : BatchDataLoader<int, FileReference>
    {
        private readonly ATIDSXEContext _context;

        public FileReferenceByIdDataLoader(ATIDSXEContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        protected override async Task<IReadOnlyDictionary<int, FileReference>> LoadBatchAsync(
            IReadOnlyList<int> keys,
            CancellationToken cancellationToken)
        {
            return await _context.FileReference.Where(s => keys.Contains(s.FileReferenceId))
                                               .Include(p => p.Worksheet)
                                               .ThenInclude(p => p.WorksheetItem)
                                               .Include(p => p.BranchLocation)
                                               .Include(p => p.FileStatus)
                                               .Include(p => p.DefaultGeographicLocale)
                                               .ToDictionaryAsync(t => t.FileReferenceId, cancellationToken);
        }
    }
}
