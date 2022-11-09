using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class AdditionalTransportExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Additional_Transport_Text { get; set; }

        [DataMember]
        public decimal? Additional_Transport_Value { get; set; }

        [DataMember]
        public string Additional_Transport_Frequency { get; set; }
    }
}