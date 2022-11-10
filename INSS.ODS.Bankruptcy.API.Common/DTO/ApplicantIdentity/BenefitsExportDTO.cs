using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class BenefitsExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? ChildTaxCredit { get; set; }

        [DataMember]
        public string ChildTaxCredit_Frequency { get; set; }

        [DataMember]
        public decimal? ChildBenefit { get; set; }

        [DataMember]
        public string ChildBenefit_Frequency { get; set; }

        [DataMember]
        public decimal? ChildSupport { get; set; }

        [DataMember]
        public string ChildSupport_Frequency { get; set; }

        [DataMember]
        public decimal? Universal_Credit { get; set; }

        [DataMember]
        public string Universal_Credit_Frequency { get; set; }

        [DataMember]
        public decimal? JobSeekers { get; set; }

        [DataMember]
        public string JobSeekers_Frequency { get; set; }

        [DataMember]
        public decimal? Income_Support { get; set; }

        [DataMember]
        public string Income_Support_Frequency { get; set; }

        [DataMember]
        public decimal? Working_Tax_Credit { get; set; }

        [DataMember]
        public string Working_Tax_Credit_Frequency { get; set; }

        [DataMember]
        public decimal? Sick_Pay { get; set; }

        [DataMember]
        public string Sick_Pay_Frequency { get; set; }

        [DataMember]
        public decimal? Disability { get; set; }

        [DataMember]
        public string Disability_Frequency { get; set; }

        [DataMember]
        public decimal? Carers_Allowance { get; set; }

        [DataMember]
        public string Carers_Allowance_Frequency { get; set; }

        [DataMember]
        public decimal? Housing_Benefit { get; set; }

        [DataMember]
        public string Housing_Benefit_Frequency { get; set; }

        [DataMember]
        public decimal? Council_Tax_Support { get; set; }

        [DataMember]
        public string Council_Tax_Support_Frequency { get; set; }

        [DataMember]
        public string Other_Text { get; set; }

        [DataMember]
        public decimal? Other_Value { get; set; }

        [DataMember]
        public string Other_Frequency { get; set; }
    }
}