using System.Collections.Generic;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Employment
{
    public class EmploymentHistoryDto
    {
        [DataMember]
        public List<EmployerDetails> EmploymentHistory{ get; set; }
    }
}
