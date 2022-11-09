using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class PARVDetailExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string CourtName { get; set; }
        
        [DataMember]
        public DateTime ApprovedDate { get; set; }
    }
}