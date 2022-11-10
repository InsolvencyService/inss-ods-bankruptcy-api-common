using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;

namespace INSS.ODS.Bankruptcy.API.Common.Models.OtherAssets
{
    public class OtherAssetsSummaryInfo: ITableBase
    {
        public int Id { get; set; }
        public bool Cash { get; set; }
        public bool Possessions { get; set; }
        public bool Compensations { get; set; }
        public bool Wills { get; set; }
        public bool Stocks { get; set; }
        public bool SelfEmployedAssets { get; set; }
        public bool MoneyOwed { get; set; }
        public bool Items { get; set; }
    }
}
