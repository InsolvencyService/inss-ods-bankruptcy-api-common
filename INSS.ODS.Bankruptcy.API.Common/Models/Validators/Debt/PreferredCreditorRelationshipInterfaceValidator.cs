using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Shared.Helpers;
using INSS.ODS.Bankruptcy.API.Common.Resources.Debt;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Debt
{
    public class PreferredCreditorRelationshipInterfaceValidator : AbstractValidator<IPreferredCreditorRelationship>
    {
        public PreferredCreditorRelationshipInterfaceValidator()
        {
            RuleFor(x => x.RelationshipToYou)
              .Cascade(CascadeMode.StopOnFirstFailure)
              .NotEmpty()
              .WithLocalizedMessage(() => PreferredCreditorRelationshipResources.Debt_PreferredCreditorRelationship_Relationship_Error_Required)
              .Must((o, relationshipToYou) => OtherFieldValidationHelper.OtherFieldNotEmpty(relationshipToYou, o.RelationshipToYouOther))
              .WithLocalizedMessage(() => PreferredCreditorRelationshipResources.Debt_PreferredCreditorRelationship_RelationshipOther_Error_Required)
              .Must((o, relationshipToYou) => OtherFieldValidationHelper.OtherFieldHasLengthLessThan(relationshipToYou, o.RelationshipToYouOther, 1))
              .WithLocalizedMessage(() => PreferredCreditorRelationshipResources.Debt_PreferredCreditorRelationship_RelationshipOther_Error_TooShort)
              .Must((o, relationshipToYou) => OtherFieldValidationHelper.OtherFieldHasLengthGreaterThan(relationshipToYou, o.RelationshipToYouOther, 60))
              .WithLocalizedMessage(() => PreferredCreditorRelationshipResources.Debt_PreferredCreditorRelationship_RelationshipOther_Error_TooLong);
        }
    }
}
