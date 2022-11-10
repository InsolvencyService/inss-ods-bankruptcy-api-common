using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Shared;
using System.Text.RegularExpressions;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class AddressValidator : AbstractValidator<IAddress>
    {
        readonly Regex regExAlphanumericAndSpaces = new Regex("^[A-Za-z0-9 ]*[A-Za-z0-9][A-Za-z0-9 ]*$");

        public AddressValidator() : this(false)
        {
            //Default - Apply rules for other address
        }

        public AddressValidator(bool isApplicantAddress)
        {

            if (isApplicantAddress)
            {
                RuleFor(x => x.Address_1)
                    .NotEmpty()
                    .WithLocalizedMessage(() => AddressResources.Shared_Address_OwnAddress_Address_1_Error_Empty);

                RuleFor(x => x.PostCode)
                    .NotEmpty()
                    .WithLocalizedMessage(() => AddressResources.Shared_Address_OwnAddress_PostCode_Error_Empty)
                    .Length(1, 11)
                    .WithLocalizedMessage(() => AddressResources.Shared_Address_OwnAddress_PostCode_Error_MaxLength)
                    .Matches(regExAlphanumericAndSpaces)
                    .WithLocalizedMessage(() => AddressResources.Shared_Address_OwnAddress_PostCode_Error_SpecialCharacters);

                RuleFor(x => x.Country)
                    .NotEmpty()
                    .WithLocalizedMessage(() => AddressResources.Shared_Address_OwnAddress_Country_Error_Empty);

                RuleFor(x => x.TownCity)
                    .NotEmpty()
                    .WithLocalizedMessage(() => AddressResources.Shared_Address_OwnAddress_TownCity_Error_Empty);
            }
            else
            {
                //Default rules
                RuleFor(x => x.Address_1)
                    .NotEmpty()
                    .WithLocalizedMessage(() => AddressResources.Shared_Address_OtherAddress_Address_1_Error_Empty);

                RuleFor(x => x.PostCode)
                    .NotEmpty()
                    .WithLocalizedMessage(() => AddressResources.Shared_Address_OtherAddress_PostCode_Error_Empty)
                    .Length(1, 11)
                    .WithLocalizedMessage(() => AddressResources.Shared_Address_OtherAddress_PostCode_Error_MaxLength)
                    .Matches(regExAlphanumericAndSpaces)
                    .WithLocalizedMessage(() => AddressResources.Shared_Address_OtherAddress_PostCode_Error_SpecialCharacters);

                RuleFor(x => x.Country)
                    .NotEmpty()
                    .WithLocalizedMessage(() => AddressResources.Shared_Address_OtherAddress_Country_Error_Empty);

                RuleFor(x => x.TownCity)
                    .NotEmpty()
                    .WithLocalizedMessage(() => AddressResources.Shared_Address_OtherAddress_TownCity_Error_Empty);
            }

            //This allows parent to override and apply custom rules using ValidatorInterceptor 
            RuleSet("ApplyParentRules", () => { });
        }
    }
}