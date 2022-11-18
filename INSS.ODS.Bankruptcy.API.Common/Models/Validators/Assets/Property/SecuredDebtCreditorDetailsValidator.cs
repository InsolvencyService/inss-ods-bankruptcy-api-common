using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{   
    public class SecuredDebtCreditorDetailsValidator : AbstractValidator<IPropertyDebtDetails>
    {
        public SecuredDebtCreditorDetailsValidator()
        {
           // RuleFor(r => r.DebtType)
           // .NotEmpty()
           // .WithMessage(SecuredDebtCreditorDetailsResources.PensionAndInsurance_PolicyProviderDetails_PolicyType);

           // RuleFor(r => r.CommencementDate)
           //.NotEmpty()
           //.WithMessage(PolicyProviderDetailsResources.PensionAndInsurance_PolicyProviderDetails_CommencementDate);


        }
    }
}
