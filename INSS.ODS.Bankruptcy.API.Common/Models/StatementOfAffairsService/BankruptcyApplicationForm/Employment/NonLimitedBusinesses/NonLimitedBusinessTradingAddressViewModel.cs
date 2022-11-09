using System;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Employment.NonLimitedBusinesses
{
    public class NonLimitedBusinessTradingAddressViewModel
    {
        public DateTime? TradingStartDate { get; set; }

        public DateTime? TradingEndDate { get; set; }

        public AddressViewModel Address { get; set; }
    }
}