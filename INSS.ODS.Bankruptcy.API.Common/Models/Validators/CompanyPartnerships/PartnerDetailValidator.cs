using System.Text.RegularExpressions;
using FluentValidation;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Resources.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Resources.SelfEmployment;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyPartnerships
{
    public class PartnerDetailValidator : CompositeValidator<IBusinessPartnerDetail>
    {
        public PartnerDetailValidator()
        {
            RegisterBaseValidator(new FirstNameValidator());
            RegisterBaseValidator(new LastNameValidator());


        }
    }
}