using System;
using System.Threading.Tasks;
using TheFund.AtidsXe.Console.DataTransferObjects;

namespace TheFund.AtidsXe.Console
{
    public interface IDataService
    {
        Task<SearchResponse> GetSearchAsync(SearchRequest request);
    }
}
