using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.Benefits
{
    public class BenefitsViewModel
    {
        public RecurringPayment ChildTaxCredit { get; set; }
        public RecurringPayment ChildBenefit { get; set; }
        public RecurringPayment ChildSupport { get; set; }
        public RecurringPayment Universal_Credit { get; set; }
        public RecurringPayment JobSeekers { get; set; }
        public RecurringPayment Income_Support { get; set; }
        public RecurringPayment Working_Tax_Credit { get; set; }
        public RecurringPayment Sick_Pay { get; set; }
        public RecurringPayment Disability { get; set; }
        public RecurringPayment Carers_Allowance { get; set; }
        public RecurringPayment Housing_Benefit { get; set; }
        public RecurringPayment Council_Tax_Support { get; set; }
        public string Other_Text { get; set; }
        public RecurringPayment Other_Value { get; set; }
        public decimal? Total { get; set; }
    }
}
