using INSS.ODS.Bankruptcy.API.Common.Models.Helpers;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[DataContract]
public class Transport : ITableBase, ITransport
{
    public int Id { get; set; }

    public decimal? Vehicle_Finance { get; set; }

    public string Vehicle_Finance_Frequency { get; set; }

    public decimal? Vehicle_Insurance { get; set; }

    public string Vehicle_Insurance_Frequency { get; set; }

    public decimal? Breakdown_Cover { get; set; }

    public string Breakdown_Cover_Frequency { get; set; }

    public decimal? Vehicle_Tax { get; set; }

    public string Vehicle_Tax_Frequency { get; set; }

    public decimal? MOT { get; set; }

    public string MOT_Frequency { get; set; }

    public decimal? Fuel_Parking_Toll { get; set; }

    public string Fuel_Parking_Toll_Frequency { get; set; }

    public decimal? Public_Transport { get; set; }

    public string Public_Transport_Frequency { get; set; }

    [DataMember]
    public List<AdditionalTransport> AdditionalTransport
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
            var result = ValueFrequencyNormalisation.Normalise(Vehicle_Finance, Vehicle_Finance_Frequency)
                + ValueFrequencyNormalisation.Normalise(Vehicle_Insurance, Vehicle_Insurance_Frequency)
                + ValueFrequencyNormalisation.Normalise(Breakdown_Cover, Breakdown_Cover_Frequency)
                + ValueFrequencyNormalisation.Normalise(Vehicle_Tax, Vehicle_Tax_Frequency)
                + ValueFrequencyNormalisation.Normalise(MOT, MOT_Frequency)
                + ValueFrequencyNormalisation.Normalise(Fuel_Parking_Toll, Fuel_Parking_Toll_Frequency)
                + ValueFrequencyNormalisation.Normalise(Public_Transport, Public_Transport_Frequency);

            if (AdditionalTransport != null)
            {
                foreach (var additional in AdditionalTransport)
                {
                    result += ValueFrequencyNormalisation.Normalise(additional.Additional_Transport_Value,
                        additional.Additional_Transport_Frequency);
                }
            }

            return result;
        }
    }

    [NotMapped]
    public bool IsNotStarted
    {
        get
        {
            return Vehicle_Finance == null
                && Vehicle_Insurance == null
                && Breakdown_Cover == null
                && Vehicle_Tax == null
                && MOT == null
                && Fuel_Parking_Toll == null
                && Public_Transport == null
                && (AdditionalTransport==null || !AdditionalTransport.Any());
        }
    }

}