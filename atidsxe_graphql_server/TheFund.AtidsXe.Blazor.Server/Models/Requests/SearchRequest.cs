using GraphQL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFund.AtidsXe.Blazor.Server.Models.Requests
{
    public sealed class SearchRequest : IRequest
    {
        private SearchRequest(int fileReferenceId, int searchId, PagingOptions pagingOptions)
        {
            FileReferenceId = fileReferenceId;
            SearchId = searchId;
            PagingOptions = pagingOptions ?? throw new ArgumentNullException(nameof(pagingOptions));
        }

        public int FileReferenceId { get; }

        public int SearchId { get; }

        public (int fileReferenceId, int searchId) CacheKey => (FileReferenceId, SearchId);

        public (string, int)[] Variables => new[] { ("FileReferenceId", FileReferenceId), ("SearchId", SearchId) };

        public PagingOptions PagingOptions { get; }

        public static SearchRequest Create(int fileReferenceId, int searchId, PagingOptions pagingOptions = null)
        {
            return new SearchRequest(fileReferenceId, searchId, pagingOptions ?? new PagingOptions());
        }
    }
}
