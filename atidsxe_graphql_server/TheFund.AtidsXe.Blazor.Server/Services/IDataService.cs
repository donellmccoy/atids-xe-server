using System.Threading.Tasks;
using TheFund.AtidsXe.Blazor.Server.Models.Requests;
using TheFund.AtidsXe.Blazor.Server.Models.Responses;

namespace TheFund.AtidsXe.Console
{
    public interface IDataService
    {
        Task<SearchResponse> GetSearchAsync(SearchRequest request);
    }
}
