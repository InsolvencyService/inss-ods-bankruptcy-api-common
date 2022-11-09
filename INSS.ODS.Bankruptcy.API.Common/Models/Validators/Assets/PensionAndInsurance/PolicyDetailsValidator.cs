using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.PensionAndInsurance;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class PolicyDetailsValidator : AbstractValidator<IPolicyDetail>
    {
        public PolicyDetailsValidator()
        {

            RuleFor(x => x.PolicyType)
                .NotNull()
                .WithLocalizedMessage(() => PolicyProviderDetailsResources.PensionAndInsurance_PolicyProviderDetails_PolicyType_Error_Empty);

            RuleFor(x => x.PolicyType)
                .Must(x => false)
                .When(x => x.PolicyType == "Other")
                .Unless(x => !String.IsNullOrWhiteSpace(x.PolicyTypeOther))
                .WithLocalizedMessage(() => PolicyProviderDetailsResources.PensionAndInsurance_PolicyProviderDetails_PolicyType_Error_Empty);

            RuleFor(x => x.PolicyType)
                .Must(x => false)
                .When(x => x.PolicyType == "Other" && !String.IsNullOrWhiteSpace(x.PolicyTypeOther))
                .Unless(x => x.PolicyTypeOther != null && x.PolicyTypeOther.Length >= 3)
                .WithLocalizedMessage(() => PolicyProviderDetailsResources.PensionAndInsurance_PolicyProviderDetails_PolicyType_TooLong_Or_Short);

            RuleFor(x => x.PolicyType)
                .Must(x => false)
                .When(x => x.PolicyType == "Other" && !String.IsNullOrWhiteSpace(x.PolicyTypeOther))
                .Unless(x => x.PolicyTypeOther != null && x.PolicyTypeOther.Length <= 30)
                .WithLocalizedMessage(() => PolicyProviderDetailsResources.PensionAndInsurance_PolicyProviderDetails_PolicyType_TooLong_Or_Short);

            RuleFor(x => x.CommencementDate)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithLocalizedMessage(() => PolicyProviderDetailsResources.PensionAndInsurance_PolicyProviderDetails_CommencementDate_Error_Empty);

            RuleFor(x => x.PolicyReferenceNo)
                .Length(0, 30)
                .WithLocalizedMessage(() => PolicyProviderDetailsResources.PensionAndInsurance_PolicyProviderDetails_PolicyReferenceNo_TooLong)
                .When(y => !string.IsNullOrWhiteSpace(y.PolicyReferenceNo));

        }
    }
}
