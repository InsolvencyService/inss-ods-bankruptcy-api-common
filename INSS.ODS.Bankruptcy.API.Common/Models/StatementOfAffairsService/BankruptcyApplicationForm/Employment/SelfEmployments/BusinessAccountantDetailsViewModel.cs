using System;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Employment.SelfEmployments
{
    public class BusinessAccountantDetailsViewModel
    {
        public string AccountantName { get; set; }

        public AddressViewModel Address { get; set; }

        public DateTime? AccountantUseStartDate { get; set; }

        public DateTime? AccountantUseEndDate { get; set; }
    }
}