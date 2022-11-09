using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class OccupancyDetailsExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public AddressExportDTO HomeAddress { get; set; }

        [DataMember]
        public DateTime? DateMovedIn { get; set; }

        [DataMember]
        public DateTime? DateMovedOut { get; set; }

        [DataMember]
        public bool IsCurrentAddress { get; set; }

        [DataMember]
        public string PropertyOwnership { get; set; }

        [DataMember]
        public string PropertyOwnershipOther { get; set; }
    }
}