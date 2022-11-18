using INSS.ODS.Bankruptcy.API.Common.Models.Helpers;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

public class HomeUtilities : ITableBase, IHomeUtilities
{
    public int Id { get; set; }
    public decimal? Rent { get; set; }
    public string Rent_Frequency { get; set; }
    public decimal? Mortgage { get; set; }
    public string Mortgage_Frequency { get; set; }
    public decimal? SecuredLoans { get; set; }
    public string SecuredLoans_Frequency { get; set; }
    public decimal? GroundRentServiceCharges { get; set; }
    public string GroundRentServiceCharges_Frequency { get; set; }
    public decimal? BuildingContentInsurance { get; set; }
    public string BuildingContentInsurance_Frequency { get; set; }
    public decimal? ApplicanceFurnitureRental { get; set; }
    public string ApplicanceFurnitureRental_Frequency { get; set; }
    public decimal? TVLicence { get; set; }
    public string TVLicence_Frequency { get; set; }
    public decimal? CouncilTax { get; set; }
    public string CouncilTax_Frequency { get; set; }
    public decimal? Gas { get; set; }
    public string Gas_Frequency { get; set; }
    public decimal? Electricity { get; set; }
    public string Electricity_Frequency { get; set; }
    public decimal? Water { get; set; }
    public string Water_Frequency { get; set; }

    [NotMapped]
    public decimal? Total
    {
        get
        {
            if (IsNotStarted) { return null; }

            return ValueFrequencyNormalisation.Normalise(Rent, Rent_Frequency)
                   + ValueFrequencyNormalisation.Normalise(Mortgage, Mortgage_Frequency)
                   + ValueFrequencyNormalisation.Normalise(SecuredLoans, SecuredLoans_Frequency)
                   + ValueFrequencyNormalisation.Normalise(GroundRentServiceCharges, GroundRentServiceCharges_Frequency)
                   + ValueFrequencyNormalisation.Normalise(BuildingContentInsurance, BuildingContentInsurance_Frequency)
                   + ValueFrequencyNormalisation.Normalise(ApplicanceFurnitureRental, ApplicanceFurnitureRental_Frequency)
                   + ValueFrequencyNormalisation.Normalise(TVLicence, TVLicence_Frequency)
                   + ValueFrequencyNormalisation.Normalise(CouncilTax, CouncilTax_Frequency)
                   + ValueFrequencyNormalisation.Normalise(Gas, Gas_Frequency)
                   + ValueFrequencyNormalisation.Normalise(Electricity, Electricity_Frequency)
                   + ValueFrequencyNormalisation.Normalise(Water, Water_Frequency);
        }
    }

    [NotMapped]
    public bool IsNotStarted
    {
        get
        {
            return Rent == null
                   && Mortgage == null
                   && SecuredLoans == null
                   && GroundRentServiceCharges == null
                   && BuildingContentInsurance == null
                   && ApplicanceFurnitureRental == null
                   && TVLicence == null
                   && CouncilTax == null
                   && Gas == null
                   && Electricity == null
                   && Water == null ;
        }
    }
}