using System;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Shared;
using INSS.ODS.Bankruptcy.API.Common.Models.Constants;
using INSS.ODS.API.Common.Utilities.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class MiddleNamesValidator : AbstractValidator<IMiddleNames>
    {
        public MiddleNamesValidator() : this(false)
        {

        }

        public MiddleNamesValidator(bool forApplicant)
        {
            string maxLengthErrorMessage = forApplicant ?
                NameResources.Shared_Name_ApplicantMiddleName_Error_MaxLength :
                NameResources.Shared_Name_MiddleName_Error_MaxLength;

            string invalidErrorMessage = forApplicant ?
                NameResources.Shared_Name_ApplicantMiddleName_Error_InvalidLetters :
                NameResources.Shared_Name_MiddleName_Error_InvalidLetters;

            RuleFor(x => x.MiddleNames)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Length(NameValidationConstants.MiddleName_MinSize, NameValidationConstants.MiddleName_MaxSize)
                .WithMessage(maxLengthErrorMessage, new object[] { NameValidationConstants.MiddleName_MaxSize + 1 })
                .Matches(RegularExpressions.MiddleName_ValidPattern_AllowingEmpty)
                .WithMessage(invalidErrorMessage)
                .When(x => !String.IsNullOrEmpty(x.MiddleNames));
        }
    }
}
