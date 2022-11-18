using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[DataContract]
public class BeneficialInterest : ITableBase, IBeneficialInterest
{
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public decimal? Amount { get; set; }
}