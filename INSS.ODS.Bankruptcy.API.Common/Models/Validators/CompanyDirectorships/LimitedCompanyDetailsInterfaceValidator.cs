using System.Text.RegularExpressions;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Resources.CompanyDirectorships;
using INSS.ODS.API.Common.Utilities.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships
{
    public class LimitedCompanyDetailsInterfaceValidator : AbstractValidator<ILimitedCompanyDetails>
    {
        public LimitedCompanyDetailsInterfaceValidator()
        {
            RuleFor(x => x.CompanyRegistrationNumber)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithMessage(AddLimitedCompanyDetailsResources.CompanyDirectorships_AddLimitedCompanyDetails_CompanyRegistrationNumber_Error_Empty)
                .Length(8)
                .WithMessage(AddLimitedCompanyDetailsResources.CompanyDirectorships_AddLimitedCompanyDetails_CompanyRegistrationNumber_Error_UKInvalidLength)
                .Matches(RegularExpressions.CompanyRegistrationNumber_InvalidCharacters)
                .WithMessage(AddLimitedCompanyDetailsResources.CompanyDirectorships_AddLimitedCompanyDetails_CompanyRegistrationNumber_Error_InvalidCharacters)
                .Matches(RegularExpressions.CompanyRegistrationNumber_UKNotValidNumber)
                .WithMessage(AddLimitedCompanyDetailsResources.CompanyDirectorships_AddLimitedCompanyDetails_CompanyRegistrationNumber_Error_UKNotValidNumber)
                .When(x => x.IsCompanyRegisteredInTheUK.HasValue && x.IsCompanyRegisteredInTheUK.Value);

            RuleFor(x => x.CompanyRegistrationNumber)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Length(4,20)
                .WithMessage(AddLimitedCompanyDetailsResources.CompanyDirectorships_AddLimitedCompanyDetails_CompanyRegistrationNumber_Error_OverseasInvalidLength)
                .Matches(RegularExpressions.CompanyRegistrationNumber_UK)
                .WithMessage(AddLimitedCompanyDetailsResources.CompanyDirectorships_AddLimitedCompanyDetails_CompanyRegistrationNumber_Error_InvalidCharacters)
                .When(x => x.IsCompanyRegisteredInTheUK.HasValue && !x.IsCompanyRegisteredInTheUK.Value && !string.IsNullOrEmpty(x.CompanyRegistrationNumber));

            RuleFor(x => x.CompanyRegistrationCountry)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithMessage(AddLimitedCompanyDetailsResources.CompanyDirectorships_AddLimitedCompanyDetails_CompanyRegistrationCountry_Error_Empty)
                .Length(2, 100)
                .WithMessage(AddLimitedCompanyDetailsResources.CompanyDirectorships_AddLimitedCompanyDetails_CompanyRegistrationCountry_Error_InvalidLength)
                .Matches(RegularExpressions.CompanyRegistrationCountry)
                .WithMessage(AddLimitedCompanyDetailsResources.CompanyDirectorships_AddLimitedCompanyDetails_CompanyRegistrationCountry_Error_InvalidCharacters)
                .When(x => x.IsCompanyRegisteredInTheUK.HasValue && !x.IsCompanyRegisteredInTheUK.Value);

            RuleFor(x => x.IsCompanyRegisteredInTheUK)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithMessage(AddLimitedCompanyDetailsResources.CompanyDirectorships_AddLimitedCompanyDetails_CompanyRegisteredInUK_Error_Empty)
                .When(x => !x.IsCompanyRegisteredInTheUK.HasValue);

            RuleFor(x => x.IsCompanySubjectToInsolvencyProceedings)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithMessage(AddLimitedCompanyDetailsResources.CompanyDirectorships_AddLimitedCompanyDetails_CompanySubjectToInsolvencyProceedings_Error_Empty)
                .When(x => !x.IsCompanySubjectToInsolvencyProceedings.HasValue);

            RuleFor(x => x.AreYouStillAnActiveDirector)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithMessage(AddLimitedCompanyDetailsResources.CompanyDirectorships_AddLimitedCompanyDetails_AreYouActiveDirector_Error_Empty)
                .When(x => !x.AreYouStillAnActiveDirector.HasValue);




            
        }
    }
}