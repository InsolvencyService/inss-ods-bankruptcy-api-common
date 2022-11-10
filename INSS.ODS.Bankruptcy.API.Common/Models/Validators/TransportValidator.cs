using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.Expenses;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class TransportValidator : AbstractValidator<ITransport>
    {
        public TransportValidator()
        {
            RuleFor(x => x.Breakdown_Cover)
                .InclusiveBetween(0, decimal.MaxValue)
                .WithLocalizedMessage(() => TransportResources.Expenses_Transport_Breakdown_Cover_Postive_Error);

            RuleFor(x => x.Fuel_Parking_Toll)
                .InclusiveBetween(0, decimal.MaxValue)
                .WithLocalizedMessage(() => TransportResources.Expenses_Transport_Fuel_Postive_Error);


            RuleFor(x => x.MOT)
                .InclusiveBetween(0, decimal.MaxValue)
                .WithLocalizedMessage(() => TransportResources.Expenses_Transport_MOT_Postive_Error);

            RuleFor(x => x.Public_Transport)
                .InclusiveBetween(0, decimal.MaxValue)
                .WithLocalizedMessage(() => TransportResources.Expenses_Transport_Public_Transport_Postive_Error);

            RuleFor(x => x.Vehicle_Finance)
                .InclusiveBetween(0, decimal.MaxValue)
                .WithLocalizedMessage(() => TransportResources.Expenses_Transport_Vehicle_Finance_Postive_Error);


            RuleFor(x => x.Vehicle_Insurance)
                .InclusiveBetween(0, decimal.MaxValue)
                .WithLocalizedMessage(() => TransportResources.Expenses_Transport_Vehicle_Insurance_Postive_Error);

            RuleFor(x => x.Vehicle_Tax)
                .InclusiveBetween(0, decimal.MaxValue)
                .WithLocalizedMessage(() => TransportResources.Expenses_Transport_Vehicle_Tax_Postive_Error);

        }
    }
}
