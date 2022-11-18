using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[Serializable]
[DataContract]
public class TaxDetail : ITableBase, ITaxDetail
{
    [DataMember]
    public int Id { get; set; }


    [DataMember]
    public string UTR{ get; set; }




}
