using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class SelfEmployedBusinessDetailExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string BusinessName { get; set; }

        [DataMember]
        public string BusinessType { get; set; }

        [DataMember]
        public DateTime TradingStartedDate { get; set; }

        [DataMember]
        public DateTime? TradingStoppedDate { get; set; }

        [DataMember]
        public IList<SelfEmployedBusinessNameExportDTO> BusinessNames { get; set; }

        [DataMember]
        public IList<SelfEmployedBusinessAddressExportDTO> BusinessAddresses { get; set; }

        [DataMember]
        public SelfEmployedAdditionalBusinessDetailExportDTO AdditionalBusinessDetail { get; set; }

        [DataMember]
        public IList<EmployeeDetailExportDTO> EmployeeDetails { get; set; }

        [DataMember]
        public IList<FormerEmployeeDetailExportDTO> FormerEmployeeDetails { get; set; }

        [DataMember]
        public IList<AccountantDetailExportDTO> AccountantDetails { get; set; }
    }
}