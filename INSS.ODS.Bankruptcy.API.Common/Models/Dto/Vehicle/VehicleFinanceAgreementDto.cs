using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.Vehicle
{
    [DataContract]
    public class VehicleFinanceAgreementDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public DateTime AgreementStartedDate { get; set; }

        [DataMember]
        public string FinanceCompanyName { get; set; }

        [DataMember]
        public string ReferenceNumber { get; set; }
    }
}