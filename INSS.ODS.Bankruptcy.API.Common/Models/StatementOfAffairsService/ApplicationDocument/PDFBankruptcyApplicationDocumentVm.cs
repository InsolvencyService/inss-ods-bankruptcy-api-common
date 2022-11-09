using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Models.Employment;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Vehicle;
using System.ComponentModel.DataAnnotations;
using INSS.ODS.Bankruptcy.API.Common.Models.OtherAssets;
using INSS.ODS.Bankruptcy.API.Common.Models.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Models.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.LegalProceedings;
using INSS.ODS.Bankruptcy.API.Common.Models.Recoveries;


namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService
{
    [Serializable]
    public class PDFBankruptcyApplicationDocumentVm : IApplicantDetails
    {
        [Required]
        public string Urn { get; set; }

        public string FirstName { get; set; }

        public string MiddleNames { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime? Submitted { get; set; }

        public string Email { get; set; }

        public string ConfirmEmail { get; set; }
        

        public PersonalDetails PersonalDetails { get; set; }
        public PersonalDetailsAdditional PersonalDetailsAdditional { get; set; }
        public LandlordOrAgentDetails LandlordDetails { get; set; }
        public ContactDetails ContactDetails { get; set; }
        public IList<OccupancyDetails> OccupancyDetails { get; set; }

        public IList<OtherName> OtherNames { get; set; }
        public IList<DependentsNotLivingWithYou> Dependents { get; set; }
        public IList<HouseholdMember> HouseholdMembers { get; set; }
        public IList<EmployerDetails> Employers { get; set; }
        public IList<CompanyDirectorship> CompanyDirectorships { get; set; }
        public InsolvencyPractitioner InsolvencyPractitioner { get; set; }
        public IList<SelfEmployedBusinessDetail> SelfEmployedBusinessDetails { get; set; }
        public SelfEmployedBusinessName SelfEmployedBusinessName { get; set; }
        public IList<SelfEmployedBusinessAddress> SelfEmployedBusinessAddress { get; set; }
        public SelfEmploymentIncome SelfEmployedBusinessIncome { get; set; }
        public IList<PartnershipDetail> PartnershipDetails { get; set; }
        public PartnershipBusinessName PartnershipBusinessName { get; set; }
        public PartnerDetail PartnerDetail { get; set; }
        public IList<PartnershipCurrentEmployeeDetail> PartnershipCurrentEmployeeDetails { get; set; }
        public PartnershipTradingAddress PartnershipTradingAddress { get; set; }
    
        public IList<Creditor> Creditors { get; set; }
        public PDFBankruptcyApplication_BankDetailsVm BankAccountDetails { get; set; }

        public IList<VehicleDetails> Vehicles { get; set; }
        public EmploymentStatus EmploymentStatus { get; set; }
        public EmploymentSummaryInfo EmploymentSummaryInfo { get; set; }
        public IList<Wages> Wages { get; set; }
        public Benefits Benefits { get; set; }
        public IList<OtherIncomeDetails> OtherIncomes { get; set; }
        public Pension Pension { get; set; }
        public ContributionsFromOthers ContributionsFromOthers { get; set; }
        public HomeUtilities HomeUtilities { get; set; }
        public PensionInsuranceHealthcare PensionInsuranceHealthcare { get; set; }
        public HousekeepingDetails HousekeepingDetails { get; set; }
        public Transport Transport { get; set; }
        public ChildcareAndMaintenance ChildcareAndMaintenance { get; set; }
        public PersonalLeisureExpenses PersonalLeisureExpenses { get; set; }
        public SavingsFinesOtherCosts SavingsFinesOtherCosts { get; set; }
        public PDFBankruptcyApplication_DebtHistoryVm DebtHistory { get; set; }
        public IList<DebtReliefOptionUsed> DebtReliefOptionUsed { get; set; }
        public IList<PreferentialPayment> PreferentialPayment { get; set; }
        public PreferentialPaymentDetail PreferentialPaymentDetail { get; set; }
        
        public OtherAssetsCash OtherAssetsCash { get; set; }
        public IList<OtherAssetsCompensation> OtherAssetsCompensations { get; set; }
        public IList<OtherAssetsMoneyOwed> OtherAssetsMoniesOwed { get; set; }
        public IList<OtherAssetsSelfEmployedAsset> OtherAssetsSelfEmployedAssets { get; set; }
        public IList<OtherAssetsStock> OtherAssetsStocks { get; set; }
        public IList<OtherAssetsWill> OtherAssetsWills { get; set; }
        public IList<OtherAssetsPossession> OtherAssetsPossessions { get; set; }
        public IList<OtherAssetsItem> OtherAssetsItems { get; set; }
        public PropertyDescription PropertyDescription { get; set; }
        public IList<PropertyDetails> PropertyDetails { get; set; }
        public PropertyJointOwnerDetails PropertyJointOwnerDetails { get; set; }
        public PropertyDebtDetails PropertyDebtDetails { get; set; }
        public PropertyLodger PropertyLodger { get; set; }
        public PropertyMoreDescription PropertyMoreDescription { get; set; }
        public PropertyTenant PropertyTenant { get; set; }
        public IList<MortgageAndSecuredDebtCreditor> MortgageAndSecuredDebtCreditor { get; set; }
        public LegalProceedingsSummaryInfo LegalProceedingsSummaryInfo { get; set; }
        public ApplicationSubmissionQuestions ApplicationSubmissionQuestions { get; set; }
        public SectionCompletionStatus SectionCompletionStatus { get; set; }

        public PARVDetail PARVDetail { get; set; }


        public List<UnsecuredCreditorNewVm> UnsecuredCreditors
        {
            get
            {
                var result = new List<UnsecuredCreditorNewVm>();
                var seizedItems = new List<SeizedAndSoldAssets>();
                var earnings = new AttachmentOfEarnings();

                //Creditors from Money You Owe section
                if(Creditors != null || Creditors.Any())
                {
                    foreach (var creditor in Creditors.Where(x => x.IsCompleteRecord))
                    {
                        var newcreditor = new UnsecuredCreditorNewVm
                        {
                            Name = creditor.CreditorName,
                            Address = creditor.CreditorAddress.FullAddress,
                            Reference = creditor.AmountYouOwe == null ? string.Empty : (creditor.AmountYouOwe.Reference ?? string.Empty),
                            AmountOwed = creditor.AmountYouOwe.Amount ?? 0,
                            DateIncurred = creditor.AmountYouOwe.ApproxDebtStartedDateRange,
                            //DebtType = !string.IsNullOrWhiteSpace(creditor.AmountYouOwe.DebtTypeOther) ? creditor.AmountYouOwe.DebtTypeOther : creditor.AmountYouOwe.DebtType,
                            DebtType = (creditor.AmountYouOwe.DebtTypeOther != null) ? creditor.AmountYouOwe.DebtTypeOther : creditor.AmountYouOwe.DebtType,
                            
                            DateAgentsVisited = (creditor.EnforcementVisit != null)
                                                    ? creditor.EnforcementVisit.VisitDate
                                                    : DateTime.MinValue,

                            WasSeizedItemSld = (creditor.EnforcementVisit == null)
                                                ? string.Empty
                                                : (creditor.EnforcementVisit.ItemsSeizedOrSold.HasValue
                                                    && creditor.EnforcementVisit.ItemsSeizedOrSold.Value == true) ? "Yes" : "No",                          
                            SeizedAndSoldAssets = (creditor.SeizedAndSoldAssets != null)
                                                    ? creditor.SeizedAndSoldAssets
                                                    : seizedItems,

                            AttachmentOfEarnings = (creditor.AttachmentOfEarnings != null)
                                                    ? creditor.AttachmentOfEarnings
                                                    : earnings
                        };

                        if (creditor.AmountYouOwe.RequiresReason)
                        {
                            newcreditor.Reason = string.Join(", ", creditor.ReasonForDebt.AsList().ToArray());
                        }

                        result.Add(newcreditor);
                    }

                }

                //Banks
                if (BankAccountDetails != null)
                {
                    foreach (
                        var bank in
                            BankAccountDetails.MainPageBankAccountSummaries.Where(
                                x => x.AccountDetails.CurrentBalance < 0))
                    {
                        var newcreditor = new UnsecuredCreditorNewVm
                        {
                            Name = bank.AccountDetails.BankDetails.BankName,
                            Address = bank.AccountDetails.BankDetails.AddressLine1, //todo
                            Reference = bank.AccountDetails.AccountNumber,
                            AmountOwed = bank.AccountDetails.CurrentBalance.Value,
                            DateIncurred = bank.AccountDetails.DateOpened.ToString(),
                            Reason = "Overdraft",
                            DebtType = string.Empty                   
                        };


                        result.Add(newcreditor);
                    }
                }

                return result.OrderBy(x => x.Name).ToList();
            }
        }

        public IList<PolicyMain> PolicyMains { get; set; }
        public PolicyDetail PolicyDetail { get; set; }

        public List<PolicyBeneficiaryDetail> PolicyBeneficiaryDetail { get; set; }

        public PolicyValue PolicyValue { get; set; }
        
        public decimal? GrandTotalIncome
        {            
            get
            {
                decimal? totalSelfEmployedExpenses = SelfEmployedBusinessIncome?.Profit ?? 0;
                decimal? totalWages = Wages?.Where(q => q.Total.HasValue).Sum(q => q.Total.Value) ?? 0;
                decimal? totalBenefits = Benefits?.Total ?? 0;
                decimal? totalPensions = Pension?.Total ?? 0;
                decimal? totalOtherContributions = ContributionsFromOthers?.Total ?? 0;
                decimal? totalOtherIncomes = OtherIncomes?.Where(q => q.Total.HasValue).Sum(q => q.Total.Value) ?? 0;
                
                return totalSelfEmployedExpenses + totalWages + totalBenefits + totalPensions + totalOtherContributions + totalOtherIncomes;
            }
        }

        public decimal? GrandTotalExpense
        {
            get
           {
                var tHomeUtilities = HomeUtilities?.Total ?? 0;
                var tPensionInsuranceHealthcare = PensionInsuranceHealthcare?.Total ?? 0;
                var tHousekeepingDetails = HousekeepingDetails?.Total ?? 0;
                var tTransport = Transport?.Total ?? 0;
                var tChildcareAndMaintenance = ChildcareAndMaintenance?.Total ?? 0;
                var tPersonalLeisureExpenses = PersonalLeisureExpenses?.Total ?? 0;
                var tSavingsFinesOtherCosts = SavingsFinesOtherCosts?.Total ?? 0;

                return tHomeUtilities + tPensionInsuranceHealthcare + tHousekeepingDetails + tTransport + tChildcareAndMaintenance + tPersonalLeisureExpenses + tSavingsFinesOtherCosts;
            }
        }

        public string BKTReference { get; set; }

        public RecoveriesSummary Recoveries { get; set; }
    }

    public class UnsecuredCreditorNewVm
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Reference { get; set; }
        public decimal AmountOwed { get; set; }
        public string DateIncurred { get; set; }
        public string Reason { get; set; }
        public string DebtType { get; set; }

        //Seized or sold assets
        public DateTime DateAgentsVisited { get; set; }  
        public string WasSeizedItemSld { get; set; }
        public IList<SeizedAndSoldAssets> SeizedAndSoldAssets { get; set; }
        public AttachmentOfEarnings AttachmentOfEarnings { get; set; }
        
    } 
}