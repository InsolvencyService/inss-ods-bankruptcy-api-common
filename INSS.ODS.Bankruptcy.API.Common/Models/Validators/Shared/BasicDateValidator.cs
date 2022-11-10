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
    public class BasicDateValidator : AbstractValidator<DateTime>
    {
        public BasicDateValidator(String emptyErrorMessage, DateTime minimumDate, String minimumDateError)
        {
            RuleFor(x => x.Date)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Must(x => x != default(DateTime))
                .WithMessage(emptyErrorMessage)
                .Must(x => x >= minimumDate)
                .WithMessage(minimumDateError, new String[] { minimumDate.ToString("dd/MM/yyyy")});
        }
    }
}
