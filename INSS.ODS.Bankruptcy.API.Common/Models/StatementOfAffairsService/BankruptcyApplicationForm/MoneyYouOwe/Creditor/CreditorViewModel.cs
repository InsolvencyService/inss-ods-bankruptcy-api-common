using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.MoneyYouOwe.EnforcementVisit;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.MoneyYouOwe.Creditor
{
    public class CreditorViewModel
    {
        public string CreditorName { get; set; }
        public AddressViewModel CreditorAddress { get; set; }
        public Decimal AmountOwed { get; set; }
        public string Reference { get; set; }
        public string DebtType { get; set; }
        public string DebtTypeOther { get; set; }
        public string ReasonForDebt { get; set; }
        public string ApproxDebtStartedDateRange { get; set; }
        public string DateIncurred { get; set; }
        public EnforcementVisitViewModel EnforcementVisit { get; set; }
        public RecurringPayment AttachmentOfEarnings { get; set; }
    }
}
