using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.ChildcareAndMaintenance
{
    public class ChildcareAndMaintenanceViewModel
    {
        public RecurringPayment ChildSupport { get; set; }
        public RecurringPayment Childcare { get; set; }
        public RecurringPayment Nappies { get; set; }
        public RecurringPayment Prescriptions { get; set; }
        public RecurringPayment Dentistry { get; set; }
        public RecurringPayment Uniforms { get; set; }
        public RecurringPayment Meals { get; set; }
        public RecurringPayment Trips { get; set; }
        public RecurringPayment Transport { get; set; }
        public RecurringPayment PocketMoney { get; set; }
        public decimal? Total { get; set; }
    }
}
