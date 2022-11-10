using INSS.ODS.Bankruptcy.API.Common.Models.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Creditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Creditors
{
    [DataContract]
    public class CreditorDto : ICreditor
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string SourceRef { get; set; }
        [DataMember]
        public string CreditorName { get; set; }

        [DataMember]
        public Address CreditorAddress { get; set; }

        [DataMember]
        public bool AddressNotKnown { get; set; }

    }
}
