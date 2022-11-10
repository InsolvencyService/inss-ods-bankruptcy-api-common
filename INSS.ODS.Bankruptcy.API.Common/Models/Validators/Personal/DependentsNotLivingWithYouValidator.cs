using System;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using INSS.ODS.Bankruptcy.API.Common.Resources.Personal;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class DependentsNotLivingWithYouValidator<T> : CompositeValidator<IDependentsNotLivingWithYou<T>> where T : IAddress
    {
        public DependentsNotLivingWithYouValidator()
        {
            RegisterBaseValidator(new FirstNameValidator());
            RegisterBaseValidator(new LastNameValidator());

            RuleFor(x => x.Age)
             .Cascade(CascadeMode.StopOnFirstFailure)
             .NotEmpty()
             .WithLocalizedMessage(() => AddDependantResources.Personal_AddDependant_Age_Error_Empty)
             .InclusiveBetween(0, 150)
             .WithLocalizedMessage(() => AddDependantResources.Personal_AddDependant_Age_Error_Range);

            RuleFor(x => x.Relationship)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithLocalizedMessage(() => AddDependantResources.Personal_AddDependant_Relationship_Error_Empty)
                .NotEmpty()
                .WithLocalizedMessage(() => AddDependantResources.Personal_AddDependant_Relationship_Error_Empty);

            RuleFor(x => x.RelationshipOther)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithLocalizedMessage(() => AddDependantResources.Personal_AddDependant_Relationship_Error_Empty)
                .NotEmpty()
                .WithLocalizedMessage(() => AddDependantResources.Personal_AddDependant_Relationship_Error_Empty)
                .When(x => x.Relationship == "Other")
                .Length(0, 100)
                .WithLocalizedMessage(() => AddDependantResources.Personal_AddDependant_Relationship_Other_Error_MaxLength);

        }
    }
}