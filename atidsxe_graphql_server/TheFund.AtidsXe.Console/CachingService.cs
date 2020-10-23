using DynamicData;
using GraphQL;
using System;
using System.Collections.Generic;
using TheFund.AtidsXe.Console.DataTransferObjects;

namespace TheFund.AtidsXe.Console
{
    public class CachingService : ICachingService
    {
        private readonly SourceCache<FileReference, int> _fileReferenceCache = new SourceCache<FileReference, int>(p => p.FileReferenceId);
        private Dictionary<string, SourceCache<DtoBase, int>> _cacheDictionary;

        public IObservable<IChangeSet<FileReference, int>> Connect()
        {
            return _fileReferenceCache.Connect();
        }

        public CachingService()
        {
        }

        public void RemoveItem(int key)
        {
            _fileReferenceCache.Remove(key);
        }

        public void AddOrUpdate(FileReference entity)
        {
            _fileReferenceCache.AddOrUpdate(entity);
        }

        public void AddOrUpdate(IEnumerable<FileReference> entities)
        {
            _fileReferenceCache.AddOrUpdate(entities);
        }
    }
}
