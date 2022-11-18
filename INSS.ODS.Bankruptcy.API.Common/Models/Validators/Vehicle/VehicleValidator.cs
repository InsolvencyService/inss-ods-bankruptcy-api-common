using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle;
using INSS.ODS.Bankruptcy.API.Common.Resources.Vehicle;
using System;
using INSS.ODS.API.Common.Utilities.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Vehicle
{
    public class VehicleValidator : AbstractValidator<IVehicleDetails>
    {
        public VehicleValidator()
        {
            RuleFor(r => r.Make)
                .NotEmpty()
                .WithMessage(VehicleResources.Vehicle_Vehicle_MakeModel_Error_AnyOneFieldRequired)
                .When(r => String.IsNullOrWhiteSpace(r.Model));

            RuleFor(r => r.VehicleType)
                .NotEmpty()
                .WithMessage(VehicleResources.Vehicle_Vehicle_VehicleType_Error_Required);

            RuleFor(r => r.VehicleType)
                .Must(x => false)
                .WithMessage(VehicleResources.Vehicle_Vehicle_VehicleTypeOther_Error_Required)
                .When(x => (x.VehicleType == VehicleResources.Vehicle_Vehicle_VehicleType_Other)
                && (String.IsNullOrWhiteSpace(x.VehicleTypeOther)));

            RuleFor(x => x.VehicleType)
                .Must(x => false)
                .When(x => !string.IsNullOrWhiteSpace(x.VehicleTypeOther)
                && (x.VehicleTypeOther.Trim().Length < 3 || x.VehicleTypeOther.Trim().Length > 60)
                && (x.VehicleType == VehicleResources.Vehicle_Vehicle_VehicleType_Other))
                .WithMessage(VehicleResources.Vehicle_Vehicle_VehicleTypeOther_Error_Length);

            RuleFor(r => r.NatureOfInterestInVehicle)
                .NotEmpty()
                .WithMessage(VehicleResources.Vehicle_Vehicle_NatureInterestOfVehicle_Error_Required);

            RuleFor(r => r.RegistrationNumber)
                .NotEmpty()
                .WithMessage(VehicleResources.Vehicle_Vehicle_RegistrationNumber_Error_Required)           
                .Matches(RegularExpressions.Vehicle_AlphaNumericOnly)
                .WithMessage(VehicleResources.Vehicle_Vehicle_RegistrationNumber_Error_AlphaNumericOnly)
                .Length(1, 20)
                .WithMessage(VehicleResources.Vehicle_Vehicle_RegistrationNumber_Error_Length);          
      
        }
    }
}