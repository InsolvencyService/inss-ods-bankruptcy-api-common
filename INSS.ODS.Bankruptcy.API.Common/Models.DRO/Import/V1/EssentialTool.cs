using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Import.V1
{
    public class EssentialTool
    {
        public string Description { get; set; }

        public string Condition { get; set; }

        public DateTime? DatePurchased { get; set; }

        public decimal? Value { get; set; }
    }
}