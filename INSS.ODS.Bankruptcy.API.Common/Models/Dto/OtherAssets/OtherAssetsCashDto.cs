using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.OtherAssets
{
    [DataContract]
    public class OtherAssetsCashDto
    {
        [DataMember]
        public decimal? Amount { get; set; }
    }

}
