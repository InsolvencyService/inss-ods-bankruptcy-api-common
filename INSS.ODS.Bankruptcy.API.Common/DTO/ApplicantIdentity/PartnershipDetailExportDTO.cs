using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class PartnershipDetailExportDTO
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
        public IList<PartnershipBusinessNameExportDTO> BusinessNames { get; set; }

        [DataMember]
        public IList<PartnerDetailExportDTO> PartnersDetails { get; set; }

        [DataMember]
        public IList<PartnershipTradingAddressExportDTO> TradingAddressses { get; set; }

        [DataMember]
        public TaxDetailExportDTO TaxDetail { get; set; }

        [DataMember]
        public IList<PartnershipCurrentEmployeeDetailExportDTO> CurrentEmployees { get; set; }
    }
}