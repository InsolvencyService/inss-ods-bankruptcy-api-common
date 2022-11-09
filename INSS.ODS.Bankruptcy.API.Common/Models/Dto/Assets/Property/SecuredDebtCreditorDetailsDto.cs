using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto
{
    [DataContract]
    public class SecuredDebtCreditorDetailsDto
    {
        [DataMember]
        public string SourceRef { get; set; }

        [DataMember]
        public string CreditorName { get; set; }

        [DataMember]
        public Address CreditorAddress { get; set; }
    }
}
