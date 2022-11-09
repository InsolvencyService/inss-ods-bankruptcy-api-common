using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class PartnershipCurrentEmployeeDetailExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public AddressExportDTO CurrentEmployeeAddress { get; set; }

        [DataMember]
        public bool? MoneyOwed { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }
    }
}