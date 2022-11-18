using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Resources.Common;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class CurrencyValidator : AbstractValidator<decimal?>
    {
        public CurrencyValidator()
        {
            RuleFor(x => x)
                .ScalePrecision(2, 18).WithMessage(ErrorMessagesResources.CurrencyPropertyBinder_Invalid_Format)
                .WithName("Value")
                .When(x => x.HasValue);
        }
    }
}
