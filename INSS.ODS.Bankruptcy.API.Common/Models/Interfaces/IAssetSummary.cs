using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface IAssetSummary
    {
        [DataMember(IsRequired = true)]
        bool? HasProperty { get; set; }
        [DataMember(IsRequired = true)]
        bool? HasVehicle { get; set; }
        [DataMember(IsRequired = true)]
        bool? HasInsurance { get; set; }
        [DataMember(IsRequired = true)]
        bool? HasOtherAssets { get; set; }
    }
}
