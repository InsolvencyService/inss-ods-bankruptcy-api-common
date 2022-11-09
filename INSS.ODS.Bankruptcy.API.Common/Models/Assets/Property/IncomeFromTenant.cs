using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Validator(typeof(IncomeFromTenantValidator))]
    [DataContract]
    public class IncomeFromTenant : IIncomeFromTenant, ITableBase
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? IncomeAmount { get; set; }

        [DataMember]
        public string IncomeFrequency { get; set; }

        [DataMember]
        public string ManagingAgent { get; set; }
    }
}