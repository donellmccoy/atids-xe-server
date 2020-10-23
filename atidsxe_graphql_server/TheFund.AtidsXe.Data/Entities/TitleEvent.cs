using HotChocolate.Types;
using System;
using System.Collections.Generic;
using TheFund.AtidsXe.Common.Middleware;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TitleEvent
    {
        public TitleEvent()
        {
            ChainOfTitleItems = new HashSet<ChainOfTitleItem>();
            NameSearchListItems = new HashSet<NameSearchListItem>();
            TitleEventGovtLotLegalMqls = new HashSet<TitleEventGovtLotLegalMql>();
            TitleEventLegalEntityMqls = new HashSet<TitleEventLegalEntityMql>();
            TitleEventNotes = new HashSet<TitleEventNotes>();
            TitleEventOrderTrackings = new HashSet<TitleEventOrderTracking>();
            TitleEventParties = new HashSet<TitleEventParty>();
            TitleEventPlattedLegalMqls = new HashSet<TitleEventPlattedLegalMql>();
            TitleEventSearches = new HashSet<TitleEventSearch>();
            TitleEventSectionLegalMqls = new HashSet<TitleEventSectionLegalMql>();
            TitleSearchOriginations = new HashSet<TitleSearchOrigination>();
            WorksheetItems = new HashSet<WorksheetItem>();
        }

        public int TitleEventId { get; set; }

        public int CurrentExamStatusTypeId { get; set; }

        public int OriginalExamStatusTypeId { get; set; }

        public int TitleEventStatusAssignorId { get; set; }

        public int TitleEventTypeId { get; set; }

        public decimal? Amount { get; set; }

        [Trim]
        public string AdditionalInformation { get; set; }

        public DateTime? TitleEventDate { get; set; }

        public DateTime? CreateDate { get; set; }

        [Trim]
        public string Tag { get; set; }

        public ExaminationStatusType CurrentExamStatusType { get; set; }

        public ExaminationStatusType OriginalExamStatusType { get; set; }

        public TitleEventStatusAssignor TitleEventStatusAssignor { get; set; }

        public TitleEventType TitleEventType { get; set; }

        public MortgageTitleEvent MortgageTitleEvent { get; set; }

        public TitleEventDocument TitleEventDocument { get; set; }

        [UseFiltering]
        [UseSorting]
        public ICollection<ChainOfTitleItem> ChainOfTitleItems { get; set; }

        [UseFiltering]
        [UseSorting]
        public ICollection<TitleSearchOrigination> TitleSearchOriginations { get; set; }

        [UseFiltering]
        [UseSorting]
        public ICollection<WorksheetItem> WorksheetItems { get; set; }

        [UseFiltering]
        [UseSorting]
        public ICollection<NameSearchListItem> NameSearchListItems { get; set; }

        [UseFiltering]
        [UseSorting]
        public ICollection<TitleEventGovtLotLegalMql> TitleEventGovtLotLegalMqls { get; set; }

        [UseFiltering]
        [UseSorting]
        public ICollection<TitleEventLegalEntityMql> TitleEventLegalEntityMqls { get; set; }

        [UseFiltering]
        [UseSorting]
        public ICollection<TitleEventNotes> TitleEventNotes { get; set; }

        [UseFiltering]
        [UseSorting]
        public ICollection<TitleEventOrderTracking> TitleEventOrderTrackings { get; set; }

        [UseFiltering]
        [UseSorting]
        public ICollection<TitleEventParty> TitleEventParties { get; set; }

        [UseFiltering]
        [UseSorting]
        public ICollection<TitleEventPlattedLegalMql> TitleEventPlattedLegalMqls { get; set; }

        [UseFiltering]
        [UseSorting]
        public ICollection<TitleEventSearch> TitleEventSearches { get; set; }

        [UseFiltering]
        [UseSorting]
        public ICollection<TitleEventSectionLegalMql> TitleEventSectionLegalMqls { get; set; }
    }
}