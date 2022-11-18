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
using FluentValidation.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Creditors
{
    public class SeizedAndSoldAssetsValidator : AbstractValidator<ISeizedAndSoldAssets>
    {
        public SeizedAndSoldAssetsValidator()
        {
            RuleFor(x => x.ItemValue)
               .NotEmpty().WithMessage(SeizedAndSoldAssetsResources.Creditors_SiezedAndSoldAssetsResources_Item_Worth_Required)
               .GreaterThan(0).WithMessage(SeizedAndSoldAssetsResources.Creditors_SiezedAndSoldAssetsResources_Item_Worth_Error_MinValue)
               .ScalePrecision(2, 99).WithMessage(SeizedAndSoldAssetsResources.Creditors_SiezedAndSoldAssetsResources_Item_Worth_Error_Scale);

            RuleFor(x => x.ItemName)
              .NotEmpty()
                .WithMessage(SeizedAndSoldAssetsResources.Creditors_SiezedAndSoldAssetsResources_Item_Required )
                  .Length(2, 100)
                .WithMessage(SeizedAndSoldAssetsResources.Creditors_SiezedAndSoldAssetsResources_Item_Length);

            RuleFor(r => r.ItemSold)
                    .NotEmpty()
                    .WithMessage(SeizedAndSoldAssetsResources.Creditors_SiezedAndSoldAssetsResources_Item_Sold_Required);



        }
    }
}
