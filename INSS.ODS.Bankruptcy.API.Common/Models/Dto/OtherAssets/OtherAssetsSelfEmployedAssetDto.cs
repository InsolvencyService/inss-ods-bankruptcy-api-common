using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.OtherAssets
{
    [DataContract]
    public class OtherAssetsSelfEmployedAssetDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public decimal? Amount { get; set; }
    }
}
