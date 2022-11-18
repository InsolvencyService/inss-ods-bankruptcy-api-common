using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Creditors;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Creditors;

[DataContract]
public class CreditorDetail : ICreditorDetail, ITableBase
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public decimal? Amount { get; set; }

    [DataMember]
    public string Reference { get; set; }

    [DataMember]
    public string DebtType { get; set; }

    [DataMember]
    public string DebtTypeOther { get; set; }

    [NotMapped]
    public bool RequiresReason
    {
        get
        {
            return DebtType == "Credit card/ store card"
                || DebtType == "Personal loan (unsecured)";
        }
    }

}
