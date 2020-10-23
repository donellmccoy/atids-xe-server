using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using System.Threading;
using System.Threading.Tasks;
using TheFund.AtidsXe.Blazor.Server.Models;
using TheFund.AtidsXe.Blazor.Server.Models.Responses;

namespace TheFund.AtidsXe.Console
{
    public class GraphQLService : IGraphQLService
    {
        public async Task<GraphQLResponse<SearchResponse>> GetSearchAsync(int fileReferenceId, int searchId, PagingOptions pagingOptions, CancellationToken token)
        {
            using var client = new GraphQLHttpClient("http://localhost:5002/api/v1/graphql", new NewtonsoftJsonSerializer());

            var request = new GraphQLRequest
            {
                Query = "query Search($fileReferenceId:Int!,$searchId:Int!){search(fileReferenceId:$fileReferenceId,searchId:$searchId){__typename searchId fileReferenceId searchTypeId searchThruDate searchFromDate searchStatusId geographicLocaleId geographicCertRangeId geographicLocaleId parentSearchId instrumentFilters lrsSearch inclMortgageeShortForm hidden geographicLocale{__typename geographicLocaleId geographicLocaleTypeId localeName localeAbbreviation parentGeographicLocaleId}geographicCertRange{__typename certificationRangeId fromDate fromOrDocumentId toDate toOrDocumentId}giCertRange{__typename certificationRangeId fromDate fromOrDocumentId toDate toOrDocumentId}grantorCertRange{__typename certificationRangeId fromDate fromOrDocumentId toDate toOrDocumentId}parentSearch{__typename searchId fileReferenceId}inverseParentSearches{__typename searchId}titleEventSearches{__typename totalCount pageInfo{...pageInfoFields}nodes{searchId titleEventId titleEvent{__typename titleEventId additionalInformation amount createDate currentExamStatusTypeId originalExamStatusTypeId tag titleEventDate titleEventTypeId}}}}}fragment pageInfoFields on PageInfo{startCursor endCursor hasPreviousPage hasNextPage}",
                OperationName = "Search",
                Variables = new { fileReferenceId, searchId },
            };

            var response = await client.SendQueryAsync<SearchResponse>(request, token).ConfigureAwait(true);

            return response;
        }

        public async Task<GraphQLResponse<FileReferencesResponse>> GetFileReferenceAsync(int fileReferenceId, PagingOptions pagingOptions, CancellationToken token = default)
        {
            return await Task.FromResult<GraphQLResponse<FileReferencesResponse>>(null).ConfigureAwait(true);
        }

        public async Task<GraphQLResponse<ChainOfTitleResponse>> GetChainOfTitleAsync(int fileReferenceId, int chainOfTitleId, PagingOptions pagingOptions, CancellationToken token = default)
        {
            return await Task.FromResult<GraphQLResponse<ChainOfTitleResponse>>(null).ConfigureAwait(true);
        }


        public async Task<GraphQLResponse<WorksheetResponse>> GetWorksheetAsync(int fileReferenceId, int worksheetId, PagingOptions pagingOptions, CancellationToken token = default)
        {
            return await Task.FromResult<GraphQLResponse<WorksheetResponse>>(null).ConfigureAwait(true);
        }

        //public async Task<GraphQLResponse<FileReferencesResponse>> GetFileReferencesResponse(string searchTerm, int pageSize, CancellationToken token = default)
        //{
        //    using var client = new GraphQLHttpClient("http://localhost:5002/api/v1/graphql", new NewtonsoftJsonSerializer());

        //    var request = CreateFileReferencesRequest(new SearchOptions { SearchTerm = searchTerm }, new PagingOptions { PageSize = pageSize });

        //    var response = await client.SendQueryAsync<FileReferencesResponse>(request);

        //    return response;
        //}

        //private static GraphQLRequest CreateFileReferencesRequest(string searchTerm, int pageSize)
        //{
        //    return new GraphQLRequest
        //    {
        //        Query = GetFileReferenceQueryString(),
        //        OperationName = "FileReferences",
        //        Variables = new { searchTerm, pageSize },
        //    };
        //}

        //private static GraphQLRequest CreateFileReferencesRequest(SearchOptions searchOptions, PagingOptions pagingOptions)
        //{
        //    return new GraphQLRequest
        //    {
        //        Query = GetFileReferenceQueryString(),
        //        OperationName = "FileReferences",
        //        Variables = new { searchTerm = searchOptions.SearchTerm, pageSize = pagingOptions.PageSize },
        //    };
        //}

        //private static string GetFileReferenceQueryString()
        //{
        //    return "query FileReferences($searchTerm:String!,$pageSize:PaginationAmount!){fileReferencesConnection:fileReferences(first:$pageSize where:{name_contains:$searchTerm}){__typename totalCount pageInfo{...pageInfoFields}nodes{__typename fileReferenceId name defaultGeographicLocaleId branchLocationId fileStatusId createDate updateDate workerId isTemporaryFile titleSearchOrigination{titleEventId titleSearchOriginationId orderDate orderReference fileReferenceId}chainOfTitlesConnection:chainOfTitles{__typename totalCount pageInfo{...pageInfoFields}nodes{__typename chainOfTitleId fileReferenceId}}fileReferenceNotesConnection:fileReferenceNotes{__typename totalCount pageInfo{...pageInfoFields}fileReferenceNotes:nodes{__typename fileReferenceId fileReferenceNotesId message userId timeStamp}}worksheet{__typename worksheetId fileReferenceId worksheetItemsConnection:worksheetItems{totalCount pageInfo{...pageInfoFields}nodes{__typename titleEventId worksheetId sequence}}}searchesConnection:searches{__typename totalCount pageInfo{...pageInfoFields}nodes{__typename searchId fileReferenceId searchTypeId searchThruDate searchFromDate searchStatusId geographicLocaleId geographicCertRangeId geographicLocaleId parentSearchId instrumentFilters lrsSearch inclMortgageeShortForm hidden}}}}}fragment pageInfoFields on PageInfo{__typename startCursor endCursor hasPreviousPage hasNextPage}";
        //}

    }
}
