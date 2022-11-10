using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class PensionInsuranceHealthcareExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? PersonalPensionPayments { get; set; }

        [DataMember]
        public string PersonalPensionPayments_Frequency { get; set; }

        [DataMember]
        public decimal? LifeInsurance { get; set; }

        [DataMember]
        public string LifeInsurance_Frequency { get; set; }

        [DataMember]
        public decimal? HealthInsurance { get; set; }

        [DataMember]
        public string HealthInsurance_Frequency { get; set; }

        [DataMember]
        public decimal? PaymentProtectionInsurance { get; set; }

        [DataMember]
        public string PaymentProtectionInsurance_Frequency { get; set; }

        [DataMember]
        public decimal? PetInsurance { get; set; }

        [DataMember]
        public string PetInsurance_Frequency { get; set; }

        [DataMember]
        public decimal? VeterinaryBills { get; set; }

        [DataMember]
        public string VeterinaryBills_Frequency { get; set; }

        [DataMember]
        public decimal? AdultCareCosts { get; set; }

        [DataMember]
        public string AdultCareCosts_Frequency { get; set; }

        [DataMember]
        public decimal? PrescriptionsAndMedicines { get; set; }

        [DataMember]
        public string PrescriptionsAndMedicines_Frequency { get; set; }

        [DataMember]
        public decimal? Dentistry { get; set; }

        [DataMember]
        public string Dentistry_Frequency { get; set; }

        [DataMember]
        public decimal? Opticians { get; set; }

        [DataMember]
        public string Opticians_Frequency { get; set; }
    }
}