using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Property;
using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class AddPropertyValidator : AbstractValidator<IPropertyAddressPartial>
    {
        public AddPropertyValidator()
        {
            RuleFor(r => r.Firstline)
            .Cascade(CascadeMode.StopOnFirstFailure)
            .NotEmpty()
            .WithLocalizedMessage(() => AddPropertyResources.Property_AddProperty_Error_AnyOneFieldRequired)
            .When(r => String.IsNullOrWhiteSpace(r.Postalcode));
        }
    }
}