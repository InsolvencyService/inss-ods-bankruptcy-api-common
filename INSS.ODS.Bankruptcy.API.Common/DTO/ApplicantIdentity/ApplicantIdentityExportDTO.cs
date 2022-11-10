using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class ApplicantIdentityExportDTO
    {
        public ApplicantIdentityExportDTO()
        {
            ApplicantSecurityQuestionAnswers = new List<ApplicantSecurityQuestionAnswerItemExportDTO>();
            DependentsNotLivingWithYou = new List<DependentsNotLivingWithYouExportDTO>();
            HouseholdMembers = new List<HouseholdMemberExportDTO>();
            BankDetails = new List<BankDetailsExportDTO>();
            AccountDetails = new List<BankAccountDetailsExportDTO>();
            OtherNames = new List<OtherNameExportDTO>();
            HouseholdMembers = new List<HouseholdMemberExportDTO>();
            DependentsNotLivingWithYou = new List<DependentsNotLivingWithYouExportDTO>();
            EmployerDetails = new List<EmployerDetailsExportDTO>();
            CompanyDirectorships = new List<CompanyDirectorshipExportDTO>();
            PreferentialPayments = new List<PreferentialPaymentExportDTO>();
            DebtReliefOptionsUsed = new List<DebtReliefOptionUsedExportDTO>();
            Creditors = new List<CreditorExportDTO>();

            PolicyMain = new List<PolicyMainExportDTO>();
            PropertyDetails = new List<PropertyDetailsExportDTO>();
            PolicyDetail = new List<PolicyDetailExportDTO>();
            Vehicles = new List<VehicleDetailsExportDTO>();

            OtherAssetsPossessions = new List<OtherAssetsPossessionExportDTO>();
            OtherAssetsCompensations = new List<OtherAssetsCompensationExportDTO>();
            OtherAssetsWills = new List<OtherAssetsWillExportDTO>();
            OtherAssetsStocks = new List<OtherAssetsStockExportDTO>();
            OtherAssetsSelfEmployedAssets = new List<OtherAssetsSelfEmployedAssetExportDTO>();
            OtherAssetsMoniesOwed = new List<OtherAssetsMoneyOwedExportDTO>();
            OtherAssetsItems = new List<OtherAssetsItemExportDTO>();
        }

        [DataMember]
        public string Urn { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string MiddleNames { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public DateTime DateOfBirth { get; set; }

        [DataMember]
        public DateTime? Submitted { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string AdjReference { get; set; }

        [DataMember]
        public int? NextOrderId { get; set; }

        [DataMember]
        public bool IsDiscarded { get; set; }

        [DataMember]
        public IList<ApplicantSecurityQuestionAnswerItemExportDTO> ApplicantSecurityQuestionAnswers { get; set; }

        [DataMember]
        public PersonalDetailsExportDTO PersonalDetails { get; set; }

        [DataMember]
        public PersonalDetailsAdditionalExportDTO PersonalDetailsAdditional { get; set; }

        [DataMember]
        public HomeUtilitiesExportDTO HomeUtilities { get; set; }

        [DataMember]
        public PensionExportDTO Pension { get; set; }

        [DataMember]
        public BenefitsExportDTO Benefits { get; set; }

        [DataMember]
        public PensionInsuranceHealthcareExportDTO PensionInsuranceHealthcare { get; set; }

        [DataMember]
        public ChildcareAndMaintenanceExportDTO ChildcareAndMaintenance { get; set; }

        [DataMember]
        public SavingsFinesOtherCostsExportDTO SavingsFinesOtherCosts { get; set; }

        [DataMember]
        public ContactDetailsExportDTO ContactDetails { get; set; }

        [DataMember]
        public IList<OccupancyDetailsExportDTO> OccupancyDetails { get; set; }

        [DataMember]
        public LandlordOrAgentDetailsExportDTO LandlordOrAgentDetails { get; set; }

        [DataMember]
        public IList<OtherNameExportDTO> OtherNames { get; set; }

        [DataMember]
        public IList<DependentsNotLivingWithYouExportDTO> DependentsNotLivingWithYou { get; set; }

        [DataMember]
        public PersonalLeisureExpensesExportDTO PersonalLeisureExpenses { get; set; }

        [DataMember]
        public IList<HouseholdMemberExportDTO> HouseholdMembers { get; set; }

        [DataMember]
        public IList<WagesExportDTO> Wages { get; set; }

        [DataMember]
        public HousekeepingDetailsExportDTO HousekeepingDetails { get; set; }

        [DataMember]
        public ContributionsFromOthersExportDTO ContributionsFromOthers { get; set; }

        [DataMember]
        public IList<OtherIncomeDetailsExportDTO> OtherIncomes { get; set; }

        [DataMember]
        public TransportExportDTO Transport { get; set; }

        [DataMember]
        public IList<EmployerDetailsExportDTO> EmployerDetails { get; set; }

        [DataMember]
        public IList<PolicyMainExportDTO> PolicyMain { get; set; }

        [DataMember]
        public IList<PolicyDetailExportDTO> PolicyDetail { get; set; }

        [DataMember]
        public EmploymentSummaryInfoExportDTO EmploymentSummaryInfo { get; set; }

        [DataMember]
        public IList<BankDetailsExportDTO> BankDetails { get; set; }

        [DataMember]
        public EmploymentStatusExportDTO EmploymentStatus { get; set; }

        [DataMember]
        public AssetSummaryExportDTO AssetSummary { get; set; }

        [DataMember]
        public IList<BankAccountDetailsExportDTO> AccountDetails { get; set; }

        [DataMember]
        public IList<JointAccountOwnerExportDTO> JointAccountOwners { get; set; }

        [DataMember]
        public IList<SelfEmployedBusinessDetailExportDTO> SelfEmployedBusinessDetails { get; set; }

        [DataMember]
        public IList<PartnershipDetailExportDTO> PartnershipDetails { get; set; }


        [DataMember]
        public IList<VehicleDetailsExportDTO> Vehicles { get; set; }

        [DataMember]
        public IList<CreditorExportDTO> Creditors { get; set; }

        [DataMember]
        public IList<CompanyDirectorshipExportDTO> CompanyDirectorships { get; set; }

        [DataMember]
        public OtherAssetsSummaryInfoExportDTO OtherAssetsSummaryInfo { get; set; }

        [DataMember]
        public OtherAssetsCashExportDTO OtherAssetsCash { get; set; }

        [DataMember]
        public IList<OtherAssetsCompensationExportDTO> OtherAssetsCompensations { get; set; }

        [DataMember]
        public IList<OtherAssetsPossessionExportDTO> OtherAssetsPossessions { get; set; }

        [DataMember]
        public IList<OtherAssetsWillExportDTO> OtherAssetsWills { get; set; }

        [DataMember]
        public IList<OtherAssetsStockExportDTO> OtherAssetsStocks { get; set; }

        [DataMember]
        public IList<OtherAssetsSelfEmployedAssetExportDTO> OtherAssetsSelfEmployedAssets { get; set; }

        [DataMember]
        public IList<OtherAssetsMoneyOwedExportDTO> OtherAssetsMoniesOwed { get; set; }

        [DataMember]
        public IList<OtherAssetsItemExportDTO> OtherAssetsItems { get; set; }

        [DataMember]
        public RecoveriesSummaryExportDTO RecoveriesSummary { get; set; }

        [DataMember]
        public DebtHistoryExportDTO DebtHistory { get; set; }

        [DataMember]
        public DebtIncurredDetailExportDTO DebtIncurredDetail { get; set; }

        [DataMember]
        public IList<PreferentialPaymentExportDTO> PreferentialPayments { get; set; }

        [DataMember]
        public IList<DebtReliefOptionUsedExportDTO> DebtReliefOptionsUsed { get; set; }

        [DataMember]
        public IList<PropertyDetailsExportDTO> PropertyDetails { get; set; }

        [DataMember]
        public IList<MortgageAndSecuredDebtCreditorExportDTO> MortgageAndSecuredDebtCreditor { get; set; }

        [DataMember]
        public LegalProceedingsSummaryInfoExportDTO LegalProceedingsSummaryInfo { get; set; }

        [DataMember]
        public ApplicationStatusExportEnum Status { get; set; }

        [DataMember]
        public SectionCompletionStatusExportDTO SectionCompletionStatus { get; set; }

        [DataMember]
        public string BKTReference { get; set; }

        [DataMember]
        public ApplicationSubmissionQuestionsExportDTO ApplicationSubmissionQuestions { get; set; }

        [DataMember]
        public PARVDetailExportDTO PARVDetail { get; set; }

        [DataMember]
        public SelfEmploymentIncomeExportDTO SelfEmploymentIncome { get; set; }


    }
}
