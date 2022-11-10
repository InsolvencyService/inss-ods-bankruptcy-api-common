using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class PartnershipTradingAddressExportDTO
    {
        [DataMember]    
        public int Id { get; set; }

        [DataMember]
        public AddressExportDTO BusinessAddress { get; set; }

        [DataMember]
        public DateTime TradingStartedDate { get; set; }

        [DataMember]
        public DateTime? TradingStoppedDate { get; set; }
    }
}