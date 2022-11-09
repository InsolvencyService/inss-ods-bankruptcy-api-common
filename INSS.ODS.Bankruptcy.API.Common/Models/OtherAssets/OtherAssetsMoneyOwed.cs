using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.OtherAssets;

namespace INSS.ODS.Bankruptcy.API.Common.Models.OtherAssets
{
    [DataContract]
    public class OtherAssetsMoneyOwed : ITableBase, IOtherAssetsMoneyOwed
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Reason { get; set; }
        [DataMember]
        public decimal? Amount { get; set; }
        [DataMember]
        public string WhoOwesYou { get; set; }

        [NotMapped]
        public bool IsEmpty
        {
            get
            {
                return String.IsNullOrWhiteSpace(Reason)
                    && String.IsNullOrWhiteSpace(WhoOwesYou)
                    && !Amount.HasValue;
            }
        }
    }
}
