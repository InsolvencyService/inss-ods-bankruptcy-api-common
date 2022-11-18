using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

public class AssetSummary : ITableBase, IAssetSummary
{
    public int Id { get; set; }
    public bool? HasProperty { get; set; }
    public bool? HasVehicle { get; set; }
    public bool? HasInsurance { get; set; }
    public bool? HasOtherAssets { get; set; }
}
