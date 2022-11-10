using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Import.V1
{
    public class Assets
    {
        public decimal? HowMuchCash { get; set; }

        public decimal? BankBalance { get; set; }

        public decimal? MoneyYouAreOwed { get; set; }

        public bool? HaveEssentialTools { get; set; }

        public List<EssentialTool> EssentialTools { get; set; }

        public bool? MotorVehicles { get; set; }

        public bool? OwnHome { get; set; }

        public bool? OwnOtherProperty { get; set; }

        public bool? HasUnrealisedAssets { get; set; }


        public string VehicleMake { get; set; }

        public string VehicleModel { get; set; }

        public string VehicleRegistration { get; set; }

        public int? VehicleYearOfRegistration { get; set; }

        public string VehicleCondition { get; set; }

        public decimal? VehicleValue { get; set; }


        public decimal? ValueOfHome { get; set; }

        public decimal? ValueOfOtherProperty { get; set; }

        public List<UnrealisedAsset> UnrealisedAssets { get; set; }
    }
}
