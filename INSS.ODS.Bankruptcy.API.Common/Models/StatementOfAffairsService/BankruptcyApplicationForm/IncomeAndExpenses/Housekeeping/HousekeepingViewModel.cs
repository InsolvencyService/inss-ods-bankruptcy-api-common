using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.Housekeeping
{
    public class HousekeepingViewModel
    {
        public RecurringPayment Groceries { get; set; }
        public RecurringPayment Toiletries { get; set; }
        public RecurringPayment Alcohol { get; set; }
        public RecurringPayment MealsAtWork { get; set; }
        public decimal? Total { get; set; }
    }
}
