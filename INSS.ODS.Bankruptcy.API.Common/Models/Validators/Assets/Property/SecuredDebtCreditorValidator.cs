using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class SecuredDebtCreditorValidator : AbstractValidator<ISecuredDebtCreditor>
    {
        public SecuredDebtCreditorValidator()
        {
            RuleFor(r => r.CreditorName)
           .NotEmpty()
           .WithMessage(SecuredDebtResources.Property_SecuredDebt_CreditorName_Error_Empty);

            RuleFor(x => x.CreditorAddress)
                .SetValidator(new AddressValidator());
        }
    }
}