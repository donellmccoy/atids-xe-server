using System;

namespace TheFund.AtidsXe.Blazor.Server.Models.Requests
{
    public sealed class WorksheetRequest : IRequest
    {
        private WorksheetRequest(int fileReferenceId, int worksheetId, PagingOptions pagingOptions)
        {
            FileReferenceId = fileReferenceId;
            WorksheetId = worksheetId;
            PagingOptions = pagingOptions ?? throw new ArgumentNullException(nameof(pagingOptions));
        }

        public int FileReferenceId { get; }

        public int WorksheetId { get; }

        public object CacheKey => (FileReferenceId, WorksheetId);

        public PagingOptions PagingOptions { get; }

        public object Variables { get; }

        public string Query { get; }

        public string OperationName { get; }

        public static WorksheetRequest Create(int fileReferenceId, int worksheetId, PagingOptions pagingOptions = null)
        {
            return new WorksheetRequest(fileReferenceId, worksheetId, pagingOptions ?? new PagingOptions());
        }
    }
}
