using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class VehicleDetailsExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Make { get; set; }

        [DataMember]
        public string Model { get; set; }

        [DataMember]
        public string RegistrationNumber { get; set; }

        [DataMember]
        public string VehicleType { get; set; }

        [DataMember]
        public string VehicleTypeOther { get; set; }

        [DataMember]
        public string NatureOfInterestInVehicle { get; set; }

        [DataMember]
        public VehicleDisposalInformationExportDTO VehicleDisposalInformation { get; set; }

        [DataMember]
        public VehicleDisposalValueExportDTO VehicleDisposalValue { get; set; }

        [DataMember]
        public OwnVehicleExportDTO OwnVehicle { get; set; }

        [DataMember]
        public OwnVehicleAdditionalDetailsExportDTO OwnVehicleAdditionalDetails { get; set; }

        [DataMember]
        public ThirdPartyVehicleExportDTO ThirdPartyVehicle { get; set; }

        [DataMember]
        public FinanceAgreementExportDTO VehicleFinanceAgreement { get; set; }

        [DataMember]
        public VehicleFinanceCompanyExportDTO VehicleFinanceCompany { get; set; }

        [DataMember]
        public VehicleMotabilityDetailsExportDTO VehicleMotabilityDetails { get; set; }
    }
}