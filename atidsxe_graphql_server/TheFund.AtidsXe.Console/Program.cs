using DynamicData;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Text.Json;
using System.Threading.Tasks;

namespace TheFund.AtidsXe.Console
{
    public class Program
    {
        private static ReadOnlyObservableCollection<FileReference> _list;

        private static async Task Main()
        {
            var response = await GetFileReferencesResponse("don", 50);

            var fileReferences = response.Data.FileReferencesConnection.FileReferences;

            var fileReferencesCache = new SourceCache<FileReference, int>(p => p.FileReferenceId);

            fileReferencesCache.Edit(innerCache =>
            {
                innerCache.Clear();
                innerCache.AddOrUpdate(fileReferences);
            });

            var fileReferenceOperation = fileReferencesCache.Connect()
                                                            .Filter(p => p.FileStatusId == 3)
                                                            .Bind(out _list)
                                                            .DisposeMany()
                                                            .Subscribe(o => 
                                                            {
                                                                
                                                            });

            System.Console.WriteLine("raw response:");
            System.Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(response, new JsonSerializerOptions { WriteIndented = true }));
            System.Console.ReadLine();
        }

        private static async Task<GraphQLResponse<FileReferencesResponse>> GetFileReferencesResponse(string searchTerm, int pageSize)
        {
            using var client = new GraphQLHttpClient("http://localhost:5002/api/v1/graphql", new NewtonsoftJsonSerializer());
            var request = CreateFileReferencesRequest(new SearchOptions { SearchTerm = searchTerm }, new PagingOptions { PageSize = pageSize });
            var response = await client.SendQueryAsync<FileReferencesResponse>(request);

            return response;
        }

        private static GraphQLRequest CreateFileReferencesRequest(string searchTerm, int pageSize)
        {
            return new GraphQLRequest
            {
                Query = GetFileReferenceQueryString(),
                OperationName = "FileReferences",
                Variables = new { searchTerm, pageSize },
            };
        }

        private static GraphQLRequest CreateFileReferencesRequest(SearchOptions searchOptions, PagingOptions pagingOptions)
        {
            return new GraphQLRequest
            {
                Query = GetFileReferenceQueryString(),
                OperationName = "FileReferences",
                Variables = new { searchTerm = searchOptions.SearchTerm, pageSize = pagingOptions.PageSize },
            };
        }

        private static string GetFileReferenceQueryString()
        {
            return "query FileReferences($searchTerm:String!,$pageSize:PaginationAmount!){fileReferencesConnection:fileReferences(first:$pageSize where:{name_contains:$searchTerm}){__typename totalCount pageInfo{...pageInfoFields}fileReferences:nodes{__typename fileReferenceId name defaultGeographicLocaleId branchLocationId fileStatusId createDate updateDate workerId isTemporaryFile titleSearchOrigination{titleEventId titleSearchOriginationId orderDate orderReference fileReferenceId}chainOfTitlesConnection:chainOfTitles{__typename totalCount pageInfo{...pageInfoFields}chainOfTitles:nodes{__typename chainOfTitleId fileReferenceId}}fileReferenceNotesConnection:fileReferenceNotes{__typename totalCount pageInfo{...pageInfoFields}fileReferenceNotes:nodes{__typename fileReferenceId fileReferenceNotesId message userId timeStamp}}worksheet{__typename worksheetId fileReferenceId worksheetItemsConnection:worksheetItems{totalCount pageInfo{...pageInfoFields}worksheetItems:nodes{__typename titleEventId worksheetId sequence}}}searchesConnection:searches{__typename totalCount pageInfo{...pageInfoFields}searches:nodes{__typename searchId fileReferenceId searchTypeId searchThruDate searchFromDate searchStatusId geographicLocaleId geographicCertRangeId geographicLocaleId parentSearchId instrumentFilters lrsSearch inclMortgageeShortForm hidden}}}}}fragment pageInfoFields on PageInfo{__typename startCursor endCursor hasPreviousPage hasNextPage}";
        }
    }



    public class SearchOptions
    {
        public string SearchTerm { get; set; }
    }

    public class PagingOptions
    {
        public int PageSize { get; set; }
    }


}
