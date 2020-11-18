using TheFund.AtidsXe.Blazor.Server.Models.DataTransferObjects;

namespace TheFund.AtidsXe.Blazor.Server.Models.Responses
{
    public sealed class SearchResponse : IResponse
    {
        public SearchDTO Search { get; set; }
    }
}
