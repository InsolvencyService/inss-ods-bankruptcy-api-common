using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.DRO.Account;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Validators;

public class LoginRequestValidator : AbstractValidator<LoginRequest>
{
    public LoginRequestValidator()
    {
        RuleFor(r => r.Username)
            .NotEmpty();

        RuleFor(r => r.Password)
            .NotEmpty();
    }
}
