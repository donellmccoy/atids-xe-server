using System;

namespace TheFund.AtidsXe.Blazor.Server.Models.Requests
{
    public sealed class WorksheetRequest
    {
        private WorksheetRequest(int fileReferenceId, int worksheetId, PagingOptions pagingOptions)
        {
            FileReferenceId = fileReferenceId;
            WorksheetId = worksheetId;
            PagingOptions = pagingOptions ?? throw new ArgumentNullException(nameof(pagingOptions));
        }

        public int FileReferenceId { get; }

        public int WorksheetId { get; }

        public (int fileReferenceId, int worksheetId) Key => (FileReferenceId, WorksheetId);

        public PagingOptions PagingOptions { get; }

        public static WorksheetRequest Create(int fileReferenceId, int worksheetId, PagingOptions pagingOptions = null)
        {
            return new WorksheetRequest(fileReferenceId, worksheetId, pagingOptions ?? new PagingOptions());
        }
    }
}
