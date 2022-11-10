using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class CreditorActionExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public Boolean? ActionValue { get; set; }
    }
}