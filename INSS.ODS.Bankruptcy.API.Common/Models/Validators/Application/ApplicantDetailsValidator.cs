using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources;
using INSS.ODS.Bankruptcy.API.Common.Resources.Application;
using System;
using System.Collections.Generic;
using System.Linq;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class ApplicantDetailsValidator : CompositeValidator<IApplicantDetails>
    {
        public ApplicantDetailsValidator()
        {

            RegisterBaseValidator(new FirstNameValidator(true));
            RegisterBaseValidator(new LastNameValidator(true));
            RegisterBaseValidator(new MiddleNamesValidator(true));

            RuleFor(x => x.DateOfBirth)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .SetValidator(new BasicDateValidator(StartResources.Application_Start_DateOfBirth_Error_Empty, 
                new DateTime(1900, 1, 1), 
                StartResources.Application_Start_DateOfBirth_Error_MinimumDate
                ))
                .Must(x => x.AddYears(18) <= DateTime.Today)
                .WithLocalizedMessage(() => StartResources.Application_Start_DateOfBirth_Error_MinimumAge, new object[]{ 18 });


            RuleFor(x => x.ConfirmEmail)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithLocalizedMessage(() => StartResources.Application_Start_ConfirmEmail_Error_Empty)
                .NotEmpty()
                .WithLocalizedMessage(() => StartResources.Application_Start_ConfirmEmail_Error_Empty)
            .When(x => !String.IsNullOrEmpty(x.Email));


            RuleFor(x => x.ConfirmEmail)
                .Must(x => false)
                .When(x => !String.IsNullOrEmpty(x.ConfirmEmail) && !String.IsNullOrEmpty(x.Email) && x.Email != x.ConfirmEmail)
                .WithLocalizedMessage(() => StartResources.Application_Start_ConfirmEmail_Error_EmailMismatch);



            RuleFor(x => x.ConfirmEmail)
                .Cascade(CascadeMode.StopOnFirstFailure)
                   .Must(x => String.IsNullOrEmpty(x))
                  .When(x => String.IsNullOrEmpty(x.Email))
                  .WithLocalizedMessage(() => StartResources.Application_Start_ConfirmEmail_Error_Not_Madatory);

        }
    }

}