using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.BankAccount;
using INSS.ODS.Bankruptcy.API.Common.Resources.Employment;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class EmployerDetailsValidator : AbstractValidator<IEmployerDetails>
    {
        public EmployerDetailsValidator()
        {

            RuleFor(x => x.EmployerName)
               .NotEmpty().WithMessage(EmployersDetailsResources.Employment_EmployersDetails_EmployersName_Required);
            RuleFor(x => x.EmployerAddress).SetValidator(new AddressValidator());

            RuleFor(x => x.DateStarted)
                .NotNull()
                .Must(BeAValidDate)
                .WithMessage(EmployersDetailsResources.Employment_EmployersDetails_DateStarted_Required)
                .Must(x => x.Value >= new DateTime(1900, 1, 1))
                .WithMessage(EmployersDetailsResources.Employment_EmployersDetails_DateStarted_Error_MinimumDate)
                .LessThanOrEqualTo(DateTime.Today)
                .WithMessage(EmployersDetailsResources.Employment_EmployersDetails_DateStarted_Error_MaximumDate);

            RuleFor(m => m.DateStopped)
                .GreaterThan(m => m.DateStarted.Value)
                .WithMessage(EmployersDetailsResources.Employment_EmployersDetails_DateStopped_Before_DateStarted_Error)
                .LessThanOrEqualTo(DateTime.Today)
                .WithMessage(EmployersDetailsResources.Employment_EmployersDetails_DateStopped_Error_MaximumDate)
                .When(m => m.DateStarted.HasValue && m.DateStopped.HasValue);
        }

        private bool BeAValidDate(DateTime? date)
        {
            if (!date.HasValue || date == default(DateTime))
                return false;
            return true;
        }
    }
}

