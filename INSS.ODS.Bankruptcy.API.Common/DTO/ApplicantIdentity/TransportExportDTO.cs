using System.Collections.Generic;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class TransportExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? Vehicle_Finance { get; set; }

        [DataMember]
        public string Vehicle_Finance_Frequency { get; set; }

        [DataMember]
        public decimal? Vehicle_Insurance { get; set; }

        [DataMember]
        public string Vehicle_Insurance_Frequency { get; set; }

        [DataMember]
        public decimal? Breakdown_Cover { get; set; }

        [DataMember]
        public string Breakdown_Cover_Frequency { get; set; }

        [DataMember]
        public decimal? Vehicle_Tax { get; set; }

        [DataMember]
        public string Vehicle_Tax_Frequency { get; set; }

        [DataMember]
        public decimal? MOT { get; set; }

        [DataMember]
        public string MOT_Frequency { get; set; }

        [DataMember]
        public decimal? Fuel_Parking_Toll { get; set; }

        [DataMember]
        public string Fuel_Parking_Toll_Frequency { get; set; }

        [DataMember]
        public decimal? Public_Transport { get; set; }

        [DataMember]
        public string Public_Transport_Frequency { get; set; }

        [DataMember]
        public List<AdditionalTransportExportDTO> AdditionalTransport { get; set; }
    }
}