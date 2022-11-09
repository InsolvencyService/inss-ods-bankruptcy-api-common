using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Employment.SelfEmployments
{
    public class SelfEmploymentViewModel
    {
        public BusinessDetailsViewModel BusinessDetails { get; set; }

        public List<BusinessTradingAddressViewModel> BusinessTradingAddresses { get; set; }

        public BusinessAdditionalDetailsViewModel BusinessAdditionalDetails { get; set; }

        public List<BusinessCurrentEmployeeViewModel> CurrentEmployees { get; set; }

        public List<BusinessFormerEmployeeViewModel> FormerEmployees { get; set; }

        public List<BusinessAccountantDetailsViewModel> BusinessAccountants { get; set; }
    }
}