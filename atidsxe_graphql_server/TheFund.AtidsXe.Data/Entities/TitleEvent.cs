using System;
using System.Collections.Generic;
using HotChocolate.Types;
using HotChocolate.Types.Relay;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class TitleEvent
    {
        public TitleEvent()
        {
            ChainOfTitleItem = new HashSet<ChainOfTitleItem>();
            //NameSearchListItem = new HashSet<NameSearchListItem>();
            //TitleEventGovtLotLegalMql = new HashSet<TitleEventGovtLotLegalMql>();
            //TitleEventLegalEntityMql = new HashSet<TitleEventLegalEntityMql>();
            //TitleEventNotes = new HashSet<TitleEventNotes>();
            //TitleEventOrderTracking = new HashSet<TitleEventOrderTracking>();
            //TitleEventParty = new HashSet<TitleEventParty>();
            //TitleEventPlattedLegalMql = new HashSet<TitleEventPlattedLegalMql>();
            //TitleEventSearch = new HashSet<TitleEventSearch>();
            //TitleEventSectionLegalMql = new HashSet<TitleEventSectionLegalMql>();
            TitleSearchOrigination = new HashSet<TitleSearchOrigination>();
            WorksheetItem = new HashSet<WorksheetItem>();
        }

        public int TitleEventId { get; set; }

        public int CurrentExamStatusTypeId { get; set; }

        public int OriginalExamStatusTypeId { get; set; }

        public int TitleEventStatusAssignorId { get; set; }

        public int TitleEventTypeId { get; set; }

        public decimal? Amount { get; set; }

        public string AdditionalInformation { get; set; }

        public DateTime? TitleEventDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public string Tag { get; set; }

        public ExaminationStatusType CurrentExamStatusType { get; set; }

        public ExaminationStatusType OriginalExamStatusType { get; set; }

        //public TitleEventStatusAssignor TitleEventStatusAssignor { get; set; }
        //public TitleEventType TitleEventType { get; set; }
        //public MortgageTitleEvent MortgageTitleEvent { get; set; }
        //public TitleEventDocument TitleEventDocument { get; set; }

        [UsePaging]
        [UseSelection]
        [UseFiltering]
        [UseSorting]
        public ICollection<ChainOfTitleItem> ChainOfTitleItem { get; set; }

        [UsePaging]
        [UseSelection]
        [UseFiltering]
        [UseSorting]
        public ICollection<TitleSearchOrigination> TitleSearchOrigination { get; set; }

        [UsePaging]
        [UseSelection]
        [UseFiltering]
        [UseSorting]
        public ICollection<WorksheetItem> WorksheetItem { get; set; }

        //public ICollection<NameSearchListItem> NameSearchListItem { get; set; }
        //public ICollection<TitleEventGovtLotLegalMql> TitleEventGovtLotLegalMql { get; set; }
        //public ICollection<TitleEventLegalEntityMql> TitleEventLegalEntityMql { get; set; }
        //public ICollection<TitleEventNotes> TitleEventNotes { get; set; }
        //public ICollection<TitleEventOrderTracking> TitleEventOrderTracking { get; set; }
        //public ICollection<TitleEventParty> TitleEventParty { get; set; }
        //public ICollection<TitleEventPlattedLegalMql> TitleEventPlattedLegalMql { get; set; }
        //public ICollection<TitleEventSearch> TitleEventSearch { get; set; }
        //public ICollection<TitleEventSectionLegalMql> TitleEventSectionLegalMql { get; set; }
    }
}