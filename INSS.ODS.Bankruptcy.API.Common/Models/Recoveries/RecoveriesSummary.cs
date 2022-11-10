using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Recoveries
{
    [Serializable]
    [DataContract]
    public class RecoveriesSummary : ITableBase
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public bool? HasSoldProperties { get; set; }
        [DataMember]
        public bool? HasSoldLifeInsurancePolicies { get; set; }
        [DataMember]
        public bool? HasSoldAssets { get; set; }
    }
}
