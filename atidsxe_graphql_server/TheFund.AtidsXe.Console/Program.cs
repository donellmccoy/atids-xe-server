using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TheFund.AtidsXe.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var graphQLClient = new GraphQLHttpClient("http://localhost:5002/graphql", new NewtonsoftJsonSerializer());

            var request = new GraphQLRequest
            {
                Query = CreateFileReferenceQuery(searchTerm: "dap", first: 25, after: "OQ=="),
                OperationName = "FileReferences"
            };

            var response = await graphQLClient.SendQueryAsync<FileReferenceResponse>(request);

            var fileReferences = response.Data.FileReferenceResult.FileReferences;
            
        }

        private static string CreateFileReferenceQuery(string searchTerm, int first, string after = null)
        {
            return "query FileReferences " 
                   + "{ fileReferenceResult: fileReferences (" + CreateInput(searchTerm, first, after) + ") "
                   + "{ totalCount pageInfo {  ...pageInfoFields } "
                   + "fileReferences: nodes { name fileReferenceId defaultGeographicLocaleId branchLocationId fileStatusId createDate updateDate workerId isTemporaryFile "
                   + "titleSearchOrigination { titleEventId titleSearchOriginationId orderDate orderReference fileReferenceId "
                   + "chainOfTitlesResult: chainOfTitles(first: 25) {   }}}} ";
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

    public class FileReferenceResponse
    {
        public FileReferenceResponse()
        {

        }

        public FileReferenceResult FileReferenceResult { get; set; }
    }

    public class FileReferenceResult
    {
        public FileReferenceResult()
        {
            FileReferences = new List<FileReference>();
        }

        public int TotalCount { get; set; }

        public PageInfo PageInfo { get; set; }

        public List<FileReference> FileReferences { get; set; }
    }

    public class FileReference
    {
        public string Name { get; set; }

        public int FileReferenceId { get; set; }

        public int BranchLocationId { get; set; }

        public int FileStatusId { get; set; }

        public string WorkerId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public int? DefaultGeographicLocaleId { get; set; }

        public byte? IsTemporaryFile { get; set; }

        public TitleSearchOrigination TitleSearchOrigination { get; set; }


    }



    public class Connection<T> : IConnection<T> where T: class
    {
        public Connection(
            int totalCount,
            IPageInfo pageInfo,
            IReadOnlyList<T> nodes)
        {
            TotalCount = totalCount;
            PageInfo = pageInfo;
            Nodes = nodes;
        }

        public int TotalCount { get; }

        public IPageInfo PageInfo { get; }

        public IReadOnlyList<T> Nodes { get; }
    }

    public interface IConnection<T> 
    {
        int TotalCount { get; }

        IPageInfo PageInfo { get; }

        IReadOnlyList<T> Nodes { get; }
    }
}
