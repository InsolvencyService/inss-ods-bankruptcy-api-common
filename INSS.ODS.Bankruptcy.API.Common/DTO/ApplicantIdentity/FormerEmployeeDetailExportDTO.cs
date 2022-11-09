using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class FormerEmployeeDetailExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public AddressExportDTO FormerEmployeeAddress { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public string Reason { get; set; }
    }
}