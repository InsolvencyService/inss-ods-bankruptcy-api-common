using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[Serializable]
[DataContract]
public class MortgageAndSecuredDebtCreditor : ISecuredDebtCreditor, ITableBase
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string SourceRef { get; set; }

    [DataMember]
    public string CreditorName { get; set; }
    
    [DataMember]
    public virtual Address CreditorAddress { get; set; }

    [DataMember]
    public int PropertyId { get; set; }

    [DataMember]
    public virtual List<PropertyDebtDetails> Debts { get; set; }

}