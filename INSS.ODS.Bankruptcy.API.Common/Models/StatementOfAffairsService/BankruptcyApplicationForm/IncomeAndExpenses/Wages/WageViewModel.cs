using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.Wages
{
    public class WageViewModel
    {
        public RecurringPayment NetIncome { get; set; }
        public RecurringPayment IncomeTax { get; set; }
        public RecurringPayment OverTime { get; set; }
        public RecurringPayment Bonus { get; set; }
        public RecurringPayment OtherPayments { get; set; }
        public decimal? Total { get; set; }
    }
}
