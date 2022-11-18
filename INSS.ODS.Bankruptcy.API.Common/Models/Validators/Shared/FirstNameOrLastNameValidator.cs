using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Constants;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Shared;
using System;
using INSS.ODS.API.Common.Utilities.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class FirstNameOrLastNameValidator : CompositeValidator<IFirstNameLastNamePartial>
    {
        public FirstNameOrLastNameValidator()
        {
            RuleFor(x => x.FirstName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Must(AtleastOneNameNotEmpty)
                .WithMessage(NameResources.Shared_Name_Error_FirstNameOrLastNameRequired)
                .Length(0, NameValidationConstants.FirstName_MaxSize)
                .WithMessage(x => $"{NameResources.Shared_Name_FirstName_Error_MaxLength} {NameValidationConstants.FirstName_MaxSize + 1}")
                .Matches(RegularExpressions.FirstName_ValidPattern_AllowingEmpty)
                .WithMessage(NameResources.Shared_Name_FirstName_Error_InvalidLetters);

            RuleFor(x => x.LastName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Must(AtleastOneNameNotEmpty)
                .WithMessage(NameResources.Shared_Name_Error_FirstNameOrLastNameRequired)
                .Length(0, NameValidationConstants.LastName_MaxSize)
                .WithMessage(x => $"{NameResources.Shared_Name_LastName_Error_MaxLength} { NameValidationConstants.LastName_MaxSize + 1 }")
                .Matches(RegularExpressions.LastName_ValidPattern_AllowingEmpty)
                .WithMessage(NameResources.Shared_Name_LastName_Error_InvalidLetters);
        }

        private bool AtleastOneNameNotEmpty(IFirstNameLastNamePartial instance, String firstName)
        {
            return !(String.IsNullOrWhiteSpace(instance.FirstName) && String.IsNullOrWhiteSpace(instance.LastName));
        }
    }
}