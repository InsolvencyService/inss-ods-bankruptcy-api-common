using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Payments
{
    [DataContract]
    public class SendAdjReferenceDto
    {
        [DataMember]
        public string AdjReference { get; set; }

        [DataMember]
        public string Email { get; set; }


        [DataMember]
        public string FirstName { get; set; }


        [DataMember]
        public string LastName { get; set; }


        [DataMember]
        public string Url { get; set; }
    }
}
