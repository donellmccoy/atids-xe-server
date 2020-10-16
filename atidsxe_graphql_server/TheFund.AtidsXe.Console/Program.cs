using DynamicData;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace TheFund.AtidsXe.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<ICachingService, CachingService>();
            var provider = serviceCollection.BuildServiceProvider();
            var cachingService = provider.GetRequiredService<ICachingService>();

            var client = new GraphQLHttpClient("http://localhost:5002/graphql", new NewtonsoftJsonSerializer());

            var request = new GraphQLRequest
            {
                Query = CreateFileReferenceQuery(searchTerm: "dap", first: 25),
                OperationName = "FileReferences"
            };

            var response = await client.SendQueryAsync<FileReferenceResponse>(request);

            var fileReferences = response.Data.FileReferenceResult.FileReferences;

            cachingService.Connect().Subscribe(p =>
            {

            });

            cachingService.AddOrUpdate(fileReferences.ToArray());

            System.Console.ReadLine();
        }

        private static string CreateFileReferenceQuery(string searchTerm, int first, string after = null)
        {
            return "query FileReferences "
                   + "{ fileReferenceResult: fileReferences (" + CreateInput(searchTerm, first, after) + ") "
                   + "{ totalCount pageInfo {  ...pageInfoFields } "
                   + "fileReferences: nodes { name fileReferenceId defaultGeographicLocaleId branchLocationId fileStatusId createDate updateDate workerId isTemporaryFile "
                   + "titleSearchOrigination { titleEventId titleSearchOriginationId orderDate orderReference fileReferenceId "
                   + "}}}} " +
                   "fragment pageInfoFields on PageInfo { startCursor endCursor hasPreviousPage hasNextPage }";
        }

        private static string CreateInput(string searchTerm, int first, string after = null)
        {
            return " first:" + $"{first}," + CreateAfterSection(after) + "where: { name_contains:" + '"' + $"{searchTerm}" + '"' + "}";
        }

        private static string CreateAfterSection(string after = null)
        {
            var afterSection = string.Empty;

            if (!string.IsNullOrWhiteSpace(after))
            {
                afterSection = "after:" + '"' + $"{after}" + '"' + ",";
            }

            return afterSection;
        }
    }

    public class CachingService : ICachingService
    {
        private readonly SourceCache<FileReference, int> _cache;

        public IObservable<IChangeSet<FileReference, int>> Connect() => _cache.Connect();

        public CachingService()
        {
            _cache = new SourceCache<FileReference, int>(p => p.FileReferenceId);
        }

        public void AddOrUpdate(params FileReference[] fileReferences)
        {
            _cache.AddOrUpdate(fileReferences);
        }
    }

    public interface ICachingService
    {
        void AddOrUpdate(params FileReference[] fileReferences);
        IObservable<IChangeSet<FileReference, int>> Connect();
    }
}
