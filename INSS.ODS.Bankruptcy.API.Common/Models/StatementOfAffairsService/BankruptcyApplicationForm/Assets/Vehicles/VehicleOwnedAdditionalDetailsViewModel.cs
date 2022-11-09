using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.Vehicles
{
    public class VehicleOwnedAdditionalDetailsViewModel
    {
        public bool? IsVehicleKeptAtHomeAddress { get; set; }

        public bool? IsFinanceOutstandingOnVehicle { get; set; }

        public AddressViewModel VehicleKeptAtAddress { get; set; }
    }
}