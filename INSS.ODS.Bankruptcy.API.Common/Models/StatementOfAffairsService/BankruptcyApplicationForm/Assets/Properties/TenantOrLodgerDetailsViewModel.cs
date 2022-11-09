using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.Properties
{
    public class TenantOrLodgerDetailsViewModel
    {
        public decimal? IncomeAmount { get; set; }

        public string IncomeFrequency { get; set; }

        public bool? IsManagingAgentUsed { get; set; }

        public ManagingAgentDetailsViewModel ManagingAgentDetails { get; set; }

        public List<PersonNameViewModel> PeopleLivingAtProperty { get; set; }
    }
}