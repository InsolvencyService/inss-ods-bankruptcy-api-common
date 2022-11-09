using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    public class SectionStatusDto
    {
        public SectionCompletionStatus CompletionStatus { get; set; }

        public bool PersonalSectionStarted { get; set; }

        public bool EmploymentSectionStarted { get; set; }

        public bool BankAccountsSectionStarted { get; set; }

        public bool AssetsSectionStarted { get; set; }

        public bool MoneyYouOweSectionStarted { get; set; }

        public bool IncomeAndExpensesSectionStarted { get; set; }

        public bool LegalProceedingsSectionStarted { get; set; }

        public bool DebtHistorySectionStarted { get; set; }

    }
}