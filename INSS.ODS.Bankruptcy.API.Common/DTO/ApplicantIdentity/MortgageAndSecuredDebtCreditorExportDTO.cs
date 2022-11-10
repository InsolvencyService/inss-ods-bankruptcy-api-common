using System.Collections.Generic;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class MortgageAndSecuredDebtCreditorExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string SourceRef { get; set; }

        [DataMember]
        public string CreditorName { get; set; }

        [DataMember]
        public AddressExportDTO CreditorAddress { get; set; }

        [DataMember]
        public int PropertyId { get; set; }

        [DataMember]
        public List<PropertyDebtDetailsExportDTO> Debts { get; set; }
    }
}