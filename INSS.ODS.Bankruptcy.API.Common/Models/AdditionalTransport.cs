using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[DataContract]
public class AdditionalTransport : ITableBase, IAdditionalTransport
{
    public int Id { get; set; }

    public string Additional_Transport_Text { get; set; }

    public decimal? Additional_Transport_Value { get; set; }

    public string Additional_Transport_Frequency { get; set; }
}