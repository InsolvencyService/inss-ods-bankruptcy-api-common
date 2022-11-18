using INSS.ODS.Bankruptcy.API.Common.Models.Helpers;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[DataContract]
public class PensionInsuranceHealthcare : ITableBase, IPensionInsuranceHealthcare
{

    public int Id
    { 
        get; 
        set; 
    }


    public decimal? PersonalPensionPayments
    {
        get;
        set;
    }

    public string PersonalPensionPayments_Frequency
    {
        get;
        set;
    }

    public decimal? LifeInsurance
    {
        get;
        set;
    }

    public string LifeInsurance_Frequency
    {
        get;
        set;
    }
    public decimal? HealthInsurance
    {
        get;
        set;
    }

    public string HealthInsurance_Frequency
    {
        get;
        set;
    }

    public decimal? PaymentProtectionInsurance
    {
        get;
        set;
    }

    public string PaymentProtectionInsurance_Frequency
    {
        get;
        set;
    }

    public decimal? PetInsurance
    {
        get;
        set;
    }
    public string PetInsurance_Frequency
    {
        get;
        set;
    }

    public decimal? VeterinaryBills
    {
        get;
        set;
    }

    public string VeterinaryBills_Frequency
    {
        get;
        set;
    }

    public decimal? AdultCareCosts
    {
        get;
        set;
    }

    public string AdultCareCosts_Frequency
    {
        get;
        set;
    }

    public decimal? PrescriptionsAndMedicines
    {
        get;
        set;
    }

    public string PrescriptionsAndMedicines_Frequency
    {
        get;
        set;
    }

    public decimal? Dentistry
    {
        get;
        set;
    }

    public string Dentistry_Frequency
    {
        get;
        set;
    }

    public decimal? Opticians
    {
        get;
        set;
    }

    public string Opticians_Frequency
    {
        get;
        set;
    }

    [NotMapped]
    public decimal? Total
    {
        get
        {
            if (IsNotStarted) { return null; }
            return
                ValueFrequencyNormalisation.Normalise(PersonalPensionPayments, PersonalPensionPayments_Frequency)
                + ValueFrequencyNormalisation.Normalise(LifeInsurance, LifeInsurance_Frequency)
                + ValueFrequencyNormalisation.Normalise(HealthInsurance, HealthInsurance_Frequency)
                + ValueFrequencyNormalisation.Normalise(PaymentProtectionInsurance, PaymentProtectionInsurance_Frequency)
                + ValueFrequencyNormalisation.Normalise(PetInsurance, PetInsurance_Frequency)
                + ValueFrequencyNormalisation.Normalise(VeterinaryBills, VeterinaryBills_Frequency)
                + ValueFrequencyNormalisation.Normalise(AdultCareCosts, AdultCareCosts_Frequency)
                + ValueFrequencyNormalisation.Normalise(PrescriptionsAndMedicines, PrescriptionsAndMedicines_Frequency)
                + ValueFrequencyNormalisation.Normalise(Dentistry, Dentistry_Frequency)
                + ValueFrequencyNormalisation.Normalise(Opticians, Opticians_Frequency);
        }
    }

    [NotMapped]
    public bool IsNotStarted
    {
        get
        {
            return
                PersonalPensionPayments == null
                && LifeInsurance == null
                && HealthInsurance == null
                && PaymentProtectionInsurance == null
                && PetInsurance == null
                && VeterinaryBills == null
                && AdultCareCosts == null
                && PrescriptionsAndMedicines == null
                && Dentistry == null
                && Opticians == null;
        }
    }
}