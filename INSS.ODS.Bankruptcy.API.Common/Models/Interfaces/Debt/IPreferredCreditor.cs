using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Debt
{
    public interface IPreferredCreditor : IPreferredCreditorName
    {
        [DataMember(IsRequired = false), DataType(DataType.Text)]
        string SourceRef { get; set; }

        [DataMember]
        Address CreditorAddress { get; set; }
    }
}
