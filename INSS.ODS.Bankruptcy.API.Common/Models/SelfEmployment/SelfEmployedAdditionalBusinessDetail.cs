using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Serializable]
    [DataContract]
    [Validator(typeof(SelfEmployedAdditionalBusinessDetailValidator))]
    public class SelfEmployedAdditionalBusinessDetail : ITableBase, ISelfEmployedAdditionalBusinessDetail
    {
        public int Id { get; set; }

        [DataMember]
        public string VATNumber { get; set; }

        [Required]
        [DataMember]
        public string UTR { get; set; }

        [Required]
        [DataMember]
        public string RecordsLocation { get; set; }

    }
}
