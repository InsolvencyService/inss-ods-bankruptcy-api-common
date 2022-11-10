using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.SelfEmployedIncome
{
    public class SelfEmployedIncomeViewModel
    {
        public RecurringPayment NetProfit { get; set; }
        public DateTime? AccountingPeriodStart { get; set; }
        public DateTime? AccountingPeriodEnd { get; set; }
        public decimal? Total { get; set; }
    }
}
