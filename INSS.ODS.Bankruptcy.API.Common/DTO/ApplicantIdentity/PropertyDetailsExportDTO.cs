using System.Collections.Generic;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class PropertyDetailsExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? ApplicantInterestValueInProperty { get; set; }

        [DataMember]
        public AddressExportDTO PropertyAddress { get; set; }

        [DataMember]
        public PropertyDescriptionExportDTO PropertyDescription { get; set; }

        [DataMember]
        public PropertyMoreDescriptionExportDTO PropertyMoreDescription { get; set; }

        [DataMember]
        public List<PropertyDebtDetailsExportDTO> DebtDetails { get; set; }

        [DataMember]
        public IncomeFromTenantExportDTO IncomeFromTenant { get; set; }

        [DataMember]
        public IncomeFromLodgerExportDTO IncomeFromLodger { get; set; }

        [DataMember]
        public ManagingAgentAddressExportDTO ManagingAgentAddress { get; set; }

        [DataMember]
        public List<PropertyJointOwnerDetailsExportDTO> PropertyJointOwners { get; set; }

        [DataMember]
        public List<PropertyLodgerExportDTO> PropertyLodgers { get; set; }

        [DataMember]
        public List<PropertyTenantExportDTO> PropertyTenants { get; set; }

        [DataMember]
        public BeneficialInterestExportDTO PropertyBeneficialInterest { get; set; }
    }
}