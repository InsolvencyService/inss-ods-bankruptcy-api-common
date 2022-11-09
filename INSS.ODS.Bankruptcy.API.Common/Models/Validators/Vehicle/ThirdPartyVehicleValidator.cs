using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle;
using INSS.ODS.Bankruptcy.API.Common.Resources.Vehicle;
using INSS.ODS.API.Common.Utilities.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Vehicle
{
    public class ThirdPartyVehicleValidator : AbstractValidator<IThirdPartyVehicle>
    {
        public ThirdPartyVehicleValidator()
        {
          
            RuleFor(r => r.RelationshipType)
                .NotEmpty().WithLocalizedMessage(() => ThirdPartyVehicleResources.Vehicle_ThirdPartyVehicle_RelationshipType_Error_Madatory);

            RuleFor(x => x.RelationshipType)
              .Must(x => false)
              .When(x =>  !string.IsNullOrWhiteSpace(x.RelationshipTypeOther)
                            && (x.RelationshipTypeOther.Trim().Length < 3 || x.RelationshipTypeOther.Trim().Length > 60)
                            && (x.RelationshipType == ThirdPartyVehicleResources.Vehicle_ThirdPartyVehicle_RelationshipType_Other))
              .WithLocalizedMessage(() => ThirdPartyVehicleResources.Vehicle_ThirdPartyVehicle_RelationshipTypeOtherText_Error_Length);

            RuleFor(x => x.RelationshipType)
             .Must(x => false)
             .When(x => string.IsNullOrWhiteSpace(x.RelationshipTypeOther)                            
                            && (x.RelationshipType == ThirdPartyVehicleResources.Vehicle_ThirdPartyVehicle_RelationshipType_Other))
             .WithLocalizedMessage(() => ThirdPartyVehicleResources.Vehicle_ThirdPartyVehicle_RelationshipTypeOtherText_Error_Madatory);

            RuleFor(x => x.OwnerName)           
           .NotEmpty()
           .WithLocalizedMessage(() => ThirdPartyVehicleResources.Vehicle_ThirdPartyVehicle_OwnerName_Error_Madatory)
           .Length(2, 179)
           .WithLocalizedMessage(() => ThirdPartyVehicleResources.Vehicle_ThirdPartyVehicle_OwnerName_Error_InvalidLength)
           .Matches(RegularExpressions.VehicleOwnersNameInvalid)
           .WithLocalizedMessage(() => ThirdPartyVehicleResources.Vehicle_ThirdPartyVehicle_OwnerName__Error_InvalidCharacters);


        }
    }
}