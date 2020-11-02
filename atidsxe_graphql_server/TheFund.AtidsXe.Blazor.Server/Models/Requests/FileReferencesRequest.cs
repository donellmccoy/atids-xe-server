using System;

namespace TheFund.AtidsXe.Blazor.Server.Models.Requests
{
    public sealed class FileReferencesRequest : IRequest
    {
        public FileReferencesRequest(int fileReferenceId, PagingOptions pagingOptions)
        {
            FileReferenceId = fileReferenceId;
            PagingOptions = pagingOptions ?? throw new ArgumentNullException(nameof(pagingOptions));
        }

        public object CacheKey => FileReferenceId;

        public int FileReferenceId { get; }

        public string Query
        {
            get
            {
                return "query Search($fileReferenceId:Int!,$searchId:Int!)" +
                       "{search(fileReferenceId:$fileReferenceId,searchId:$searchId){__typename searchId fileReferenceId searchTypeId searchThruDate searchFromDate searchStatusId geographicLocaleId " +
                       "geographicCertRangeId geographicLocaleId parentSearchId instrumentFilters lrsSearch inclMortgageeShortForm hidden " +
                       "geographicLocale{__typename geographicLocaleId geographicLocaleTypeId localeName localeAbbreviation parentGeographicLocaleId}" +
                       "geographicCertRange{__typename certificationRangeId fromDate fromOrDocumentId toDate toOrDocumentId}" +
                       "giCertRange{__typename certificationRangeId fromDate fromOrDocumentId toDate toOrDocumentId}" +
                       "grantorCertRange{__typename certificationRangeId fromDate fromOrDocumentId toDate toOrDocumentId}" +
                       "parentSearch{__typename searchId fileReferenceId}" +
                       "inverseParentSearches{__typename searchId}" +
                       "TitleEventSearchConnection:titleEventSearches{__typename totalCount pageInfo{...pageInfoFields}" +
                       "nodes{searchId titleEventId titleEvent{__typename titleEventId additionalInformation amount createDate currentExamStatusTypeId originalExamStatusTypeId tag titleEventDate titleEventTypeId}}}}}" +
                       "fragment pageInfoFields on PageInfo{startCursor endCursor hasPreviousPage hasNextPage}";
            }
        }

        public PagingOptions PagingOptions { get; }

        public object Variables { get; }

        public string OperationName { get; }
    }
}
