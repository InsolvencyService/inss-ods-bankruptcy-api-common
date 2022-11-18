using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Property;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class PropertyDescriptionValidator : AbstractValidator<IPropertyDescription>
    {
        public PropertyDescriptionValidator()
        {
            RuleFor(r => r.PropertyType)
                .NotEmpty()
                .WithMessage(PropertyDescriptionResources.Property_PropertyDescription_PropertyType_Error_Required);

            RuleFor(r => r.PropertyType)
              .Must(x => false)              
              .When(x => (String.IsNullOrWhiteSpace(x.OtherPropertyType)
                    && x.PropertyType == PropertyDescriptionResources.Property_PropertyDescription_PropertyType_Other))
              .WithMessage(PropertyDescriptionResources.Property_PropertyDescription_PropertyTypeOtherField_Error_Required);

            RuleFor(x => x.PropertyType)
                .Must(x => false)
                .When(x => !string.IsNullOrWhiteSpace(x.OtherPropertyType)
                    && (x.OtherPropertyType.Trim().Length < 3 || x.OtherPropertyType.Trim().Length > 60)
                    && (x.PropertyType == PropertyDescriptionResources.Property_PropertyDescription_PropertyType_Other))
                    .WithMessage(PropertyDescriptionResources.Property_PropertyDescription_PropertyTypeOtherField_Error_Length);

            RuleFor(r => r.OwnershipType)
                    .NotEmpty()
                    .WithMessage(PropertyDescriptionResources.Property_PropertyDescription_OwnershipType_Error_Required);

            RuleFor(r => r.BedroomCount)
                    .NotEmpty()
                    .WithMessage(PropertyDescriptionResources.Property_PropertyDescription_BedRoomCount_Error_Required)
                    .InclusiveBetween(1,999)
                    .WithMessage(PropertyDescriptionResources.Property_PropertyDescription_BedRoomCount_Error_InvalidEntry);
           

            RuleFor(r => r.WhoLivesInProperty_FieldsetStart)
                     .Must(x => false)
                        .When(x => x.WhoLivesFormer == false
                        && x.WhoLivesLodger == false
                        && x.WhoLivesSpouse ==  false
                        && x.WhoLivesTenant == false
                        && x.WhoLivesYou == false )
                    .WithMessage(PropertyDescriptionResources.Property_PropertyDescription_WhoLives_Error_Required);            
        }
    }
}