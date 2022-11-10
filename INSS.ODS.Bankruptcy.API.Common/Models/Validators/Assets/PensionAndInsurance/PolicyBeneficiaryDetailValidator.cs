using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.PensionAndInsurance;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class PolicyBeneficiaryDetailValidator : CompositeValidator<IPolicyBeneficiaryDetail>
    {
        public PolicyBeneficiaryDetailValidator()
        {
            RegisterBaseValidator(new FirstNameValidator());
            RegisterBaseValidator(new LastNameValidator());

            RuleFor(x => x.Relationship)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithLocalizedMessage(() => PolicyBeneficiaryDetailResources.PensionAndInsurance_PolicyBeneficiaryDetail_Relationship_Error_Empty)
                .NotEmpty()
                .WithLocalizedMessage(() => PolicyBeneficiaryDetailResources.PensionAndInsurance_PolicyBeneficiaryDetail_Relationship_Error_Empty)
                .Length(3, 60)
                .WithLocalizedMessage(() => PolicyBeneficiaryDetailResources.PensionAndInsurance_PolicyBeneficiaryDetail_RelationshipOther_Error_InvalidLength)
                .Must(OtherTextNotEmpty)
                .WithLocalizedMessage(() => PolicyBeneficiaryDetailResources.PensionAndInsurance_PolicyBeneficiaryDetail_RelationshipOther_Error_Empty)
                .Must(OtherTextValidLength)
                .WithLocalizedMessage(() => PolicyBeneficiaryDetailResources.PensionAndInsurance_PolicyBeneficiaryDetail_RelationshipOther_Error_InvalidLength);

            RuleFor(x => x.BeneficiaryShare)
                .GreaterThanOrEqualTo(1.00)
                .WithLocalizedMessage(() => PolicyBeneficiaryDetailResources.PensionAndInsurance_PolicyBeneficiaryDetail_RelationshipOther_Error_YourShareTooLow)
                .When(r => r.IsSelf);
        }
        private bool OtherTextNotEmpty(IPolicyBeneficiaryDetail instance, string relationship)
        {
            //Ignore validation if relationship is not other
            return (relationship != "Other" || !string.IsNullOrWhiteSpace(instance.RelationshipOther));
        }
        private bool OtherTextValidLength(IPolicyBeneficiaryDetail instance, string relationship)
        {
            //Ignore validation if relationship is not other
            return (relationship != "Other" || (!string.IsNullOrWhiteSpace(instance.RelationshipOther)
                                                && instance.RelationshipOther.Length >= 3
                                               && instance.RelationshipOther.Length <= 60));
        }
    }

}
