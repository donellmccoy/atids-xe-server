using GraphQL;
using System.Threading;
using System.Threading.Tasks;
using TheFund.AtidsXe.Blazor.Server.Models.Requests;
using TheFund.AtidsXe.Blazor.Server.Models.Responses;

namespace TheFund.AtidsXe.Blazor.Server.Services
{
    public interface IGraphQLService
    {
        Task<GraphQLResponse<TResponse>> SendQueryAsync<TResponse>(IRequest request, CancellationToken token = default);
    }
}
