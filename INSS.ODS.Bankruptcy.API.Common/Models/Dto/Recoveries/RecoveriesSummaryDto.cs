using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Recoveries
{
    [Serializable]
    [DataContract]
    public class RecoveriesSummaryDto
    {
        [DataMember]
        public bool? HasSoldProperties { get; set; }
        [DataMember]
        public bool? HasSoldLifeInsurancePolicies { get; set; }
        [DataMember]
        public bool? HasSoldAssets { get; set; }
    }
}
