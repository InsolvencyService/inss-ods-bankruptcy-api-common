using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.PensionInsuranceHealthcare
{
    public class PensionInsuranceHealthcareViewModel
    {
        public RecurringPayment PersonalPensionPayments { get; set; }
        public RecurringPayment LifeInsurance { get; set; }
        public RecurringPayment HealthInsurance { get; set; }
        public RecurringPayment PaymentProtectionInsurance { get; set; }
        public RecurringPayment PetInsurance { get; set; }
        public RecurringPayment VeterinaryBills { get; set; }
        public RecurringPayment AdultCareCosts { get; set; }
        public RecurringPayment PrescriptionsAndMedicines { get; set; }
        public RecurringPayment Dentistry { get; set; }
        public RecurringPayment Opticians { get; set; }
        public decimal? Total { get; set; }
    }
}
