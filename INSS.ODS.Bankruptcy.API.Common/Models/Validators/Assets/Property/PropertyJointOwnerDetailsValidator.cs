using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Property;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class PropertyJointOwnerDetailsValidator : CompositeValidator<IPropertyJointOwnerDetails>
    {
        public PropertyJointOwnerDetailsValidator()
        {
            RegisterBaseValidator(new FirstNameValidator());
            RegisterBaseValidator(new LastNameValidator());

            RuleFor(x => x.Relationship)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithMessage(JointOwnerDetailsResources.Property_JointOwnerDetails_Relationship_Error_Mandatory)
                .NotEmpty()
                .WithMessage(JointOwnerDetailsResources.Property_JointOwnerDetails_Relationship_Error_Mandatory)
                .Length(3, 60)
                .WithMessage(JointOwnerDetailsResources.Property_JointOwnerDetails_RelationshipOther_Error_Length)
                .Must(OtherTextNotEmpty)
                .WithMessage(JointOwnerDetailsResources.Property_JointOwnerDetails_RelationshipOther_Error_Mandatory)
                .Must(OtherTextValidLength)
                .WithMessage(JointOwnerDetailsResources.Property_JointOwnerDetails_RelationshipOther_Error_Length);
                        
            RuleFor(x => x.JointOwnerShare)
              .GreaterThanOrEqualTo(1.00)
              .WithMessage(JointOwnerDetailsResources.Property_JointOwnerDetails__Error_YourShareTooLow)
              .When(r => r.IsSelf);
        }
        private bool OtherTextNotEmpty(IPropertyJointOwnerDetails instance, string relationship)
        {
            //Ignore validation if relationship is not other
            return (relationship != "Other" || !string.IsNullOrWhiteSpace(instance.OtherRelationship));
        }
        private bool OtherTextValidLength(IPropertyJointOwnerDetails instance, string relationship)
        {
            //Ignore validation if relationship is not other
            return (relationship != "Other" || (!string.IsNullOrWhiteSpace(instance.OtherRelationship)
                                                && instance.OtherRelationship.Length >= 3
                                               && instance.OtherRelationship.Length <= 60));
        }       
    }
}