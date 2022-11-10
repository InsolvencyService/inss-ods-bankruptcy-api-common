using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class VehicleMotabilityDetailsExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string MotabilityCRN { get; set; }
    }
}