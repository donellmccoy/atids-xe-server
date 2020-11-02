using GraphQL;
using GraphQL.Client.Http;
using System.Threading;
using System.Threading.Tasks;
using TheFund.AtidsXe.Blazor.Server.Factories;

namespace TheFund.AtidsXe.Blazor.Server.Extensions
{
    public static class GraphQLClientExtensions
    {
        public static async Task<GraphQLResponse<TResponse>> SendQueryAsync<TResponse>(this GraphQLHttpClient client, CancellationToken token = default, string query = null, string operationName = null, params(string, int)[] variables)
        {
            return await client.SendQueryAsync<TResponse>(GraphQLRequestFactory.Create(query, operationName, variables), token).ConfigureAwait(true);
        }

        public static async Task<GraphQLResponse<TResponse>> SendMutationAsync<TResponse>(this GraphQLHttpClient client, CancellationToken token = default, string query = null, string operationName = null, params (string, int)[] variables)
        {
            return await client.SendMutationAsync<TResponse>(GraphQLRequestFactory.Create(query, operationName, variables), token).ConfigureAwait(true);
        }
    }
}
