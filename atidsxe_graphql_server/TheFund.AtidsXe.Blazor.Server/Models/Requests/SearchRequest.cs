using System;

namespace TheFund.AtidsXe.Blazor.Server.Models.Requests
{
    public sealed class SearchRequest : IRequest
    {
        private SearchRequest(int fileReferenceId, int searchId, PagingOptions pagingOptions)
        {
            CacheKey = (fileReferenceId, searchId);
            PagingOptions = pagingOptions ?? throw new ArgumentNullException(nameof(pagingOptions));
            OperationName = "Search";
            Variables = new 
            {
                fileReferenceId, 
                searchId 
            };
        }

        private SearchRequest(int fileReferenceId, int searchId, int skip, int take)
        {
            CacheKey = (fileReferenceId, searchId);
            OperationName = "Search";
            Variables = new 
            {
                fileReferenceId, 
                searchId,
                skip,
                take
            };
        }

        public object CacheKey { get; }

        public PagingOptions PagingOptions { get; }

        public string OperationName { get; }

        public object Variables { get; }
        
        public string Query
        {
            get
            {
                return "query Search($fileReferenceId:Int!,$searchId:Int!,$skip:Int!,$take:Int!)" +
                       "{pagedTitleEventSearches(fileReferenceId:$fileReferenceId,searchId:$searchId,skip:$skip,take:$take){__typename searchId fileReferenceId searchTypeId searchThruDate searchFromDate searchStatusId geographicLocaleId " +
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

                //return "query Search($fileReferenceId:Int!, $searchId:Int!, $pageSize: PaginationAmount!, $after: String)" +
                //       "{search(fileReferenceId:$fileReferenceId,searchId:$searchId){__typename searchId fileReferenceId searchTypeId searchThruDate searchFromDate searchStatusId geographicLocaleId " +
                //       "geographicCertRangeId geographicLocaleId parentSearchId instrumentFilters lrsSearch inclMortgageeShortForm hidden " +
                //       "geographicLocale{__typename geographicLocaleId geographicLocaleTypeId localeName localeAbbreviation parentGeographicLocaleId}" +
                //       "geographicCertRange{__typename certificationRangeId fromDate fromOrDocumentId toDate toOrDocumentId}" +
                //       "giCertRange{__typename certificationRangeId fromDate fromOrDocumentId toDate toOrDocumentId}" +
                //       "grantorCertRange{__typename certificationRangeId fromDate fromOrDocumentId toDate toOrDocumentId}" +
                //       "parentSearch{__typename searchId fileReferenceId}" +
                //       "inverseParentSearches{__typename searchId}" +
                //       "TitleEventSearchConnection:titleEventSearches(first: $pageSize, after:$after){__typename totalCount pageInfo{...pageInfoFields}" +
                //       "nodes{searchId titleEventId titleEvent{__typename titleEventId additionalInformation amount createDate currentExamStatusTypeId originalExamStatusTypeId tag titleEventDate titleEventTypeId}}}}}" +
                //       "fragment pageInfoFields on PageInfo{startCursor endCursor hasPreviousPage hasNextPage}";
            }
        }

        public static SearchRequest Create(int fileReferenceId, int searchId, int skip, int take)
        {
            return new SearchRequest(fileReferenceId, searchId, skip, take);
        }

        public static SearchRequest Create(int fileReferenceId, int searchId, PagingOptions pagingOptions = null)
        {
            return new SearchRequest(fileReferenceId, searchId, pagingOptions ?? new PagingOptions());
        }
    }
}
