using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Import.V2
{
    public class EmploymentDetail
    {
        public string CompanyName { get; set; }

        public string PayrollNumber { get; set; }

        public string JobTitle { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public JobRole? JobRole { get; set; }

        public DateTime? DateEmploymentBegan { get; set; }

        public Address BusinessAddress { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public EmploymentType? EmploymentType { get; set; }

        public string EmploymentTypeOther { get; set; }

        // business
        public string BusinessType { get; set; }

        public string BusinessName { get; set; }


        public bool? SoleTrader { get; set; }
        public bool IsPrimary { get; set; }
    }
}