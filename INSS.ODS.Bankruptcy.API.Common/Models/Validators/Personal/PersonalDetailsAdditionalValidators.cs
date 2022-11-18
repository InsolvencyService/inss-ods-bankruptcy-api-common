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
                .WithMessage(StartResources.Personal_Start_NationalInsuranceNumber_Error_Empty)
                .NotEmpty()
                .WithMessage(StartResources.Personal_Start_NationalInsuranceNumber_Error_Empty)
                .Matches(RegularExpressions.NationalInsuranceNumberValidFormat, RegexOptions.IgnoreCase)
                .WithMessage(StartResources.Personal_Start_NationalInsuranceNumber_Error_InvalidFormat);

            RuleFor(x => x.RelationshipStatus)
                .NotNull()
                .WithMessage(StartResources.Personal_Start_RelationshipStatus_Error_Empty);

            RuleFor(x => x.Gender)
                .NotNull()
                .WithMessage(StartResources.Personal_Start_Gender_Error_Empty);
        }
    }
}