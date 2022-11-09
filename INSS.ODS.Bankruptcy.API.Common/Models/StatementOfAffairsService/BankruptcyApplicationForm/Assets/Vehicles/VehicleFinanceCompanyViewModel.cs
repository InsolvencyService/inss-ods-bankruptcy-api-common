using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.Vehicles
{
    public class VehicleFinanceCompanyViewModel
    {
        public string FinanceCompanyOrDealershipName { get; set; }

        public bool? IsVehicleReturnedOrRepossessed { get; set; }

        public AddressViewModel Address { get; set; }
        
    }
}