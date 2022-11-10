using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.Transport
{
    public class AdditionalTransportViewModel
    {
        public string Description { get; set; }
        public RecurringPayment Cost { get; set; }
    }
}
