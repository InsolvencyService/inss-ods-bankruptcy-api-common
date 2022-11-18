using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Property;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class ManagingAgentAddressValidator : AbstractValidator<IManagingAgentAddress>
    {
        public ManagingAgentAddressValidator()
        {
            RuleFor(r => r.AgentName)
              .Cascade(CascadeMode.StopOnFirstFailure)
              .NotEmpty()
              .WithMessage(ManagingAgentAddressResources.Property_ManagingAgentAddress_Name_Error_Manadatory)
              .Length(3, 100)
              .WithMessage(ManagingAgentAddressResources.Property_ManagingAgentAddress_Name_Error_Length);

            RuleFor(x => x.AgentAddress)
            .SetValidator(new AddressValidator());
        }           
    }
}