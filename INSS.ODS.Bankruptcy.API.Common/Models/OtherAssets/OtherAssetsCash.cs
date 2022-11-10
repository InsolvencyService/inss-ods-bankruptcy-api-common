using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.OtherAssets;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.OtherAssets;

namespace INSS.ODS.Bankruptcy.API.Common.Models.OtherAssets
{
    [DataContract]
    [Validator(typeof(OtherAssetsCashValidator))]
    public class OtherAssetsCash : ITableBase, IOtherAssetsCash
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }
    }
}
