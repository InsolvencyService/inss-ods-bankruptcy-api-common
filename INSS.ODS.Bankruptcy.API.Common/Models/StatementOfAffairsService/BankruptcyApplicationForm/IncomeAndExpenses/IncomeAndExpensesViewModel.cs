using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.Benefits;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.ChildcareAndMaintenance;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.ContributionsFromOthers;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.HomeAndUtilities;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.Housekeeping;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.OtherIncomes;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.Pension;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.PensionInsuranceHealthcare;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.PersonalLeisure;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.SavingsFinesOtherCosts;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.SelfEmployedIncome;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.Transport;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.Wages;
using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses
{
    public class IncomeAndExpensesViewModel
    {
        public ContributionsFromOthersViewModel ContributionsFromOthers { get; set; }
        public PensionInsuranceHealthcareViewModel PensionInsuranceHealthcare { get; set; }
        public HousekeepingViewModel Housekeeping { get; set; }
        public TransportViewModel Transport { get; set; }
        public ChildcareAndMaintenanceViewModel ChildcareAndMaintenance { get; set; }
        public PersonalLeisureViewModel PersonalLeisure { get; set; }
        public SavingsFinesOtherCostsViewModel SavingsFinesOtherCosts { get; set; }
        public HomeAndUtilitiesViewModel HomeAndUtilities { get; set; }
        public SelfEmployedIncomeViewModel SelfEmployedIncome { get; set; }
        public List<WageViewModel> Wages { get; set; }
        public BenefitsViewModel Benefits { get; set; }
        public PensionViewModel Pension { get; set; }
        public List<OtherIncomeViewModel> OtherIncomes { get; set; }
        public decimal? GrandTotalExpense
        {
            get
            {
                var tHomeAndUtilities = HomeAndUtilities?.Total ?? 0;
                var tPensionInsuranceHealthcare = PensionInsuranceHealthcare?.Total ?? 0;
                var tHousekeeping = Housekeeping?.Total ?? 0;
                var tTransport = Transport?.Total ?? 0;
                var tChildcareAndMaintenance = ChildcareAndMaintenance?.Total ?? 0;
                var tPersonalLeisure = PersonalLeisure?.Total ?? 0;
                var tSavingsFinesOtherCosts = SavingsFinesOtherCosts?.Total ?? 0;

                return tHomeAndUtilities + tPensionInsuranceHealthcare + tHousekeeping + tTransport + tChildcareAndMaintenance + tPersonalLeisure + tSavingsFinesOtherCosts;
            }
        }

        public decimal? GrandTotalIncome
        {
            get
            {
                decimal total = 0;
                total += ContributionsFromOthers?.Total ?? 0;
                total += SelfEmployedIncome?.Total ?? 0;

                if (Wages != null)
                {
                    foreach (var wages in Wages)
                    {
                        total += wages.Total ?? 0;
                    }
                }

                total += Benefits?.Total ?? 0;
                total += Pension?.Total ?? 0;

                if (OtherIncomes != null)
                {
                    foreach(var income in OtherIncomes)
                    {
                        total += income.Total ?? 0;
                    }
                }

                return total;
            }
        }
    }
}