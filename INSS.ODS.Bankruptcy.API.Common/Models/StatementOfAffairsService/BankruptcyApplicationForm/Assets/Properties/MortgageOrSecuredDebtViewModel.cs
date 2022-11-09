using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.Properties
{
    public class MortgageOrSecuredDebtViewModel
    {
        public string TypeOfDebt { get; set; }

        public string ReferenceNumber { get; set; }

        public DateTime? DebtStartedDate { get; set; }

        public decimal? CreditorAmountOwed { get; set; }

        public string IsJointDebt { get; set; }

        public PropertyCreditorViewModel PropertyCreditor { get; set; }
    }
}