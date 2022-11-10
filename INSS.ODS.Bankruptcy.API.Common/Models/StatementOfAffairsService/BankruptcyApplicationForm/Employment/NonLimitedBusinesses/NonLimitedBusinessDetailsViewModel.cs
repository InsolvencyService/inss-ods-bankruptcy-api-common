using System;
using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Employment.NonLimitedBusinesses
{
    public class NonLimitedBusinessDetailsViewModel
    {
        public string BusinessName { get; set; }

        public bool? DoesTheBusinessHaveDebtsUnderOtherNames { get; set; }

        public List<string> OtherNames { get; set; }

        public string BusinessType { get; set; }

        public DateTime? TradingStartDate { get; set; }

        public DateTime? TradingEndDate { get; set; }
    }
}