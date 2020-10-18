using DynamicData;
using System;

namespace TheFund.AtidsXe.Services
{
    public class GraphQLService : IGraphQLService
    {

    }

    public interface IGraphQLService
    {

    }

    public class CachingService : ICachingService
    {
        private readonly SourceCache<ChainOfTitleCategoryType, int> _cache;

        public IObservable<IChangeSet<ChainOfTitleCategoryType, int>> Connect() => _cache.Connect();

        public CachingService()
        {
            _cache = new SourceCache<ChainOfTitleCategoryType, int>(p => p.ChainOfTitleCategoryId);
        }

        public void AddOrUpdate(params ChainOfTitleCategoryType[] fileReferences)
        {
            _cache.AddOrUpdate(fileReferences);
        }
    }

    public interface ICachingService
    {
        void AddOrUpdate(params ChainOfTitleCategoryType[] fileReferences);
        IObservable<IChangeSet<ChainOfTitleCategoryType, int>> Connect();
    }


    public class RootObject
    {
        public Data Data { get; set; }
    }

    public class Data
    {
        public ChainOfTitleCategoryType[] ChainOfTitleCategoryTypes { get; set; }
    }

    public class ChainOfTitleCategoryType
    {
        public int ChainOfTitleCategoryId { get; set; }
        public string Description { get; set; }
    }

}
