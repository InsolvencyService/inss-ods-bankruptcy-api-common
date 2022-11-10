using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using FluentValidation.Attributes;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [Validator(typeof(ExpenseValidator))]
    public class Expense : IExpense
    {
        public int Id { get; set; }
        public decimal? Value { get; set; }
        public string Frequency { get; set; }
        public string Type { get; set; }
    }
}