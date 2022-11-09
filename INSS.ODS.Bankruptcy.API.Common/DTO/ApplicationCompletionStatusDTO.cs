using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.DTO
{
    [DataContract]
    public class ApplicationCompletionStatusDTO
    {
        public ApplicationCompletionStatusDTO()
        {
            IncompleteSectionList = new List<string>();
        }

        [DataMember]
        public bool IsComplete { get; set; }

        [DataMember]
        public List<string> IncompleteSectionList { get; set; }
    }
}
