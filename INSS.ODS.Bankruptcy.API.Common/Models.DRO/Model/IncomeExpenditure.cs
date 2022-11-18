namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model;

public class IncomeExpenditure
{
    public decimal? Salary { get; set; }
    public decimal? Benefits { get; set; }
    public decimal? Pensions { get; set; }
    public decimal? Others { get; set; }
    public decimal? OtherIncome { get; set; }


    public decimal? Rent { get; set; }
    public decimal? Mortgage { get; set; }
    public decimal? GroundRentOrServiceCharge { get; set; }
    public decimal? MortgageEndowmentAndMppi { get; set; }
    public decimal? CouncilTax { get; set; }


    public decimal? Gas { get; set; }
    public decimal? Electricity { get; set; }
    public decimal? Water { get; set; }
    public decimal? TvLicence { get; set; }
    public decimal? OtherUtilities { get; set; }


    public decimal? CommunicationsAndLeisure { get; set; }
    public decimal? TravelCosts { get; set; }
    public decimal? HousekeepingCosts { get; set; }
    public decimal? PersonalCare { get; set; }
    public decimal? SmokingProducts { get; set; }


    public decimal? BuildingsAndContentsInsurance { get; set; }
    public decimal? PensionsAndLifeInsurance { get; set; }
    public decimal? HealthInsurance { get; set; }
    public decimal? OtherSecuredLoans { get; set; }


    public decimal? ChildMaintenanceOrSupport { get; set; }
    public decimal? ChildcareCosts { get; set; }
    public decimal? SchoolUniforms { get; set; }
    public decimal? AfterSchoolClubsAndSchoolTrips { get; set; }


    public decimal? DisabilityAndCareCosts { get; set; }
    public decimal? PrescriptionsAndMedication { get; set; }
    public decimal? DentistryAndOpticians { get; set; }


    public decimal? Savings { get; set; }
    public decimal? HirePurchaseConditionalSale { get; set; }
    public decimal? MagistrateCourtFines { get; set; }

    //Below added to legacy SFS
    public decimal? HomeAndContents { get; set; }
    public decimal? SchoolCosts { get; set; }
    public decimal? OtherEssentialCosts { get; set; }
    public decimal? OtherFlexibleCosts { get; set; }

    public decimal TotalFlexibleCost
   {
        get
        {
            decimal totalFlexibleCost = 0.0m;

            if (CommunicationsAndLeisure.HasValue) totalFlexibleCost += CommunicationsAndLeisure.Value;
            if (HousekeepingCosts.HasValue) totalFlexibleCost += HousekeepingCosts.Value;
            if (PersonalCare.HasValue) totalFlexibleCost += PersonalCare.Value;
            if (OtherFlexibleCosts.HasValue) totalFlexibleCost += OtherFlexibleCosts.Value;

            return totalFlexibleCost;                
        }
        set
        {

        }        
       
    }

    public decimal TotalFixedCost
    {
        get
        {
            decimal totalFixedCost = 0.0m;

            if (HomeAndContents.HasValue) totalFixedCost += HomeAndContents.Value;
            if (Water.HasValue) totalFixedCost += Water.Value;
            if (OtherUtilities.HasValue) totalFixedCost += OtherUtilities.Value;
            if (DisabilityAndCareCosts.HasValue) totalFixedCost += DisabilityAndCareCosts.Value;

            if (TravelCosts.HasValue) totalFixedCost += TravelCosts.Value;
            if (SchoolCosts.HasValue) totalFixedCost += SchoolCosts.Value;
            if (PensionsAndLifeInsurance.HasValue) totalFixedCost += PensionsAndLifeInsurance.Value;
            if (HirePurchaseConditionalSale.HasValue) totalFixedCost += HirePurchaseConditionalSale.Value;

            if (MagistrateCourtFines.HasValue) totalFixedCost += MagistrateCourtFines.Value;
            if (OtherEssentialCosts.HasValue) totalFixedCost += OtherEssentialCosts.Value;
            
            return totalFixedCost;
        }
        set
        {

        }


    }
    public bool IsSectionComplete { get; set; }

}
