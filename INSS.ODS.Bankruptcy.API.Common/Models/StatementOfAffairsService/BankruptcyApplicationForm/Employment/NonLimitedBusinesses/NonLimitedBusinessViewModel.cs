using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Employment.NonLimitedBusinesses
{
    public class NonLimitedBusinessViewModel
    {
        public NonLimitedBusinessDetailsViewModel BusinessDetails { get; set; }

        public List<NonLimitedBusinessPartnerViewModel> BusinessPartners { get; set; }

        public List<NonLimitedBusinessTradingAddressViewModel> BusinessTradingAddresses { get; set; }

        public NonLimitedBusinessAdditionalDetailsViewModel BusinessAdditionalDetails { get; set; }
    }
}