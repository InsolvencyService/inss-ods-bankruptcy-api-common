using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto
{
    [DataContract]
    public class BaseDto    
    {
        [DataMember]
        public string Id { get; set; }
    }
}