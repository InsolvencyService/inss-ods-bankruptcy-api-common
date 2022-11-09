using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.OfficialReceiverExport
{
    public class Asset
    {
        public decimal? CashInHand { get; set; }
        public decimal? CashAtBank { get; set; }
        public decimal? MoneyOwed { get; set; }
        public decimal? VehicleValue { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int? YearOfFirstRegistration { get; set; }
        public string RegistrationNumber { get; set; }
        public string Condition { get; set; }
        public bool? LeaseholdProperty { get; set; }
        public decimal? PropertyValue { get; set; }
        public string Commentary { get; set; }
        public List<RealisableAsset> RealisableAssets { get; set; }
        public List<EssentialTool> EssentialTools { get; set; }
        public bool? OwnHome { get; set; }

        public decimal? ValueOfHome { get; set; }

        public decimal TotalAssets
        {
            get
            {
                decimal total = 0;

                if (CashInHand.HasValue) total += CashInHand.Value;
                if (CashAtBank.HasValue) total += CashAtBank.Value;
                if (MoneyOwed.HasValue) total += MoneyOwed.Value;

                if (RealisableAssets != null)
                {
                    foreach (RealisableAsset realisableAsset in RealisableAssets)
                    {
                        total += realisableAsset.AssetValue;
                    }
                }

                return total;
            }
        }
    }
}
