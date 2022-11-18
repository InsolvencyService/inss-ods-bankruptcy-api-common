using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Personal;
using INSS.ODS.API.Common.Utilities.Constants;
using System.Linq;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class ContactDetailsInterfaceValidator : AbstractValidator<IContactDetails>
    {
        public ContactDetailsInterfaceValidator()
        {
            RuleFor(x => x.Email)
                .EmailAddress()
                .WithMessage(ContactResources.Personal_Contact_Email_Invalid_Error)
                .When(x => !string.IsNullOrEmpty(x.Email));

            RuleFor(x => x.Mobile)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Must(x => x.Count(char.IsDigit) >= 10)
                .WithMessage(ContactResources.Personal_Contact_Mobile_Error_MinLength)
                .Must(x => x.Count(char.IsDigit) <= 50)
                .WithMessage(ContactResources.Personal_Contact_Mobile_Error_MaxLength)
                .Matches(RegularExpressions.TelephoneNumber_ValidPattern)
                .WithMessage(ContactResources.Personal_Contact_Mobile_Error_Format)
                .When(x => !string.IsNullOrEmpty(x.Mobile));

            RuleFor(x => x.Mobile)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithMessage(ContactResources.Personal_Contact_TelephoneOrMobile_Error_Required)
                .When(x => string.IsNullOrEmpty(x.Telephone));

            RuleFor(x => x.Telephone)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Must(x => x.Count(char.IsDigit) >= 10)
                .WithMessage(ContactResources.Personal_Contact_Telephone_Error_MinLength)
                .Must(x => x.Count(char.IsDigit) <= 50)
                .WithMessage(ContactResources.Personal_Contact_Telephone_Error_MaxLength)
                .Matches(RegularExpressions.TelephoneNumber_ValidPattern)
                .WithMessage(ContactResources.Personal_Contact_Telephone_Error_Format)
                .When(x => !string.IsNullOrEmpty(x.Telephone));

            RuleFor(x => x.Telephone)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithMessage(ContactResources.Personal_Contact_TelephoneOrMobile_Error_Required)
                .When(x => string.IsNullOrEmpty(x.Mobile));
        }

    }
}