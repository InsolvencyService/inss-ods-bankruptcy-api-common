using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class PropertyMoreDescriptionExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string NatureOfInterest { get; set; }

        [DataMember]
        public string OtherNatureOfInterest { get; set; }

        [DataMember]
        public DateTime PurchaseOrFinanceStartedDate { get; set; }

        [DataMember]
        public string SharedOwnership { get; set; }

        [DataMember]
        public decimal? Worth { get; set; }
    }
}