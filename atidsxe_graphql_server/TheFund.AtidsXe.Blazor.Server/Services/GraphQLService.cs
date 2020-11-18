using Ensure;
using GraphQL;
using GraphQL.Client.Http;
using Microsoft.Extensions.Options;
using System.Threading;
using System.Threading.Tasks;
using TheFund.AtidsXe.Blazor.Server.Factories;
using TheFund.AtidsXe.Blazor.Server.Models.Requests;
using TheFund.AtidsXe.Blazor.Server.Options;

namespace TheFund.AtidsXe.Blazor.Server.Services
{
    public sealed class GraphQLService : IGraphQLService
    {
        private readonly GraphQLHttpClient _client;

        public GraphQLService(IOptions<GraphQLServiceOptions> options)
        {
            options.EnsureNotNull();
            _client = GraphQLClientFactory.Create(options.Value);
        }

        public async Task<GraphQLResponse<TResponse>> SendQueryAsync<TResponse>(IRequest request, CancellationToken token = default)
        {
            request.EnsureNotNull();
            return await _client.SendQueryAsync<TResponse>(GraphQLRequestFactory.Create(request.Query, request.OperationName, request.Variables), token).ConfigureAwait(true);
        }

        public async Task<GraphQLResponse<TResponse>> SendMutationAsync<TResponse>(IRequest request, CancellationToken token = default)
        {
            request.EnsureNotNull();
            return await _client.SendMutationAsync<TResponse>(GraphQLRequestFactory.Create(request.Query, request.OperationName, request.Variables), token).ConfigureAwait(true);
        }
    }
}
