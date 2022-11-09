using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Employment
{
    public class EmploymentStatusDto
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Status { get; set; }
    }
}
