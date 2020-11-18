using JetBrains.Annotations;
using Optional;
using System.Threading;
using System.Threading.Tasks;
using TheFund.AtidsXe.Blazor.Server.Models.Requests;
using TheFund.AtidsXe.Blazor.Server.Models.Responses;

namespace TheFund.AtidsXe.Blazor.Server.Services
{
    public interface IDataService
    {
        Task<Option<ChainOfTitleResponse>> GetChainOfTitleAsync([NotNull] ChainOfTitleRequest request, CancellationToken token = default);
        Task<Option<FileReferencesResponse>> GetFileReferenceAsync([NotNull] FileReferencesRequest request, CancellationToken token = default);
        Task<Option<WorksheetResponse>> GetPolicyAsync([NotNull] WorksheetRequest request, CancellationToken token = default);
        Task<Option<IResponse>> GetResponseAsync([NotNull] IRequest request, CancellationToken token = default);
        Task<Option<SearchResponse>> GetSearchAsync([NotNull] SearchRequest request, CancellationToken token = default);
        Task<Option<WorksheetResponse>> GetWorksheetAsync([NotNull] WorksheetRequest request, CancellationToken token = default);
        object InvalidateCachedItem([NotNull] object key);
    }
}
