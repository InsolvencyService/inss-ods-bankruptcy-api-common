using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class EnforcementVisitExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime VisitDate { get; set; }

        [DataMember]
        public bool? ItemsSeizedOrSold { get; set; }
    }
}