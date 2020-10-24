using System;
using System.Threading.Tasks;
using TheFund.AtidsXe.Blazor.Server.Models.Requests;
using TheFund.AtidsXe.Blazor.Server.Models.Responses;
using TheFund.AtidsXe.Blazor.Server.Utility;

namespace TheFund.AtidsXe.Console
{
    public class DataService : IDataService
    {
        private readonly IGraphQLService _graphQLService;
        private readonly ITaskCache _cache;

        public DataService(IGraphQLService graphQLService, ITaskCache cache)
        {
            _graphQLService = graphQLService;
            _cache = cache;
        }

        public async Task<SearchResponse> GetSearchAsync(SearchRequest request)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var result = await _cache.AddOrGetExistingAsync
            (
                request.Key,
                () =>
                {
                    return _graphQLService.GetSearchAsync(request.FileReferenceId, request.SearchId, request.PagingOptions);
                }
            );

            return result.Data;
        }

        public async Task<FileReferencesResponse> GetFileReferenceAsync(FileReferencesRequest request)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var result = await _cache.AddOrGetExistingAsync
            (
                request.Key,
                () =>
                {
                    return _graphQLService.GetFileReferenceAsync(request.FileReferenceId, request.PagingOptions);
                }
            );

            return result.Data;
        }

        public async Task<ChainOfTitleResponse> GetChainOfTitleAsync(ChainOfTitleRequest request)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var result = await _cache.AddOrGetExistingAsync
            (
                request.Key,
                () =>
                {
                    return _graphQLService.GetChainOfTitleAsync(request.FileReferenceId, request.ChainOfTitleId, request.PagingOptions);
                }
            );

            return result.Data;
        }

        public async Task<WorksheetResponse> GetWorksheetAsync(WorksheetRequest request)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var result = await _cache.AddOrGetExistingAsync
            (
                request.Key,
                () =>
                {
                    return _graphQLService.GetWorksheetAsync(request.FileReferenceId, request.WorksheetId, request.PagingOptions);
                }
            );

            return result.Data;
        }
    }
}
