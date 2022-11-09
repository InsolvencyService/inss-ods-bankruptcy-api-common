using System.Text.RegularExpressions;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Resources.CompanyPartnerships;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.CompanyPartnerships;
using INSS.ODS.API.Common.Utilities.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyPartnerships
{
    public class SummaryInterfaceValidator : AbstractValidator<ISummary>
    {
        public SummaryInterfaceValidator()
        {
            RuleFor(x => x.PartnershipName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithLocalizedMessage(() => SummaryResources.Summary_PartnershipName_Required)
                .Must(partnershipname => HaveLengthGreaterThan(partnershipname, 0))
                .WithLocalizedMessage(() => SummaryResources.Summary_PartnershipName_TooShort)
                .Must(partnershipname => HaveLengthLessThan(partnershipname, 100))
                .WithLocalizedMessage(() => SummaryResources.Summary_PartnershipName_TooLong)
                .Matches(RegularExpressions.PartnershipName2)
                .WithLocalizedMessage(() => SummaryResources.Summary_PartnershipName_Invalid,
                    c =>
                    {
                        var regex = RegularExpressions.PartnershipName1;
                        var matchedResult = Regex.Match(c.PartnershipName, regex);
                        return matchedResult;
                    });
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