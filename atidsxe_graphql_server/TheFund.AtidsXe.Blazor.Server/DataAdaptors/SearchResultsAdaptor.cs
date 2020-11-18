using Syncfusion.Blazor;
using Syncfusion.Blazor.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFund.AtidsXe.Blazor.Server.Models.DataTransferObjects;
using TheFund.AtidsXe.Blazor.Server.Models.Requests;
using TheFund.AtidsXe.Blazor.Server.Services;

namespace TheFund.AtidsXe.Blazor.Server.DataAdaptors
{
    public class SearchResultsAdaptor : DataAdaptor
    {
        private readonly IDataService _dataService;

        public SearchResultsAdaptor(IDataService dataService)
        {
            _dataService = dataService;
        }

        public override async Task<object> ReadAsync(DataManagerRequest request, string key = null)
        {
            var result = await _dataService.GetSearchAsync(SearchRequest.Create(fileReferenceId: 24196, searchId: 40101, request.Skip, request.Take));

            return result.Match
            (
                p =>
                {
                    var connection = p.Search.TitleEventSearchConnection;
                    var titleEvents = connection.Nodes.Select(p => p.TitleEvent).ToList();

                    return request.RequiresCounts ? new DataResult
                    {
                        Result = titleEvents,
                        Count = connection.TotalCount
                    } : (object)titleEvents;
                },
                () =>
                {
                    return new List<TitleEventDTO>();
                });
        }
    }
}
