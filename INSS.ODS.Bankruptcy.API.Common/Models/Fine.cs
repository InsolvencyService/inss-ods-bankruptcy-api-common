using System.Runtime.Serialization;
using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Validator(typeof(FineValidator))]
    public class Fine : IFine
    {
        public int Id { get; set; }
        public decimal? Value { get; set; }
        public string Frequency { get; set; }
        public string Type { get; set; }
    }
}