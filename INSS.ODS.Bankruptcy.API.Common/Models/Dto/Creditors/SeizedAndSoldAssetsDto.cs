using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Models.Creditors;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Creditors
{
    [DataContract]
    public class SeizedAndSoldAssetsDto
    {
        [DataMember]
        public int CreditorId { get; set; }

        [DataMember]
        public string Creditor { get; set; }

        [DataMember]
        public DateTime  EnforcementDate { get; set; }

        [DataMember]
        public decimal? ValueSeized { get; set; }


    }
}
