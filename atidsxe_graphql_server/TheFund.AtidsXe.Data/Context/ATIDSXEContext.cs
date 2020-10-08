using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Context
{
    public partial class ATIDSXEContext : DbContext
    {
        public ATIDSXEContext(DbContextOptions<ATIDSXEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AcreageGovtLotLegal> AcreageGovtLotLegal { get; set; }
        public virtual DbSet<AcreageSectionLegal> AcreageSectionLegal { get; set; }
        //public virtual DbSet<BookPageReference> BookPageReference { get; set; }
        public virtual DbSet<BranchLocation> BranchLocation { get; set; }
        public virtual DbSet<BreakdownCodeType> BreakdownCodeType { get; set; }
        //public virtual DbSet<CaseNumberReference> CaseNumberReference { get; set; }
        public virtual DbSet<CertificationRange> CertificationRange { get; set; }
        public virtual DbSet<ChainOfTitle> ChainOfTitle { get; set; }
        public virtual DbSet<ChainOfTitleCategory> ChainOfTitleCategory { get; set; }
        public virtual DbSet<ChainOfTitleItem> ChainOfTitleItem { get; set; }
        public virtual DbSet<ChainOfTitleNotes> ChainOfTitleNotes { get; set; }
        public virtual DbSet<ChainOfTitleSearch> ChainOfTitleSearch { get; set; }
        public virtual DbSet<DeliveryOrderInfo> DeliveryOrderInfo { get; set; }
        public virtual DbSet<ExaminationStatusType> ExaminationStatusType { get; set; }
        public virtual DbSet<FileReference> FileReference { get; set; }
        public virtual DbSet<FileReferenceNotes> FileReferenceNotes { get; set; }
        public virtual DbSet<FileStatus> FileStatus { get; set; }
        public virtual DbSet<GeographicLocale> GeographicLocale { get; set; }
        //public virtual DbSet<GeographicLocaleType> GeographicLocaleType { get; set; }
        public virtual DbSet<GovernmentLot> GovernmentLot { get; set; }
        public virtual DbSet<GovernmentLotLegal> GovernmentLotLegal { get; set; }
        public virtual DbSet<LegalEntityName> LegalEntityName { get; set; }
        public virtual DbSet<LegalEntityNameType> LegalEntityNameType { get; set; }
        //public virtual DbSet<MinNumber> MinNumber { get; set; }
        //public virtual DbSet<MortgageTitleEvent> MortgageTitleEvent { get; set; }
        public virtual DbSet<NameReasonCode> NameReasonCode { get; set; }
        public virtual DbSet<NameSearchListItem> NameSearchListItem { get; set; }
        public virtual DbSet<NameSearchListReasonCode> NameSearchListReasonCode { get; set; }
        public virtual DbSet<NameSearchParameters> NameSearchParameters { get; set; }
        public virtual DbSet<NameSearchStatusCode> NameSearchStatusCode { get; set; }
        //public virtual DbSet<OfficialRecordDocument> OfficialRecordDocument { get; set; }
        //public virtual DbSet<OrDocumentInformation> OrDocumentInformation { get; set; }
        public virtual DbSet<OwnerBuyerRelationship> OwnerBuyerRelationship { get; set; }
        public virtual DbSet<Party> Party { get; set; }
        public virtual DbSet<PartyLegalEntityName> PartyLegalEntityName { get; set; }
        public virtual DbSet<PartyRoleType> PartyRoleType { get; set; }
        public virtual DbSet<PersonalLegalEntityName> PersonalLegalEntityName { get; set; }
        public virtual DbSet<PlatProperties> PlatProperties { get; set; }
        public virtual DbSet<PlatReference> PlatReference { get; set; }
        public virtual DbSet<PlattedLegal> PlattedLegal { get; set; }
        public virtual DbSet<Policy> Policy { get; set; }
        public virtual DbSet<PolicyGovtLotLegalMql> PolicyGovtLotLegalMql { get; set; }
        public virtual DbSet<PolicyInsuredDocument> PolicyInsuredDocument { get; set; }
        public virtual DbSet<PolicyNotes> PolicyNotes { get; set; }
        public virtual DbSet<PolicyOrder> PolicyOrder { get; set; }
        public virtual DbSet<PolicyOrderTracking> PolicyOrderTracking { get; set; }
        public virtual DbSet<PolicyPlattedLegalMql> PolicyPlattedLegalMql { get; set; }
        public virtual DbSet<PolicyRestrictionType> PolicyRestrictionType { get; set; }
        public virtual DbSet<PolicySearch> PolicySearch { get; set; }
        public virtual DbSet<PolicySectionLegalMql> PolicySectionLegalMql { get; set; }
        public virtual DbSet<PolicyTitleStatusReport> PolicyTitleStatusReport { get; set; }
        public virtual DbSet<PolicyWorksheetItem> PolicyWorksheetItem { get; set; }
        //public virtual DbSet<PropertyAddress> PropertyAddress { get; set; }
        public virtual DbSet<RangeDirectionType> RangeDirectionType { get; set; }
        //public virtual DbSet<RelatedCaseNumber> RelatedCaseNumber { get; set; }
        //public virtual DbSet<RelatedOrDocument> RelatedOrDocument { get; set; }
        //public virtual DbSet<RelatedTaxFolio> RelatedTaxFolio { get; set; }
        public virtual DbSet<Search> Search { get; set; }
        public virtual DbSet<SearchNotes> SearchNotes { get; set; }
        public virtual DbSet<SearchStatus> SearchStatus { get; set; }
        public virtual DbSet<SearchType> SearchType { get; set; }
        public virtual DbSet<SearchWarning> SearchWarning { get; set; }
        public virtual DbSet<SearchWarningHelp> SearchWarningHelp { get; set; }
        public virtual DbSet<SearchWarningType> SearchWarningType { get; set; }
        public virtual DbSet<SectionBreakdownCode> SectionBreakdownCode { get; set; }
        public virtual DbSet<SectionLegal> SectionLegal { get; set; }
        public virtual DbSet<SubdivisionLevels> SubdivisionLevels { get; set; }
        public virtual DbSet<SubdivisionPlattedLegal> SubdivisionPlattedLegal { get; set; }
        //public virtual DbSet<TaxFolioReference> TaxFolioReference { get; set; }
        public virtual DbSet<TitleEvent> TitleEvent { get; set; }
        //public virtual DbSet<TitleEventDocument> TitleEventDocument { get; set; }
        public virtual DbSet<TitleEventGovtLotLegalMql> TitleEventGovtLotLegalMql { get; set; }
        public virtual DbSet<TitleEventLegalEntityMql> TitleEventLegalEntityMql { get; set; }
        //public virtual DbSet<TitleEventNotes> TitleEventNotes { get; set; }
        public virtual DbSet<TitleEventOrder> TitleEventOrder { get; set; }
        public virtual DbSet<TitleEventOrderTracking> TitleEventOrderTracking { get; set; }
        public virtual DbSet<TitleEventParty> TitleEventParty { get; set; }
        public virtual DbSet<TitleEventPlattedLegalMql> TitleEventPlattedLegalMql { get; set; }
        public virtual DbSet<TitleEventSearch> TitleEventSearch { get; set; }
        public virtual DbSet<TitleEventSectionLegalMql> TitleEventSectionLegalMql { get; set; }
        public virtual DbSet<TitleEventStatusAssignor> TitleEventStatusAssignor { get; set; }
        //public virtual DbSet<TitleEventType> TitleEventType { get; set; }
        //public virtual DbSet<TitleEventTypeCategory> TitleEventTypeCategory { get; set; }
        public virtual DbSet<TitleSearchOrigination> TitleSearchOrigination { get; set; }
        public virtual DbSet<TownshipDirectionType> TownshipDirectionType { get; set; }
        //public virtual DbSet<TypeOfInstrument> TypeOfInstrument { get; set; }
        public virtual DbSet<UnplattedReference> UnplattedReference { get; set; }
        //public virtual DbSet<User> User { get; set; }
        //public virtual DbSet<UserProfile> UserProfile { get; set; }
        //public virtual DbSet<UserProfileFileReference> UserProfileFileReference { get; set; }
        public virtual DbSet<Worksheet> Worksheet { get; set; }
        public virtual DbSet<WorksheetItem> WorksheetItem { get; set; }
        //public virtual DbSet<YearNumberReference> YearNumberReference { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(ATIDSXEContext)));
        }
    }
}
