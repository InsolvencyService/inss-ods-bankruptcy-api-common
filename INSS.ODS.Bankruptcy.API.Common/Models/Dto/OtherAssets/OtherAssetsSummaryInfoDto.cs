using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.OtherAssets
{
    [DataContract]
    public class OtherAssetsSummaryInfoDto
    {
        [DataMember]
        public bool Cash { get; set; }

        [DataMember]
        public bool Possessions { get; set; }

        [DataMember]
        public bool Compensations { get; set; }

        [DataMember]
        public bool Wills { get; set; }

        [DataMember]
        public bool Stocks { get; set; }

        [DataMember]
        public bool SelfEmployedAssets { get; set; }

        [DataMember]
        public bool MoneyOwed { get; set; }

        [DataMember]
        public bool Items { get; set; }

        [DataMember]
        public decimal BankBalanceValue { get; set; }

        [DataMember]
        public decimal CashValue { get; set; }

        [DataMember]
        public decimal PossessionsValue { get; set; }

        [DataMember]
        public decimal CompensationsValue { get; set; }

        [DataMember]
        public decimal WillsValue { get; set; }

        [DataMember]
        public decimal StocksValue { get; set; }

        [DataMember]
        public decimal SelfEmployedAssetsValue { get; set; }

        [DataMember]
        public decimal MoneyOwedValue { get; set; }

        [DataMember]
        public decimal ItemsValue { get; set; }

        [DataMember]
        public decimal TotalValue
        {
            get
            {
                return BankBalanceValue
                       + CashValue
                       + PossessionsValue
                       + CompensationsValue
                       + WillsValue
                       + StocksValue
                       + SelfEmployedAssetsValue
                       + MoneyOwedValue
                       + ItemsValue;
            }
        }

        [DataMember]
        public List<OtherAssetsPossessionDto> PossessionItems { get; set; }

        [DataMember]
        public List<OtherAssetsCompensationDto> CompensationItems { get; set; }

        [DataMember]
        public List<OtherAssetsWillDto> WillItems { get; set; }

        [DataMember]
        public List<OtherAssetsStockDto> StockItems { get; set; }

        [DataMember]
        public List<OtherAssetsSelfEmployedAssetDto> SelfEmployedAssetItems { get; set; }

        [DataMember]
        public List<OtherAssetsMoneyOwedDto> MoneyOwedItems { get; set; }

        [DataMember]
        public List<OtherAssetsItemDto> OtherItems { get; set; }

    }
}
