using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Serializable]
    [Validator(typeof(PolicyBeneficiaryListValidator<PolicyBeneficiaryDetail>))]
    public class PolicyBeneficiaryList : IPolicyBeneficiaryList<PolicyBeneficiaryDetail>
    {
        public int PolicyMainId { get; set; }
        public List<PolicyBeneficiaryDetail> PolicyBeneficiaries { get; set; }
    }
}
