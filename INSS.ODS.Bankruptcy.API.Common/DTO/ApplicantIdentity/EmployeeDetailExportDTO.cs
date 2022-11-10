using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class EmployeeDetailExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public AddressExportDTO EmployeeAddress { get; set; }

        [DataMember]
        public bool? MoneyOwed { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public SelfEmployedEmployeeMoneyOwedExportDTO SelfEmployedEmployeeMoneyOwed { get; set; }
    }
}