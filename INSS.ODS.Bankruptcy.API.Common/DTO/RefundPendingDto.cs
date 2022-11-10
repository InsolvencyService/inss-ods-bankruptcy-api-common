using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.DTO
{
    [DataContract]
    public class RefundPendingDto
    {
        [DataMember]
        public string Urn { get; set; }

        [DataMember]
        public string AdjReference { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public DateTime RejectDate { get; set; }

    }
}
