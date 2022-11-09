using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Validator(typeof(BeneficialInterestValidator))]
    [DataContract]
    public class BeneficialInterest : ITableBase, IBeneficialInterest
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public decimal? Amount { get; set; }
    }
}