using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Creditors;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Creditors;

[DataContract]
public class TypeOfActionTaken: ITypeOfActionTaken, ITableBase
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string TypeOfAction { get; set; }


}
