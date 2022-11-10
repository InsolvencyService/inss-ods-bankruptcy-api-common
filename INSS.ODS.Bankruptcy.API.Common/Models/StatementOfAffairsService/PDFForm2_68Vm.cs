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

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService
{
    [Serializable]
    public class PDFForm2_68Vm : IApplicantDetails
    {
        [Required]
        public string Urn { get; set; }

        public string FirstName { get; set; }

        public string MiddleNames { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }

        public string ConfirmEmail { get; set; }


        public PersonalDetails PersonalDetails { get; set; }
        public PersonalDetailsAdditional PersonalDetailsAdditional { get; set; }
        public ContactDetails ContactDetails { get; set; }
        public IList<OccupancyDetails> OccupancyDetails { get; set; }

        public IList<OtherName> OtherNames { get; set; }
        public IList<DependentsNotLivingWithYou> Dependents { get; set; }
        public IList<HouseholdMember> HouseholdMembers { get; set; }
        public IList<EmployerDetails> Employers { get; set; }
        public IList<Creditor> Creditors { get; set; }
        public PDFForm2_68_BankAccountDetailsVm BankAccountDetails { get; set; }

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
        public PDFForm2_68_DebtHistoryVm DebtHistory { get; set; }

        public OtherAssetsCash OtherAssetsCash { get; set; }
        public IList<OtherAssetsCompensation> OtherAssetsCompensations { get; set; }
        public IList<OtherAssetsMoneyOwed> OtherAssetsMoniesOwed { get; set; }
        public IList<OtherAssetsSelfEmployedAsset> OtherAssetsSelfEmployedAssets { get; set; }
        public IList<OtherAssetsStock> OtherAssetsStocks { get; set; }
        public IList<OtherAssetsWill>  OtherAssetsWills { get; set; }
        public IList<OtherAssetsPossession> OtherAssetsPossessions { get; set; }
        public IList<OtherAssetsItem> OtherAssetsItems { get; set; }

        public List<UnsecuredCreditorVm> UnsecuredCreditors
        {
            get
            {
                var result = new List<UnsecuredCreditorVm>();

                //Creditors from Money You Owe section
                foreach (var creditor in Creditors.Where(x => x.IsCompleteRecord))
                {
                    var newcreditor = new UnsecuredCreditorVm
                    {
                        Name = creditor.CreditorName,
                        Address = creditor.CreditorAddress.FullAddress,
                        Reference = creditor.AmountYouOwe.Reference,
                        AmountOwed = creditor.AmountYouOwe.Amount ?? 0,
                        DateDebtIncurred = creditor.AmountYouOwe.ApproxDebtStartedDateRange
                    };

                    if (creditor.AmountYouOwe.RequiresReason)
                    {
                        newcreditor.Reason = string.Join(", ", creditor.ReasonForDebt.AsList().ToArray());
                    }

                    result.Add(newcreditor);
                }

                //Banks
                if (BankAccountDetails != null)
                {
                    foreach (
                        var bank in
                            BankAccountDetails.MainPageBankAccountSummaries.Where(
                                x => x.AccountDetails.CurrentBalance < 0))
                    {
                        var newcreditor = new UnsecuredCreditorVm
                        {
                            Name = bank.AccountDetails.BankDetails.BankName,
                            Address = bank.AccountDetails.BankDetails.AddressLine1, //todo
                            Reference = bank.AccountDetails.AccountNumber,
                            AmountOwed = bank.AccountDetails.CurrentBalance.Value,
                            DateDebtIncurred = bank.AccountDetails.DateOpened.ToShortTimeString(),
                            Reason = "Overdraft"
                        };


                        result.Add(newcreditor);
                    }
                }

                return result.OrderBy(x=>x.Name).ToList();
            }
        }
    }

    public class UnsecuredCreditorVm
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Reference { get; set; }
        public decimal AmountOwed { get; set; }
        public string DateDebtIncurred { get; set; }
        public string Reason { get; set; }
    }
}