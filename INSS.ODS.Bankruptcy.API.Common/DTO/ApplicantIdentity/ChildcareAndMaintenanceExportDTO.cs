using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class ChildcareAndMaintenanceExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? ChildSupport { get; set; }

        [DataMember]
        public string ChildSupport_Frequency { get; set; }

        [DataMember]
        public decimal? Childcare { get; set; }

        [DataMember]
        public string Childcare_Frequency { get; set; }

        [DataMember]
        public decimal? Nappies { get; set; }

        [DataMember]
        public string Nappies_Frequency { get; set; }

        [DataMember]
        public decimal? Prescriptions { get; set; }

        [DataMember]
        public string Prescriptions_Frequency { get; set; }

        [DataMember]
        public decimal? Dentistry { get; set; }

        [DataMember]
        public string Dentistry_Frequency { get; set; }

        [DataMember]
        public decimal? Uniforms { get; set; }

        [DataMember]
        public string Uniforms_Frequency { get; set; }

        [DataMember]
        public decimal? Meals { get; set; }

        [DataMember]
        public string Meals_Frequency { get; set; }

        [DataMember]
        public decimal? Trips { get; set; }

        [DataMember]
        public string Trips_Frequency { get; set; }

        [DataMember]
        public decimal? Transport { get; set; }

        [DataMember]
        public string Transport_Frequency { get; set; }

        [DataMember]
        public decimal? PocketMoney { get; set; }

        [DataMember]
        public string PocketMoney_Frequency { get; set; }
    }
}