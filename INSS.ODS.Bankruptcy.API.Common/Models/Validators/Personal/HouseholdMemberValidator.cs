using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using INSS.ODS.Bankruptcy.API.Common.Resources.Personal;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class HouseholdMemberValidator : CompositeValidator<IHouseholdMember>
    {
        public HouseholdMemberValidator()
        {
            RegisterBaseValidator(new FirstNameValidator());
            RegisterBaseValidator(new LastNameValidator());

            RuleFor(x => x.AgeGroup)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithLocalizedMessage(() => AddHouseholdMemberResources.Personal_AddHouseholdMember_Age_Error_Empty)
                .NotEmpty()
                .WithLocalizedMessage(() => AddHouseholdMemberResources.Personal_AddHouseholdMember_Age_Error_Empty)
                .Length(1, 8);

            RuleFor(x => x.Relationship)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithLocalizedMessage(() => AddHouseholdMemberResources.Personal_AddHouseholdMember_Relationship_Error_Empty)
                .NotEmpty()
                .WithLocalizedMessage(() => AddHouseholdMemberResources.Personal_AddHouseholdMember_Relationship_Error_Empty)
                .Length(1, 39)
                .WithLocalizedMessage(() => AddHouseholdMemberResources.Personal_AddHouseholdMember_RelationshipOther_Error_MaxLength)
                .Must(OtherTextNotEmpty)
                .WithLocalizedMessage(() => AddHouseholdMemberResources.Personal_AddHouseholdMember_Relationship_Error_Empty)
                .Must(OtherTextValidLength)
                .WithLocalizedMessage(() => AddHouseholdMemberResources.Personal_AddHouseholdMember_RelationshipOther_Error_MaxLength);

            RuleFor(x => x.FinanciallyDependentOption)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithLocalizedMessage(() => AddHouseholdMemberResources.Personal_AddHouseholdMember_FinanciallyDependent_Error_Empty)
                .NotEmpty()
                .WithLocalizedMessage(() => AddHouseholdMemberResources.Personal_AddHouseholdMember_FinanciallyDependent_Error_Empty);
        }

        private bool OtherTextNotEmpty(IHouseholdMember instance, string relationship)
        {
            //Ignore validation if relationship is not other
            return (relationship != "Other" || !string.IsNullOrWhiteSpace(instance.RealtionshipOther));
        }
        private bool OtherTextValidLength(IHouseholdMember instance, string relationship)
        {
            //Ignore validation if relationship is not other
            return (relationship != "Other" || (!string.IsNullOrWhiteSpace(instance.RealtionshipOther) 
                                               && instance.RealtionshipOther.Length <= 39));
        }

    }
}