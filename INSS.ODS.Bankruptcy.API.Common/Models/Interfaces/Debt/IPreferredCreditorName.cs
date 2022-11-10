using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Debt
{
    public interface IPreferredCreditorName
    {
        [DataMember(IsRequired = true), DataType(DataType.Text)]
        string CreditorName { get; set; }
    }
}
