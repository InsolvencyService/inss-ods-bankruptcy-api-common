using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.BktReference;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.BktReference;

[DataContract]
public class BktRegistration : IBktRegistration
{
    [DataMember]
    [Key]
    public int Id { get; set; }

    public string BktReference
    {
        get
        {
            return $"BKT{Id:0000000}";
        }
    }
}
