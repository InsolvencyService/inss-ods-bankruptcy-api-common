using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class OwnVehicleAdditionalDetailsExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public bool IsVehicleKeptAtHomeAddress { get; set; }

        [DataMember]
        public AddressExportDTO Address { get; set; }

        [DataMember]
        public string IsFinanceOutstanding { get; set; }
    }
}