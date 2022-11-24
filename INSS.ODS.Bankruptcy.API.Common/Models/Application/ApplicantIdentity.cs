using INSS.ODS.Bankruptcy.API.Common.Models.ApplicationOverview;
using INSS.ODS.Bankruptcy.API.Common.Models.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Models.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Models.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.Employment;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.LegalProceedings;
using INSS.ODS.Bankruptcy.API.Common.Models.OtherAssets;
using INSS.ODS.Bankruptcy.API.Common.Models.Recoveries;
using INSS.ODS.Bankruptcy.API.Common.Models.Vehicle;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;
using System;
using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[DataContract]
[Index(nameof(Urn), IsUnique = true, Name = "IX_URN")]
public class ApplicantIdentity : ITableBase, IApplicantDetails
{
    [DataMember]
    public int Id { get; set; }

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

    [NotMapped]
    [DataMember]
    public string ConfirmEmail { get; set; }

    [DataMember]
    public IList<ApplicantSecurityQuestionAnswerItem> ApplicantSecurityQuestionAnswers
    {
        get;
        set;
    }

    [DataMember]
    public PersonalDetails PersonalDetails { get; set; }

    [DataMember]
    public PersonalDetailsAdditional PersonalDetailsAdditional { get; set; }

    [DataMember]
    public HomeUtilities HomeUtilities { get; set; }

    [DataMember]
    public Pension Pension { get; set; }

    [DataMember]
    public Benefits Benefits { get; set; }

    [DataMember]
    public PensionInsuranceHealthcare PensionInsuranceHealthcare { get; set; }

    [DataMember]
    public ChildcareAndMaintenance ChildcareAndMaintenance { get; set; }

    [DataMember]
    public SavingsFinesOtherCosts SavingsFinesOtherCosts { get; set; }

    [DataMember]
    public ContactDetails ContactDetails { get; set; }

    [DataMember]
    public IList<OccupancyDetails> OccupancyDetails { get; set; }

    [DataMember]
    public LandlordOrAgentDetails LandlordOrAgentDetails { get; set; }

    [DataMember]
    public IList<OtherName> OtherNames { get; set; }

    [DataMember]
    public IList<DependentsNotLivingWithYou> DependentsNotLivingWithYou { get; set; }

    [DataMember]
    public PersonalLeisureExpenses PersonalLeisureExpenses { get; set; }

    [DataMember]
    public IList<HouseholdMember> HouseholdMembers { get; set; }

    [DataMember]
    public IList<Wages> Wages { get; set; }

    [DataMember]
    public HousekeepingDetails HousekeepingDetails { get; set; }

    [DataMember]
    public ContributionsFromOthers ContributionsFromOthers { get; set; }

    [DataMember]
    public IList<OtherIncomeDetails> OtherIncomes { get; set; }

		[DataMember]
    public Transport Transport { get; set; }

    [DataMember]
    public IList<EmployerDetails> EmployerDetails { get; set; }

    [DataMember]
    public IList<PolicyMain> PolicyMain { get; set; }

    [DataMember]
    public IList<PolicyDetail> PolicyDetail { get; set; }

    public ApplicantIdentity()
    {
        ApplicantSecurityQuestionAnswers = new List<ApplicantSecurityQuestionAnswerItem>();
        DependentsNotLivingWithYou = new List<DependentsNotLivingWithYou>();
        HouseholdMembers = new List<HouseholdMember>();
        BankDetails = new List<BankDetails>();
        AccountDetails = new List<BankAccountDetails>();
        OtherNames = new List<OtherName>();
        HouseholdMembers = new List<HouseholdMember>();
        DependentsNotLivingWithYou = new List<DependentsNotLivingWithYou>();
        EmployerDetails = new List<EmployerDetails>();
        CompanyDirectorships = new List<CompanyDirectorship>();
        PreferentialPayments = new List<PreferentialPayment>();
        DebtReliefOptionsUsed = new List<DebtReliefOptionUsed>();
        Creditors = new List<Creditor>();

        PolicyMain = new List<PolicyMain>();
        PropertyDetails = new List<PropertyDetails>();
        PolicyDetail = new List<PolicyDetail>();
        Vehicles = new List<VehicleDetails>();

        OtherAssetsPossessions = new List<OtherAssetsPossession>();
        OtherAssetsCompensations = new List<OtherAssetsCompensation>();
        OtherAssetsWills = new List<OtherAssetsWill>();
        OtherAssetsStocks = new List<OtherAssetsStock>();
        OtherAssetsSelfEmployedAssets = new List<OtherAssetsSelfEmployedAsset>();
        OtherAssetsMoniesOwed = new List<OtherAssetsMoneyOwed>();
        OtherAssetsItems = new List<OtherAssetsItem>();

        Status = ApplicationStatus.InProgress;
    }

    [DataMember]
    public EmploymentSummaryInfo EmploymentSummaryInfo { get; set; }

    [DataMember]
    public IList<BankDetails> BankDetails { get; set; }

		[DataMember]
    public EmploymentStatus EmploymentStatus { get; set; }

    [DataMember]
    public AssetSummary AssetSummary { get; set; }
		
		[DataMember]
    public IList<BankAccountDetails> AccountDetails { get; set; }

    [DataMember]
    public IList<JointAccountOwner> JointAccountOwners { get; set; }

    [DataMember]
    public IList<SelfEmployedBusinessDetail> SelfEmployedBusinessDetails { get; set; }

    [DataMember]
    public IList<PartnershipDetail> PartnershipDetails { get; set; }


    [DataMember]
    public IList<VehicleDetails> Vehicles { get; set; }

    [DataMember]
    public IList<Creditor> Creditors { get; set; }

		[DataMember]
    public bool IsDiscarded { get; set; }

    [DataMember]
    public DateTime? DiscardDate { get; set; }

    [DataMember]
    public IList<CompanyDirectorship> CompanyDirectorships { get; set; }
    
    [DataMember]
    public OtherAssetsSummaryInfo OtherAssetsSummaryInfo { get; set; }

		[DataMember]
    public OtherAssetsCash OtherAssetsCash { get; set; }

    [DataMember]
    public IList<OtherAssetsCompensation> OtherAssetsCompensations { get; set; }

    [DataMember]
    public IList<OtherAssetsPossession> OtherAssetsPossessions { get; set; }

    [DataMember]
    public IList<OtherAssetsWill> OtherAssetsWills { get; set; }

    [DataMember]
    public IList<OtherAssetsStock> OtherAssetsStocks { get; set; }

    [DataMember]
    public IList<OtherAssetsSelfEmployedAsset> OtherAssetsSelfEmployedAssets { get; set; }

    [DataMember]
    public IList<OtherAssetsMoneyOwed> OtherAssetsMoniesOwed { get; set; }

    [DataMember]
    public IList<OtherAssetsItem> OtherAssetsItems { get; set; }

    [DataMember]
    public RecoveriesSummary RecoveriesSummary { get; set; }

    [DataMember]
    public DebtHistory DebtHistory { get; set; }

    [DataMember]
    public DebtIncurredDetail DebtIncurredDetail { get; set; }

    [DataMember]
    public IList<PreferentialPayment> PreferentialPayments { get; set; }

    [DataMember]
    public IList<DebtReliefOptionUsed> DebtReliefOptionsUsed { get; set; }

    [DataMember]
    public IList<PropertyDetails> PropertyDetails { get; set; }

    [DataMember]
    public IList<MortgageAndSecuredDebtCreditor> MortgageAndSecuredDebtCreditor { get; set; }

    [DataMember]
    public LegalProceedingsSummaryInfo LegalProceedingsSummaryInfo { get; set; }

    [DataMember]
    public string AdjReference { get; set; }

    [DataMember]
    public int? NextOrderId { get; set; }

    [DataMember]
    [DefaultValue(ApplicationStatus.InProgress)]
    public ApplicationStatus Status { get; set; }

    [DataMember]
    public SectionCompletionStatus SectionCompletionStatus { get; set; }

    [DataMember]
    public string BKTReference { get; set; }

    [DataMember]
    public ApplicationSubmissionQuestions ApplicationSubmissionQuestions { get; set; }

    [DataMember]
    public PARVDetail  PARVDetail { get; set; }

    [DataMember]
    public SelfEmploymentIncome SelfEmploymentIncome { get; set; }

    [DataMember]
    public HomeAddress HomeAddress { get; set; }

    [DataMember]
    public RefundBankDetails RefundBankDetails { get; set; }

    [DataMember]
    public MoneyOwed MoneyOwed { get; set; }

    [DataMember]
    public DateTime? StatusUpdateDate { get; set; }

    [DataMember]
    public DateTime? CreatedOnDate { get; set; }

}