using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto
{
    [DataContract]
    public class AddressDto
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Address_1 { get; set; }

        [DataMember]
        public string Address_2 { get; set; }

        [DataMember]
        public string Address_3 { get; set; }

        [DataMember]
        public string TownCity { get; set; }

        [DataMember]
        public string County { get; set; }

        [DataMember]
        public string PostCode { get; set; }

        [DataMember]
        public string Country { get; set; }
    }
}
