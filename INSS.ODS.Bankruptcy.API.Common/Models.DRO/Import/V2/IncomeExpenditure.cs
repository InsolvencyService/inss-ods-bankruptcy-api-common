namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Import.V2
{
    public class IncomeExpenditure
    {
        #region Income

        public decimal? Salary { get; set; }

        public decimal? Benefits { get; set; }

        public decimal? Pensions { get; set; }

        public decimal? OtherIncome { get; set; }

        #endregion

        # region Expenditure   

        public decimal? CourtFines { get; set; }

        public decimal? CareAndHealth { get; set; }

        public decimal? PensionsAndLifeInsurance { get; set; }

        public decimal? ConditionalSale { get; set; }

        public decimal? CommunicationsAndLeisure { get; set; }

        public decimal? TravelCost { get; set; }

        public decimal? FoodAndHousekeeping { get; set; }

        public decimal? Water { get; set; }

        public decimal? OtherUtilities { get; set; }

        public decimal? PersonalCosts { get; set; }

        public decimal? HomeAndContents { get; set; }

        public decimal? SchoolCosts { get; set; }

        public decimal? OtherEssentialCosts { get; set; }

        public decimal? OtherFlexibleCosts { get; set; }

        #endregion
    }
}
