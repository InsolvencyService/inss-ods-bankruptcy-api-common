using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Serializable]
    [Validator(typeof(PolicyIncomeValidator))]
    public class PolicyIncome : IPolicyIncome, ITableBase
    {
        public int Id { get; set; }

        [NotMapped]
        public int PolicyMainId { get; set; }

        public decimal? IncomeAmount { get; set; }

        public string IncomeFrequency { get; set; }
    }
}
