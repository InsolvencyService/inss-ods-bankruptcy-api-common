using INSS.ODS.Bankruptcy.API.Common.Models.Helpers;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[DataContract]
public class ChildcareAndMaintenance : ITableBase, IChildcareAndMaintenance
{
    public int Id { get; set; }
    public decimal? ChildSupport { get; set; }
    public string ChildSupport_Frequency { get; set; }
    public decimal? Childcare { get; set; }
    public string Childcare_Frequency { get; set; }
    public decimal? Nappies { get; set; }
    public string Nappies_Frequency { get; set; }
    public decimal? Prescriptions { get; set; }
    public string Prescriptions_Frequency { get; set; }
    public decimal? Dentistry { get; set; }
    public string Dentistry_Frequency { get; set; }
    public decimal? Uniforms { get; set; }
    public string Uniforms_Frequency { get; set; }
    public decimal? Meals { get; set; }
    public string Meals_Frequency { get; set; }
    public decimal? Trips { get; set; }
    public string Trips_Frequency { get; set; }
    public decimal? Transport { get; set; }
    public string Transport_Frequency { get; set; }
    public decimal? PocketMoney { get; set; }
    public string PocketMoney_Frequency { get; set; }

    [NotMapped]
    public decimal? Total
    {
        get
        {
            if (IsNotStarted) { return null; }
            return
                ValueFrequencyNormalisation.Normalise(ChildSupport, ChildSupport_Frequency)
                + ValueFrequencyNormalisation.Normalise(Childcare, Childcare_Frequency)
                + ValueFrequencyNormalisation.Normalise(Nappies, Nappies_Frequency)
                + ValueFrequencyNormalisation.Normalise(Prescriptions, Prescriptions_Frequency)
                + ValueFrequencyNormalisation.Normalise(Dentistry, Dentistry_Frequency)
                + ValueFrequencyNormalisation.Normalise(Uniforms, Uniforms_Frequency)
                + ValueFrequencyNormalisation.Normalise(Meals, Meals_Frequency)
                + ValueFrequencyNormalisation.Normalise(Trips, Trips_Frequency)
                + ValueFrequencyNormalisation.Normalise(Transport, Transport_Frequency)
                + ValueFrequencyNormalisation.Normalise(PocketMoney, PocketMoney_Frequency);
        }
    }

    [NotMapped]
    public bool IsNotStarted
    {
        get
        {
            return ChildSupport == null
                && Childcare == null
                && Nappies== null
                && Prescriptions == null
                && Prescriptions == null
                && Dentistry== null
                && Uniforms == null
                && Meals == null
                && Trips == null
                && Transport == null
                && PocketMoney == null;
        }
    }
}