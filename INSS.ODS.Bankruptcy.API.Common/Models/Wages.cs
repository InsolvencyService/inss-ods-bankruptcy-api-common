using INSS.ODS.Bankruptcy.API.Common.Models.Helpers;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[DataContract]
public class Wages : ITableBase, IWages
{
    [DataMember]
    public int Id { get; set; }

    public decimal? NetIncome { get; set; }

    public string NetIncome_Frequency { get; set; }        

    public decimal? IncomeTax { get; set; }

    public string IncomeTax_Frequency { get; set; }        

    public decimal? OverTime { get; set; }        

    public string OverTime_Frequency { get; set; }        

    public decimal? Bonus { get; set; }        

    public string Bonus_Frequency { get; set; }        

    public decimal? OtherPayments { get; set; }        

    public string OtherPayments_Frequency { get; set; }

    [NotMapped]
    public decimal? Total
    {
        get
        {
            if(IsNotStarted) { return null; }

            return ValueFrequencyNormalisation.Normalise(NetIncome ?? 0, NetIncome_Frequency)
                   + ValueFrequencyNormalisation.Normalise(OverTime ?? 0, OverTime_Frequency)
                   + ValueFrequencyNormalisation.Normalise(Bonus ?? 0, Bonus_Frequency)
                   + ValueFrequencyNormalisation.Normalise(OtherPayments ?? 0, OtherPayments_Frequency);
        }
    }

    [NotMapped]
    public decimal? NormalisedIncomeTax
    {
        get
        {
            if (IsNotStarted) { return null; }
            return ValueFrequencyNormalisation.Normalise(IncomeTax ?? 0, IncomeTax_Frequency);
        }
    }

    [NotMapped]
    public bool IsNotStarted
    {
        get
        {
            return NetIncome == null
                   && IncomeTax == null
                   && OverTime == null
                   && Bonus == null
                   && OtherPayments == null
                   && IncomeTax == null;
        }
    }
}