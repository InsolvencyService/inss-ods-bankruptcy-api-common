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
    public class TypeOfActionTakenValidator : AbstractValidator<ITypeOfActionTaken>
    {
        public TypeOfActionTakenValidator()
        {
            RuleFor(r => r.TypeOfAction)
            .NotNull()
            .WithMessage(TypeOfActionTakenResources.Creditors_TypeOfAction_ActionType_Required_Error);



        }
    }
}
