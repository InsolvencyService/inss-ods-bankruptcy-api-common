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
    public class CreditorValidator : CompositeValidator<Creditor>
    {
        public CreditorValidator()
        {
            RuleFor(r => r.CreditorName)
            .NotEmpty()
            .WithLocalizedMessage(
            () => CreditorAddressResources.Creditors_CreditorAddress_CreditorName_Error_Mandator);

            RuleFor(r => r.CreditorAddress)
                .SetValidator((new AddressValidator()));

        }
    }
}
