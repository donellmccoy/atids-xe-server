using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TheFund.AtidsXe.Data.Context;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Services
{
    public class EFDataStore : IEFDataStore
    {
        private readonly ApplicationDbContext _context;

        public EFDataStore(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TEntity>> GetEntitiesAsync<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class
        {
            if (predicate == null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            IEnumerable<TEntity> entities;

            entities = await _context.Set<TEntity>().Where(predicate).ToListAsync();

            return entities;
        }
    }
}
