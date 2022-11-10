using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.HomeAndUtilities
{
    public class HomeAndUtilitiesViewModel
    {
        public RecurringPayment Rent { get; set; }
        public RecurringPayment Mortgage { get; set; }
        public RecurringPayment SecuredLoans { get; set; }
        public RecurringPayment GroundRentServiceCharges { get; set; }
        public RecurringPayment BuildingContentInsurance { get; set; }
        public RecurringPayment ApplicanceFurnitureRental { get; set; }
        public RecurringPayment TVLicence { get; set; }
        public RecurringPayment CouncilTax { get; set; }
        public RecurringPayment Gas { get; set; }
        public RecurringPayment Electricity { get; set; }
        public RecurringPayment Water { get; set; }
        public decimal? Total { get; set; }
    }
}
