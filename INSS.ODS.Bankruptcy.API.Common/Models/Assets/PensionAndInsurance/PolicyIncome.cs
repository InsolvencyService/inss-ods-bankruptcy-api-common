using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace INSS.ODS.Bankruptcy.API.Common.Models;

[Serializable]
public class PolicyIncome : IPolicyIncome, ITableBase
{
    public int Id { get; set; }

    [NotMapped]
    public int PolicyMainId { get; set; }

    public decimal? IncomeAmount { get; set; }

    public string IncomeFrequency { get; set; }
}
