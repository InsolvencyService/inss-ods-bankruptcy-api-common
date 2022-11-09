using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.BankAccountsAndSavings;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.DebtHistory;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Declaration;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Employment;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.LegalProceedings;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.MoneyYouOwe;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.PersonalDetails;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.SectionCompletionStatus;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm
{
    public class BankruptcyApplicationFormViewModel
    {
        public BankruptcyApplicationFormViewModel()
        {
            CommonData = new CommonDataViewModel();
            CoverSection = new CoverSectionViewModel();
            PersonalDetails = new PersonalDetailsViewModel();
            Employment = new EmploymentViewModel();
            BankAccountsAndSavings = new BankAccountsAndSavingsViewModel();
            Assets = new AssetsViewModel();
            MoneyYouOwe = new MoneyYouOweViewModel();
            IncomeAndExpenses = new IncomeAndExpensesViewModel();
            LegalProceedings = new LegalProceedingsViewModel();
            DebtHistory = new DebtHistoryViewModel();
            Declaration = new DeclarationViewModel();
            SectionCompletionStatus = new SectionCompletionStatusViewModel();
        }

        public CommonDataViewModel CommonData { get; set; }

        public CoverSectionViewModel CoverSection { get; set; }

        public PersonalDetailsViewModel PersonalDetails { get; set; }

        public EmploymentViewModel Employment { get; set; }

        public BankAccountsAndSavingsViewModel BankAccountsAndSavings { get; set; }

        public AssetsViewModel Assets { get; set; }

        public MoneyYouOweViewModel MoneyYouOwe { get; set; }

        public IncomeAndExpensesViewModel IncomeAndExpenses { get; set; }

        public LegalProceedingsViewModel LegalProceedings { get; set; }

        public DebtHistoryViewModel DebtHistory { get; set; }

        public DeclarationViewModel Declaration { get; set; }

        public SectionCompletionStatusViewModel SectionCompletionStatus { get; set; }
    }
}
