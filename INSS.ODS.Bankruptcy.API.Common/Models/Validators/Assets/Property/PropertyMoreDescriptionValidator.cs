using FluentValidation;
using FluentValidation.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Property;
using INSS.ODS.Bankruptcy.API.Common.Resources.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class PropertyMoreDescriptionValidator  :  AbstractValidator<IPropertyMoreDescription>
    {
        public PropertyMoreDescriptionValidator()
        {
            RuleFor(r => r.SharedOwnership)
              .NotEmpty()
              .WithMessage(MorePropertyDescriptionResources.Property_MorePropertyDescription_IsShared_Error_Required);

            RuleFor(x => x.Worth)
              .NotEmpty()
              .WithMessage(MorePropertyDescriptionResources.Property_MorePropertyDescription_Worth_Error_Mandatory)
              .InclusiveBetween(1, decimal.MaxValue)
              .WithMessage(MorePropertyDescriptionResources.Property_MorePropertyDescription_Worth_Error_PositiveValueOnly)
              .ScalePrecision(2, 99).WithMessage(MorePropertyDescriptionResources.Property_MorePropertyDescription_Worth_Error_DecimalPlaces);
             
            RuleFor(x => x.PurchaseOrFinanceStartedDate)
            .NotEmpty().WithMessage(MorePropertyDescriptionResources.Property_MorePropertyDescription_Date_Error_Required)
            .LessThanOrEqualTo(DateTime.Today)
            .WithMessage(MorePropertyDescriptionResources.Property_MorePropertyDescription_Date_Error_FutureDateNotAllowed);

            RuleFor(x => x.PurchaseOrFinanceStartedDate)
            .GreaterThanOrEqualTo(new DateTime(1900, 1, 1))
            .WithMessage(MorePropertyDescriptionResources.Property_MorePropertyDescription_Date_Error_MinimumDate)
            .When(x => x.PurchaseOrFinanceStartedDate != DateTime.MinValue);
            
            RuleFor(x => x.NatureOfInterest)
              .NotEmpty()
              .WithMessage(MorePropertyDescriptionResources.Property_MorePropertyDescription_NatureOfInterest_Error_Mandatory);

            RuleFor(r => r.NatureOfInterest)
            .Must(x => false)
            .When(x => (String.IsNullOrWhiteSpace(x.OtherNatureOfInterest)
                  && x.NatureOfInterest == MorePropertyDescriptionResources.Property_MorePropertyDescription_NatureOfInterest_Other))
            .WithMessage(MorePropertyDescriptionResources.Property_MorePropertyDescription_NatureOfInterestOther_Error_Mandatory);

            RuleFor(x => x.NatureOfInterest)
                .Must(x => false)
                .When(x => !string.IsNullOrWhiteSpace(x.OtherNatureOfInterest)
                    && (x.OtherNatureOfInterest.Trim().Length < 3 || x.OtherNatureOfInterest.Trim().Length > 60)
                    && (x.NatureOfInterest == MorePropertyDescriptionResources.Property_MorePropertyDescription_NatureOfInterest_Other))
                    .WithMessage(MorePropertyDescriptionResources.Property_MorePropertyDescription_NatureOfInterestOther_Error_Length);
        }
    }
}