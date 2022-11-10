namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.Vehicles
{
    public class VehicleViewModel
    {
        public VehicleDetailsViewModel VehicleDetails { get; set; }

        public VehicleOwnedDetailsViewModel VehicleOwnedDetails { get; set; }

        public VehicleOwnedAdditionalDetailsViewModel VehicleOwnedAdditionalDetails { get; set; }

        public VehicleDisposalDetailsViewModel VehicleDisposalDetails { get; set; }

        public VehicleFinanceCompanyViewModel VehicleFinanceCompany { get; set; }

        public VehicleFinanceAgreementViewModel VehicleFinanceAgreement { get; set; }

        public VehicleThirdPartyDetailsViewModel VehicleThirdPartyDetails { get; set; }

        public VehicleMobilitySchemeDetailsViewModel VehicleMobilitySchemeDetails { get; set; }
    }
}