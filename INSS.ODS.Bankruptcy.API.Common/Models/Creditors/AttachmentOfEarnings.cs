using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Creditors;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Creditors;

[DataContract]
public class AttachmentOfEarnings: IAttachmentOfEarnings, ITableBase
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string HowOftenTaken{ get; set; }

    [DataMember]
    public decimal? AmountTaken { get; set; }



}
