using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using INSS.ODS.Bankruptcy.API.Common.Resources.Personal;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class PersonalDetailsValidators : CompositeValidator<IPersonalDetails>
    {
        public PersonalDetailsValidators()
        {
            RegisterBaseValidator(new FirstNameValidator(true));
            RegisterBaseValidator(new MiddleNamesValidator(true));
            RegisterBaseValidator(new LastNameValidator(true));

            RuleFor(x => x.Title)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithMessage(StartResources.Personal_Start_Title_Error_Empty)
                .NotEmpty()
                .WithMessage(StartResources.Personal_Start_Title_Error_Empty)
                .Must(OtherTitleNotEmpty)
                .WithMessage(StartResources.Personal_Start_Title_Error_Empty)
                .Must(OtherTitleHasValidLength)
                .WithMessage(StartResources.Personal_Start_TitleOther_Error_MaxLength);

            RuleFor(x => x.DateOfBirth)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .SetValidator(new BasicDateValidator(StartResources.Personal_Start_DateOfBirth_Error_Empty,
                new DateTime(1900, 1, 1),
                StartResources.Personal_Start_DateOfBirth_Error_MinimumDate
                ))
                .Must(x => x.AddYears(18) <= DateTime.Today)
                .WithMessage(x => $"{StartResources.Personal_Start_DateOfBirth_Error_MinimumAge} : 18");
        }

        private bool OtherTitleNotEmpty(IPersonalDetails instance, string relationship)
        {
            //Ignore validation if relationship is not other
            return (relationship != "Other" || !string.IsNullOrWhiteSpace(instance.TitleOther));
        }
        private bool OtherTitleHasValidLength(IPersonalDetails instance, string relationship)
        {
            //Ignore validation if relationship is not other
            return (relationship != "Other" || (!string.IsNullOrWhiteSpace(instance.TitleOther)
                                               && instance.TitleOther.Length <= 100));
        }

    }
}