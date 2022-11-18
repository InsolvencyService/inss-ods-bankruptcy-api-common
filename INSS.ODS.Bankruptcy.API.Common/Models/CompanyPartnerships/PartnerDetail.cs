using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[Serializable]
[DataContract]
public class PartnerDetail : ITableBase, IBusinessPartnerDetail
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public virtual Address PartnerAddress { get; set; }

    [DataMember]
    public string FirstName { get; set; }

    [DataMember]
    public string LastName { get; set; }


}
