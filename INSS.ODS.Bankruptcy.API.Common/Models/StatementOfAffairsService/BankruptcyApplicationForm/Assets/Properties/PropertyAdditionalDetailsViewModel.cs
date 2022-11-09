using System;
using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.Properties
{
    public class PropertyAdditionalDetailsViewModel
    {
        public string IsSharedOwnership { get; set; }

        public decimal? OwnershipWorth { get; set; }

        public DateTime? PurchasedOrFinancialInterestStartDate { get; set; }

        public string NatureOfInterest { get; set; }
    }
}