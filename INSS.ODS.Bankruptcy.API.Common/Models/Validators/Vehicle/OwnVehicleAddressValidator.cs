using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle;
using INSS.ODS.Bankruptcy.API.Common.Resources.Personal;
using INSS.ODS.Bankruptcy.API.Common.Resources.Vehicle;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Vehicle
{
    public class OwnVehicleAddressValidator : AbstractValidator<IAddress>
    {
        public OwnVehicleAddressValidator()
        {

            RuleFor(r => r.Address_1)
              .Length(0)
              .WithMessage(OwnVehicleResources.Vehicle_OwnVehicle_Address1_Error_NotRequired);

            RuleFor(r => r.Address_2)
               .Length(0)
               .WithMessage(OwnVehicleResources.Vehicle_OwnVehicle_Address2_Error_NotRequired);

            RuleFor(r => r.Address_3)
               .Length(0)
               .WithMessage(OwnVehicleResources.Vehicle_OwnVehicle_Address3_Error_NotRequired);

            RuleFor(r => r.TownCity)
               .Length(0)
               .WithMessage(OwnVehicleResources.Vehicle_OwnVehicle_Towncity_Error_NotRequired);

            RuleFor(r => r.County)
               .Length(0)
               .WithMessage(OwnVehicleResources.Vehicle_OwnVehicle_County_Error_NotRequired);

            RuleFor(r => r.PostCode)
               .Length(0)
               .WithMessage(OwnVehicleResources.Vehicle_OwnVehicle_Postcode_Error_NotRequired);

            RuleFor(r => r.Country)
               .Length(0)
               .WithMessage(OwnVehicleResources.Vehicle_OwnVehicle_Country_Error_NotRequired);
        }
    }
}