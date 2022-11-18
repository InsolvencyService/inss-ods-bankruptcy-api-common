using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Creditors;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Creditors;

[DataContract]
public class SeizedAndSoldAssets: ISeizedAndSoldAssets, ITableBase
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string ItemName { get; set; }

    [DataMember]
    public decimal? ItemValue { get; set; }

    [DataMember]
    public bool? ItemSold { get; set; }





}
