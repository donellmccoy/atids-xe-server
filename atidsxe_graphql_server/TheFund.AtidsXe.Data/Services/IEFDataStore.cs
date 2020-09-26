using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TheFund.AtidsXe.Data.Services
{
    public interface IEFDataStore
    {
        Task<IEnumerable<TEntity>> GetEntitiesAsync<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;
    }
}