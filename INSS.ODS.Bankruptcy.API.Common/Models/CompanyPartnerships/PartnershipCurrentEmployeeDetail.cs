using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[Serializable]
[DataContract]
public class PartnershipCurrentEmployeeDetail : ITableBase, IPartnershipCurrentEmployeeDetail
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public virtual Address CurrentEmployeeAddress { get; set; }


    [DataMember]
    public bool? MoneyOwed { get; set; }

    [DataMember]
    public string FirstName { get; set; }

    [DataMember]
    public string LastName { get; set; }


}
