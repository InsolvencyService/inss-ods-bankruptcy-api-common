using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Constants;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Shared;
using INSS.ODS.API.Common.Utilities.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class FirstNameValidator : AbstractValidator<IFirstName>
    {
        //use 
        public FirstNameValidator() : this(false)
        {

        }
        public FirstNameValidator(bool forApplicant)
        {
            string emptyErrorMessage = forApplicant ? 
                NameResources.Shared_Name_ApplicantFirstName_Error_Empty : 
                NameResources.Shared_Name_FirstName_Error_Empty;

            string maxLengthErrorMessage = forApplicant ?
                NameResources.Shared_Name_ApplicantFirstName_Error_MaxLength :
                NameResources.Shared_Name_FirstName_Error_MaxLength;

            string invalidErrorMessage = forApplicant ?
                NameResources.Shared_Name_ApplicantFirstName_Error_InvalidLetters :
                NameResources.Shared_Name_FirstName_Error_InvalidLetters;

            RuleFor(x => x.FirstName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithMessage(emptyErrorMessage)
                .NotEmpty()
                .WithMessage(emptyErrorMessage)
                .Length(NameValidationConstants.FirstName_MinSize, NameValidationConstants.FirstName_MaxSize)
                .WithMessage(x => $"{maxLengthErrorMessage} { NameValidationConstants.FirstName_MaxSize + 1 }")
                .Matches(RegularExpressions.FirstName_ValidPattern)
                .WithMessage(invalidErrorMessage);
        }
    }
}
