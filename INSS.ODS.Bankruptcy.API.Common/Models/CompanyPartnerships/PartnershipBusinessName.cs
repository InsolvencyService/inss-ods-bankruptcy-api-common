using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[Serializable]
[DataContract]
public class PartnershipBusinessName : ITableBase, IPartnershipBusinessName
{
    public int Id { get; set; }

    [DataMember]
    public string BusinessName { get; set; }

}
