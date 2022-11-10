namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.SectionCompletionStatus
{
    public class SectionCompletionStatusViewModel
    {
        public bool? PersonalSectionComplete { get; set; }
        public bool? EmploymentSectionComplete { get; set; }
        public bool? BankAccountsSectionComplete { get; set; }
        public bool? AssetsSectionComplete { get; set; }
        public bool? MoneyYouOweSectionComplete { get; set; }
        public bool? IncomeAndExpensesSectionComplete { get; set; }
        public bool? LegalProceedingsSectionComplete { get; set; }
        public bool? DebtHistorySectionComplete { get; set; }
    }
}
