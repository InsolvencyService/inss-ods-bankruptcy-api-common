using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.PersonalLeisure
{
    public class PersonalLeisureViewModel
    {
        public RecurringPayment ClothingAndFootwear { get; set; }
        public RecurringPayment Hairdressing { get; set; }
        public RecurringPayment HomePhoneInternetAndTV { get; set; }
        public RecurringPayment MobilePhone { get; set; }
        public RecurringPayment LaundryAndDryCleaning { get; set; }
        public RecurringPayment HobbiesLeisureAndSport { get; set; }
        public RecurringPayment NewspapersAndMagazines { get; set; }
        public RecurringPayment Gifts { get; set; }
        public RecurringPayment Smoking { get; set; }
        public decimal? Total { get; set; }
    }
}
