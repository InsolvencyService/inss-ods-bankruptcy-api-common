using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.OfficialReceiverExport
{
    public class FinancialStatement
    {
        #region Income

        public decimal? Salary { get; set; }

        public decimal? BenefitsClaimable { get; set; }

        [Obsolete]
        public decimal? BenefitsNotClaimable { get; set; }

        public decimal? Pensions { get; set; }

        public decimal? OtherIncome { get; set; }

        #endregion

        # region Expenditure        

        [Obsolete]
        public decimal? Rent { get; set; }

        [Obsolete]
        public decimal? Mortgage { get; set; }

        [Obsolete]
        public decimal? OtherSecuredLoans { get; set; }

        [Obsolete]
        public decimal? GroundRentandServiceCharges { get; set; }

        [Obsolete]
        public decimal? OtherUtilities { get; set; }

        [Obsolete]
        public decimal? EarningAttachment { get; set; }

        public decimal? CourtFines { get; set; }

        [Obsolete]
        public decimal? ChildSupport { get; set; }

        //AKA: Care and health, Disability and care
        public decimal? AvcPayment { get; set; }

        //AKA: Pensions and Life Insurance
        public decimal? LifeInsurance { get; set; }

        public decimal? ConditionalSale { get; set; }

        [Obsolete]
        public decimal? TvLicense { get; set; }

        //AKA: Communications and Leisure
        public decimal? Telephone { get; set; }

        [Obsolete]
        public decimal? MobilePhone { get; set; }

        public decimal? TravelCost { get; set; }

        //AKA: Food and House Keeping
        public decimal? Housekeeping { get; set; }

        [Obsolete]
        public decimal? Children { get; set; }

        [Obsolete]
        public decimal? Health { get; set; }

        [Obsolete]
        public decimal? Pets { get; set; }

        [Obsolete]
        public decimal? Repair { get; set; }

        [Obsolete]
        public decimal? CarRunningCost { get; set; }

        [Obsolete]
        public decimal? OtherCarCosts { get; set; }

        [Obsolete]
        public decimal? Gas { get; set; }

        [Obsolete]
        public decimal? Electricity { get; set; }

        public decimal? Water { get; set; }

        [Obsolete]
        public decimal? Counciltax { get; set; }

        [Obsolete]
        public decimal? MonthlyOtherExpenses { get; set; }

        [Obsolete]
        public decimal? MortgageEndowmentsAndmpPpi { get; set; }

        [Obsolete]
        public decimal? BuildingAndContentsInsurance { get; set; }

        //AKA: Other Utilities
        public decimal? Utilities { get; set; }

        public decimal? TotalAmountOfDisposableIncome { get; set; }

        [Obsolete]
        public string AdditionalCommentary { get; set; }

        [Obsolete]
        public decimal? MoneyFromOthers { get; set; }

        //AKA: Personal Costs
        public decimal? PersonalCare { get; set; }

        [Obsolete]
        public decimal? SmokingProducts { get; set; }

        [Obsolete]
        public decimal? SchoolUniforms { get; set; }

        [Obsolete]
        public decimal? AfterSchoolClubsAndSchoolTrips { get; set; }

        [Obsolete]
        public decimal? PrescriptionsAndMedication { get; set; }

        [Obsolete]
        public decimal? DentistryAndOpticians { get; set; }

        [Obsolete]
        public decimal? Savings { get; set; }

        //New
        public decimal? HomeAndContents { get; set; }

        //New
        public decimal? SchoolCosts { get; set; }

        //New
        public decimal? OtherEssentialCosts { get; set; }

        //New
        public decimal? OtherFlexibleCosts { get; set; }

        #endregion
    }
}
