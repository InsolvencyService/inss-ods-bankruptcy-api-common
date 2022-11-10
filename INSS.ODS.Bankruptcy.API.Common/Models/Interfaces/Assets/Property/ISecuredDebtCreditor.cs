using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Interfaces
{
    public interface ISecuredDebtCreditor
    {
        [DataMember]
        string SourceRef { get; set; }

        [DataMember]
        string CreditorName { get; set; }

        [DataMember]
        Address CreditorAddress { get; set; }

        [DataMember]
        int PropertyId { get; set; }
    }
}