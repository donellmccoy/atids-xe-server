using GraphQL;
using System.Threading;
using System.Threading.Tasks;
using TheFund.AtidsXe.Console.DataTransferObjects;

namespace TheFund.AtidsXe.Console
{
    public interface IGraphQLService
    {
        Task<GraphQLResponse<FileReferencesResponse>> GetFileReferencesResponse(string searchTerm, int pageSize, CancellationToken token = default);
        Task<GraphQLResponse<FileReferencesResponse>> GetFileReferenceAsync(int fileReferenceId, PagingOptions pagingOptions, CancellationToken token = default);
        Task<GraphQLResponse<ChainOfTitleResponse>> GetChainOfTitleAsync(int fileReferenceId, int chainOfTitleId, PagingOptions pagingOptions, CancellationToken token = default);
        Task<GraphQLResponse<SearchResponse>> GetSearchAsync(int fileReferenceId, int searchId, PagingOptions pagingOptions, CancellationToken token = default);
        Task<GraphQLResponse<WorksheetResponse>> GetWorksheetAsync(int fileReferenceId, int worksheetId, PagingOptions pagingOptions, CancellationToken token = default);
    }
}
