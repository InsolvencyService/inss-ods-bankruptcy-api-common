using INSS.ODS.Bankruptcy.API.Common.Models.Helpers;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[DataContract]
public class OtherIncomeDetails : ITableBase, IOtherIncomeDetails
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string Source { get; set; }

    [DataMember]
    public decimal? Amount { get; set; }

    [DataMember]
    public string AmountFrequency { get; set; }

    [NotMapped]
    public decimal? Total
    {
        get
        {
            if (IsNotStarted) { return null; }
            return ValueFrequencyNormalisation.Normalise(Amount, AmountFrequency);
        }
    }

    [NotMapped]
    public bool IsNotStarted
    {
        get { return !Amount.HasValue; }
    }
}