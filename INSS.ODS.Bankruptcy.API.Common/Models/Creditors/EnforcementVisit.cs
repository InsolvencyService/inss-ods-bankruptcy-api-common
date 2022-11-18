using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Creditors;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Creditors;

[DataContract]
public class EnforcementVisit: IEnforcementVisit, ITableBase
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public DateTime VisitDate { get; set; }

    [DataMember]
    public bool? ItemsSeizedOrSold { get; set; }

    //[NotMapped]
    //public DateTime DebtStartedDate { get; set; }

}
