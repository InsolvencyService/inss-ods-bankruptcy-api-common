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
            RuleFor(x => x.LimitedCompanyName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithLocalizedMessage(() => AddLimitedCompanyNameResources.CompanyDirectorships_AddLimitedCompanyName_CompanyName_Error_Empty)
                .Must(limitedCompanyName => HaveLengthGreaterThan(limitedCompanyName, 2))
                .WithLocalizedMessage(() => AddLimitedCompanyNameResources.CompanyDirectorships_AddLimitedCompanyName_CompanyName_Error_TooShort)
                .Must(limitedCompanyName => HaveLengthLessThan(limitedCompanyName, 101))
                .WithLocalizedMessage(() => AddLimitedCompanyNameResources.CompanyDirectorships_AddLimitedCompanyName_CompanyName_Error_TooLong)
                .Matches(RegularExpressions.LimitedCompanyName2)
                .WithLocalizedMessage(() => AddLimitedCompanyNameResources.CompanyDirectorships_AddLimitedCompanyName_CompanyName_Error_InvalidCharacter,
                    c =>
                    {
                        var regex = RegularExpressions.LimitedCompanyName1;
                        var matchedResult = Regex.Match(c.LimitedCompanyName, regex);
                        return matchedResult;
                    })
                .Matches(RegularExpressions.LimitedCompanyMustContain, RegexOptions.IgnoreCase)
                .WithLocalizedMessage(() => AddLimitedCompanyNameResources.CompanyDirectorships_AddLimitedCompanyName_CompanyName_Error_IncorrectEnding);


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