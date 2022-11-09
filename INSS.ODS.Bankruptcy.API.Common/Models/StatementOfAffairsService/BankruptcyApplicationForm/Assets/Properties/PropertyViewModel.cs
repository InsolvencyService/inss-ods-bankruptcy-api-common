using System.Collections.Generic;
using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.Properties
{
    public class PropertyViewModel
    {
        public AddressViewModel Address { get; set; }

        public PropertyDetailsViewModel PropertyDetails { get; set; }

        public TenantOrLodgerDetailsViewModel TenantDetails { get; set; }

        public TenantOrLodgerDetailsViewModel LodgerDetails { get; set; }

        public PropertyAdditionalDetailsViewModel PropertyAdditionalDetails { get; set; }

        public List<PropertyJointOwnerViewModel> JointOwners { get; set; }

        public List<MortgageOrSecuredDebtViewModel> MortgagesOrSecuredDebts { get; set; }
    }
}