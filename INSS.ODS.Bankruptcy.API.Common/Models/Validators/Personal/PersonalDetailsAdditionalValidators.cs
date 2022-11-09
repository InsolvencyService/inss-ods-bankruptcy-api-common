using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Personal;
using INSS.ODS.API.Common.Utilities.Constants;
using System.Text.RegularExpressions;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class PersonalDetailsAdditionalValidators : CompositeValidator<IPersonalDetailsAdditional>
    {
        public PersonalDetailsAdditionalValidators()
        {
            RuleFor(x => x.NationalInsuranceNumber)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithLocalizedMessage(() => StartResources.Personal_Start_NationalInsuranceNumber_Error_Empty)
                .NotEmpty()
                .WithLocalizedMessage(() => StartResources.Personal_Start_NationalInsuranceNumber_Error_Empty)
                .Matches(RegularExpressions.NationalInsuranceNumberValidFormat, RegexOptions.IgnoreCase)
                .WithLocalizedMessage(() => StartResources.Personal_Start_NationalInsuranceNumber_Error_InvalidFormat);

            RuleFor(x => x.RelationshipStatus)
                .NotNull()
                .WithLocalizedMessage(() => StartResources.Personal_Start_RelationshipStatus_Error_Empty);

            RuleFor(x => x.Gender)
                .NotNull()
                .WithLocalizedMessage(() => StartResources.Personal_Start_Gender_Error_Empty);
        }
    }
}