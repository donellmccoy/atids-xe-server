﻿using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace TheFund.AtidsXe.Blazor.Server.Utility
{
    public sealed class TaskCache : ITaskCache
    {
        private readonly IMemoryCache _cache;
        private ConcurrentDictionary<object, SemaphoreSlim> _locks = new ConcurrentDictionary<object, SemaphoreSlim>();

        public TaskCache(IMemoryCache cache)
        {
            _cache = cache;
        }

        public async Task<TCacheItem> GetOrCreateAsync<TCacheItem>(object key, Func<Task<TCacheItem>> valueFactory)
        {
            if (key is null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (valueFactory is null)
            {
                throw new ArgumentNullException(nameof(valueFactory));
            }

            var asyncLazyValue = CreateAsyncLazy(valueFactory);

            var existingAsyncLazyValue = _cache.GetOrCreate(key, entry => asyncLazyValue);

            if (existingAsyncLazyValue != null)
            {
                asyncLazyValue = existingAsyncLazyValue;
            }

            try
            {
                var result = await asyncLazyValue;

                // The awaited Task has completed. Check that the task is still the same version
                // that the cache returns (i.e. the awaited task has not been invalidated during the await).
                if (asyncLazyValue != _cache.GetOrCreate(key, entry => CreateAsyncLazy(valueFactory)))
                {
                    // The awaited value is not the most recent one,
                    // therefore, get the most recent value with a recursive call.
                    return await GetOrCreateAsync(key, valueFactory);
                }

                return result;
            }
            catch (Exception)
            {
                _cache.Remove(key);
                throw;
            }
        }

        private AsyncLazy<TCacheItem> CreateAsyncLazy<TCacheItem>(Func<Task<TCacheItem>> valueFactory)
        {
            if (valueFactory is null)
            {
                throw new ArgumentNullException(nameof(valueFactory));
            }

            return new AsyncLazy<TCacheItem>(valueFactory);
        }

        public void Invalidate(object key)
        {
            if (key is null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            _cache.Remove(key);
        }

        public bool Contains(object key)
        {
            if (key is null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            return _cache.TryGetValue(key, out var _);
        }
    }
}
