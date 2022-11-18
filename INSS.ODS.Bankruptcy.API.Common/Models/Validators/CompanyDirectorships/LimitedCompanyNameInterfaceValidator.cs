using System.Text.RegularExpressions;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Resources.CompanyDirectorships;
using INSS.ODS.API.Common.Utilities.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships
{
    public class LimitedCompanyNameInterfaceValidator : AbstractValidator<ILimitedCompanyName>
    {
        public LimitedCompanyNameInterfaceValidator()
        {
            var regex = RegularExpressions.LimitedCompanyName1;

            RuleFor(x => x.LimitedCompanyName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithMessage(AddLimitedCompanyNameResources.CompanyDirectorships_AddLimitedCompanyName_CompanyName_Error_Empty)
                .Must(limitedCompanyName => HaveLengthGreaterThan(limitedCompanyName, 2))
                .WithMessage(AddLimitedCompanyNameResources.CompanyDirectorships_AddLimitedCompanyName_CompanyName_Error_TooShort)
                .Must(limitedCompanyName => HaveLengthLessThan(limitedCompanyName, 101))
                .WithMessage(AddLimitedCompanyNameResources.CompanyDirectorships_AddLimitedCompanyName_CompanyName_Error_TooLong)
                .Matches(RegularExpressions.LimitedCompanyName2)
                .WithMessage(x => $"{AddLimitedCompanyNameResources.CompanyDirectorships_AddLimitedCompanyName_CompanyName_Error_InvalidCharacter} {Regex.Match(x.LimitedCompanyName, regex)}")
                .Matches(RegularExpressions.LimitedCompanyMustContain, RegexOptions.IgnoreCase)
                .WithMessage(AddLimitedCompanyNameResources.CompanyDirectorships_AddLimitedCompanyName_CompanyName_Error_IncorrectEnding);


        }

        private bool HaveLengthGreaterThan(string value, int length)
        {
            return value.Length > length;
        }

        private bool HaveLengthLessThan(string value, int length)
        {
            return value.Length < length;
        }
    }
}