using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class TypeOfActionTakenExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string TypeOfAction { get; set; }
    }
}