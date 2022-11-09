using System.Collections.Generic;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.OtherItems
{
    public class OtherItemsViewModel
    {
        public decimal? BankAccountBalance { get; set; }

        public decimal? CashAmount { get; set; }

        public List<OtherItemDetailViewModel> ItemsOrPossessions { get; set; }

        public List<OtherItemDetailViewModel> CompensationsOrLegalClaims { get; set; }

        public List<OtherItemDetailViewModel> WillsOrTrusts { get; set; }

        public List<OtherItemDetailViewModel> StocksSharesAndInvestments { get; set; }

        public List<OtherItemDetailViewModel> SelfEmployedBusinessAssets { get; set; }

        public List<MoneyYouAreOwedDetailViewModel> MoneyYouAreOwed { get; set; }

        public List<OtherItemDetailViewModel> GeneralItems { get; set; }
    }
}