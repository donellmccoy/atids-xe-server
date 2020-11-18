using JetBrains.Annotations;
using Optional;
using System;
using System.Linq;
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

        public DataService([NotNull] IGraphQLService graphQLService, ITaskCache cache)
        {
            _graphQLService = graphQLService ?? throw new ArgumentNullException(nameof(graphQLService));
            _cache = cache ?? throw new ArgumentNullException(nameof(cache));
        }

        #endregion

        #region General

        public async Task<Option<IResponse>> GetResponseAsync([NotNull] IRequest request, CancellationToken token = default)
        {
            if (request is null)
            {
                return Option.None<IResponse>();
            }

            var response = await _cache.GetOrCreateAsync(request.CacheKey, () =>
            {
                return _graphQLService.SendQueryAsync<IResponse>(request, token);
            });

            if (response.Errors?.Any() == true)
            {
                return Option.None<IResponse>();
            }

            return response.Data.SomeNotNull();
        }

        #endregion

        #region Search

        public async Task<Option<SearchResponse>> GetSearchAsync([NotNull] SearchRequest request, CancellationToken token = default)
        {
            if (request is null)
            {
                return Option.None<SearchResponse>();
            }

            var response = await _cache.GetOrCreateAsync(request.CacheKey, () =>
            {
                return _graphQLService.SendQueryAsync<SearchResponse>(request, token);
            });

            if(response.Errors?.Any() == true)
            {
                return Option.None<SearchResponse>();
            }

            return response.Data.SomeNotNull();
        }

        #endregion

        #region FileReference

        public async Task<Option<FileReferencesResponse>> GetFileReferenceAsync([NotNull] FileReferencesRequest request, CancellationToken token = default)
        {
            if (request is null)
            {
                return Option.None<FileReferencesResponse>();
            }

            var response = await _cache.GetOrCreateAsync(request.CacheKey, () =>
            {
                return _graphQLService.SendQueryAsync<FileReferencesResponse>(request, token);
            });

            if (response.Errors?.Any() == true)
            {
                return Option.None<FileReferencesResponse>();
            }

            return response.Data.SomeNotNull();
        }

        #endregion

        #region ChainOfTitle

        public async Task<Option<ChainOfTitleResponse>> GetChainOfTitleAsync([NotNull] ChainOfTitleRequest request, CancellationToken token = default)
        {
            if (request is null)
            {
                return Option.None<ChainOfTitleResponse>();
            }

            var response = await _cache.GetOrCreateAsync(request.CacheKey, () =>
            {
                return _graphQLService.SendQueryAsync<ChainOfTitleResponse>(request, token);
            });

            if (response.Errors?.Any() == true)
            {
                return Option.None<ChainOfTitleResponse>();
            }

            return response.Data.SomeNotNull();
        }

        #endregion

        #region Worksheet

        public async Task<Option<WorksheetResponse>> GetWorksheetAsync([NotNull] WorksheetRequest request, CancellationToken token = default)
        {
            if (request is null)
            {
                return Option.None<WorksheetResponse>();
            }

            var response = await _cache.GetOrCreateAsync(request.CacheKey, () =>
            {
                return _graphQLService.SendQueryAsync<WorksheetResponse>(request, token);
            });

            if (response.Errors?.Any() == true)
            {
                return Option.None<WorksheetResponse>();
            }

            return response.Data.SomeNotNull();
        }

        #endregion

        #region Policy

        public async Task<Option<WorksheetResponse>> GetPolicyAsync([NotNull] WorksheetRequest request, CancellationToken token = default)
        {
            if (request is null)
            {
                return Option.None<WorksheetResponse>();
            }

            var response = await _cache.GetOrCreateAsync(request.CacheKey, () =>
            {
                return _graphQLService.SendQueryAsync<WorksheetResponse>(request, token);
            });

            if (response.Errors?.Any() == true)
            {
                return Option.None<WorksheetResponse>();
            }

            return response.Data.SomeNotNull();
        }

        #endregion

        #region Helpers

        public object InvalidateCachedItem([NotNull] object key)
        {
            if (key is null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            _cache.Invalidate(key);

            return key;
        }

        #endregion
    }
}
