using System;

namespace TheFund.AtidsXe.Blazor.Server.Models.Requests
{
    public class ChainOfTitleRequest : IRequest
    {
        private ChainOfTitleRequest(int fileReferenceId, int chainOfTitleId, PagingOptions pagingOptions)
        {
            FileReferenceId = fileReferenceId;
            ChainOfTitleId = chainOfTitleId;
            PagingOptions = pagingOptions ?? throw new ArgumentNullException(nameof(pagingOptions));
        }

        public int FileReferenceId { get; }

        public int ChainOfTitleId { get; }

        public object CacheKey => (FileReferenceId, ChainOfTitleId);

        public PagingOptions PagingOptions { get; }

        public object Variables { get; }

        public string Query { get; }

        public string OperationName { get; }

        public static ChainOfTitleRequest Create(int fileReferenceId, int chainOfTitleId, PagingOptions pagingOptions = null)
        {
            return new ChainOfTitleRequest(fileReferenceId, chainOfTitleId, pagingOptions ?? new PagingOptions());
        }
    }
}
