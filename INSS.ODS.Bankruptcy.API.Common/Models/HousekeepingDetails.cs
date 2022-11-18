using INSS.ODS.Bankruptcy.API.Common.Models.Helpers;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[DataContract]
public class HousekeepingDetails : ITableBase, IHousekeepingDetails
{

    public int Id
    { 
        get; set; 
    }

    public decimal? Groceries
    {
        get; set;
    }

    public string Groceries_Frequency
    {
        get; set;
    }

    public decimal? Toiletries
    {
        get; set;
    }

    public string Toiletries_Frequency
    {
        get;
        set;
    }

    public decimal? Alcohol
    {
        get; set;
    }

    public string Alcohol_Frequency
    {
        get; set;
    }

    public decimal? MealsAtWork
    {
        get; set;
    }

    public string MealsAtWork_Frequency
    {
        get; set;
    }

    [NotMapped]
    public decimal? Total
    {
        get
        {
            if (IsNotStarted) { return null; }
            return ValueFrequencyNormalisation.Normalise(Groceries, Groceries_Frequency)
                   + ValueFrequencyNormalisation.Normalise(Toiletries, Toiletries_Frequency)
                   + ValueFrequencyNormalisation.Normalise(Alcohol, Alcohol_Frequency)
                   + ValueFrequencyNormalisation.Normalise(MealsAtWork, MealsAtWork_Frequency);
        }
    }

    [NotMapped]
    public bool IsNotStarted
    {
        get
        {
            return Groceries == null
                   && Toiletries == null
                   && Alcohol == null
                   && MealsAtWork == null;
        }
    }
}