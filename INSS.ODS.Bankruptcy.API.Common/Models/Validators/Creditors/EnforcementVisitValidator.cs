using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Resources.BankAccount;
using INSS.ODS.Bankruptcy.API.Common.Resources.Creditors;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Creditors
{
    public class EnforcementVisitValidator : AbstractValidator<IEnforcementVisit>
    {
        public EnforcementVisitValidator()
        {

            RuleFor(r => r.ItemsSeizedOrSold)
                      .NotEmpty()
                      .WithLocalizedMessage(
                      () => EnforcementVisitResources.Creditors_EnforcementVisit_Assets_SeizedOrSold_Required);

            RuleFor(x => x.VisitDate)
             .NotEmpty().WithLocalizedMessage(() => EnforcementVisitResources.Creditors_EnforcementVisit_VisitDate_Error_Mandatory)
             .LessThanOrEqualTo(DateTime.Today)
             .WithLocalizedMessage(() => EnforcementVisitResources.Creditors_EnforcementVisit_VisitDate_Error_MaxValue);

            RuleFor(x => x.VisitDate)
                .GreaterThanOrEqualTo(new DateTime(1900, 1, 1))
                 .WithLocalizedMessage(() => EnforcementVisitResources.Creditors_EnforcementVisit_VisitDate_Error_MinValue)
                .When(x => x.VisitDate != DateTime.MinValue);

            //RuleFor(x => x.VisitDate)
            //  .GreaterThanOrEqualTo(y => y.DebtStartedDate)
            //   .WithLocalizedMessage(() => EnforcementVisitResources.Creditors_EnforcementVisit_VisitDate_Error_After_DebtStartedDate)
            //    .When(x => x.VisitDate != DateTime.MinValue);
        }
    }
}
