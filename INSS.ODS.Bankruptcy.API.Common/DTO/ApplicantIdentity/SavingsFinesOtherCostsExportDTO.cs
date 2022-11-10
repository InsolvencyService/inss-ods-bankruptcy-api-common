using System.Collections.Generic;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.DTO.ApplicantIdentity
{
    [DataContract]
    public class SavingsFinesOtherCostsExportDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? Savings { get; set; }

        [DataMember]
        public string Savings_Frequency { get; set; }

        [DataMember]
        public List<FineExportDTO> CourtFines { get; set; }

        [DataMember]
        public List<ExpenseExportDTO> Expenses { get; set; }
    }
}