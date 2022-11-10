using System;
using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Employment.SelfEmployments
{
    public class BusinessDetailsViewModel
    {
        public string BusinessName { get; set; }

        public bool? DoesTheBusinessHaveDebtsUnderOtherNames { get; set; }

        public List<string> OtherNames { get; set; }

        public string BusinessType { get; set; }

        public DateTime? TradingStartDate { get; set; }

        public DateTime? TradingEndDate { get; set; }
    }
}