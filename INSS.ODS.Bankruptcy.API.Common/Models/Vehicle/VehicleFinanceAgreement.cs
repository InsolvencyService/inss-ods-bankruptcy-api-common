using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Vehicle;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Vehicle;
using System;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Vehicle
{
    [Validator(typeof(FinanceAgreementValidator))]
    [DataContract]
    public class FinanceAgreement : IFinanceAgreement, ITableBase
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