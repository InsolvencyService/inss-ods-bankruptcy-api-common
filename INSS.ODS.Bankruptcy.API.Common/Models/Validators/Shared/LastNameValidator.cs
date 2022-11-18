using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Shared;
using INSS.ODS.Bankruptcy.API.Common.Models.Constants;
using INSS.ODS.API.Common.Utilities.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class LastNameValidator : AbstractValidator<ILastName>
    {
        public LastNameValidator() : this(false)
        {

        }
        public LastNameValidator(bool forApplicant)
        {
            string emptyErrorMessage = forApplicant ?
                NameResources.Shared_Name_ApplicantLastName_Error_Empty :
                NameResources.Shared_Name_LastName_Error_Empty;

            string maxLengthErrorMessage = forApplicant ?
                NameResources.Shared_Name_ApplicantLastName_Error_MaxLength :
                NameResources.Shared_Name_LastName_Error_MaxLength;

            string invalidErrorMessage = forApplicant ?
                NameResources.Shared_Name_ApplicantLastName_Error_InvalidLetters :
                NameResources.Shared_Name_LastName_Error_InvalidLetters;

            RuleFor(x => x.LastName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithMessage(emptyErrorMessage)
                .NotEmpty()
                .WithMessage(emptyErrorMessage)
                .Length(NameValidationConstants.LastName_MinSize, NameValidationConstants.LastName_MaxSize)
                .WithMessage(x => $"{maxLengthErrorMessage} { NameValidationConstants.LastName_MaxSize + 1 }")
                .Matches(RegularExpressions.LastName_ValidPattern)
                .WithMessage(invalidErrorMessage);
        }
    }
}
