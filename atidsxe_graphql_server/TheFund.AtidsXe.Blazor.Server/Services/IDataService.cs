using Optional;
using System.Threading;
using System.Threading.Tasks;
using TheFund.AtidsXe.Blazor.Server.Models.Requests;
using TheFund.AtidsXe.Blazor.Server.Models.Responses;

namespace TheFund.AtidsXe.Blazor.Server.Services
{
    public interface IDataService
    {
        Task<Option<SearchResponse>> GetSearchAsync(SearchRequest request, CancellationToken token = default);
        object InvalidateCachedItem(object key);
    }
}
