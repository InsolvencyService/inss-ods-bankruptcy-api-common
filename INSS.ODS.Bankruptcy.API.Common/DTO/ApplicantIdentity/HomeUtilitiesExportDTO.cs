using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class HomeUtilitiesExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? Rent { get; set; }

        [DataMember]
        public string Rent_Frequency { get; set; }

        [DataMember]
        public decimal? Mortgage { get; set; }

        [DataMember]
        public string Mortgage_Frequency { get; set; }

        [DataMember]
        public decimal? SecuredLoans { get; set; }

        [DataMember]
        public string SecuredLoans_Frequency { get; set; }

        [DataMember]
        public decimal? GroundRentServiceCharges { get; set; }

        [DataMember]
        public string GroundRentServiceCharges_Frequency { get; set; }

        [DataMember]
        public decimal? BuildingContentInsurance { get; set; }

        [DataMember]
        public string BuildingContentInsurance_Frequency { get; set; }

        [DataMember]
        public decimal? ApplicanceFurnitureRental { get; set; }

        [DataMember]
        public string ApplicanceFurnitureRental_Frequency { get; set; }

        [DataMember]
        public decimal? TVLicence { get; set; }

        [DataMember]
        public string TVLicence_Frequency { get; set; }

        [DataMember]
        public decimal? CouncilTax { get; set; }

        [DataMember]
        public string CouncilTax_Frequency { get; set; }

        [DataMember]
        public decimal? Gas { get; set; }

        [DataMember]
        public string Gas_Frequency { get; set; }

        [DataMember]
        public decimal? Electricity { get; set; }

        [DataMember]
        public string Electricity_Frequency { get; set; }

        [DataMember]
        public decimal? Water { get; set; }

        [DataMember]
        public string Water_Frequency { get; set; }
    }
}