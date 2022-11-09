using System.Collections.Generic;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class PolicyMainExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string SourceRef { get; set; }

        [DataMember]
        public string ProviderName { get; set; }

        [DataMember]
        public AddressExportDTO ProviderAddress { get; set; }

        [DataMember]
        public PolicyDetailExportDTO PolicyDetail { get; set; }

        [DataMember]
        public PolicyValueExportDTO PolicyValue { get; set; }

        [DataMember]
        public PolicyIncomeExportDTO PolicyIncome { get; set; }

        [DataMember]
        public List<PolicyBeneficiaryDetailExportDTO> PolicyBeneficiaries { get; set; }
    }
}