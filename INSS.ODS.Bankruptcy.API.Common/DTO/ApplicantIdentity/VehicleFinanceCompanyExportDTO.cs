using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class VehicleFinanceCompanyExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string SourceRef { get; set; }

        [DataMember]
        public AddressExportDTO Address { get; set; }

        [DataMember]
        public bool IsVehicleReturnedorRepossessed { get; set; }
    }
}