using System;

namespace TheFund.AtidsXe.Blazor.Server.Models.DataTransferObjects
{
    public class TitleEventDTO
    {
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

        public ExaminationStatusTypeDTO CurrentExamStatusType { get; set; }

        public ExaminationStatusTypeDTO OriginalExamStatusType { get; set; }
    }
}
