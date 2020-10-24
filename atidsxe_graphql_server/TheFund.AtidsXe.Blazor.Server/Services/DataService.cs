using DynamicData.Kernel;
using GraphQL;
using GraphQL.Client.Http;
using Optional;
using System;
using System.Threading;
using System.Threading.Tasks;
using TheFund.AtidsXe.Blazor.Server.Models.Requests;
using TheFund.AtidsXe.Blazor.Server.Models.Responses;
using TheFund.AtidsXe.Blazor.Server.Utility;

namespace TheFund.AtidsXe.Blazor.Server.Services
{
    public sealed class DataService : IDataService
    {
        #region Fields

        private readonly IGraphQLService _graphQLService;
        private readonly ITaskCache _cache;

        #endregion

        #region Constructors

        public DataService(IGraphQLService graphQLService, ITaskCache cache)
        {
            _graphQLService = graphQLService ?? throw new ArgumentNullException(nameof(graphQLService));
            _cache = cache ?? throw new ArgumentNullException(nameof(cache));
        }

        #endregion

        #region Search

        public async Task<Option<SearchResponse>> GetSearchAsync(SearchRequest request, CancellationToken token = default)
        {
            if (request is null)
            {
                return Option.None<SearchResponse>();
            }

            var result = await _cache.GetOrCreateAsync
            (
                request.CacheKey, 
                () => _graphQLService.GetSearchAsync(request.PagingOptions, token, request.Variables)
            );

            return result.Data.SomeNotNull();
        }

        #endregion

        #region FileReference

        public async Task<FileReferencesResponse> GetFileReferenceAsync(FileReferencesRequest request)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var result = await _cache.GetOrCreateAsync(request.Key, () => _graphQLService.GetFileReferenceAsync(request.FileReferenceId, request.PagingOptions));

            return result?.Data;
        }

        #endregion

        #region ChainOfTitle

        public async Task<ChainOfTitleResponse> GetChainOfTitleAsync(ChainOfTitleRequest request)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var result = await _cache.GetOrCreateAsync(request.Key, () => _graphQLService.GetChainOfTitleAsync(request.FileReferenceId, request.ChainOfTitleId, request.PagingOptions));

            return result?.Data;
        }

        #endregion

        #region Worksheet

        public async Task<WorksheetResponse> GetWorksheetAsync(WorksheetRequest request)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var result = await _cache.GetOrCreateAsync(request.Key, () => _graphQLService.GetWorksheetAsync(request.FileReferenceId, request.WorksheetId, request.PagingOptions));

            return result?.Data;
        }

        #endregion

        #region Policy
        #endregion

        public object InvalidateCachedItem(object key)
        {
            if (key is null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            _cache.Invalidate(key);

            return key;
        }
    }
}
