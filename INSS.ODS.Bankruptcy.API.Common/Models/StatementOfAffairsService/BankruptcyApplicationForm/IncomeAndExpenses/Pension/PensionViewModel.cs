using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;
using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.Pension
{
    public class PensionViewModel
    {
        public RecurringPayment State { get; set; }
        public RecurringPayment PensionCredit { get; set; }
        public List<OtherPensionViewModel> OtherPensions { get; set; }
        public decimal? Total { get; set; }

    }
}
