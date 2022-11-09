using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common
{
    public class RecurringPayment
    {
        public decimal? Value { get; set; }
        public string Frequency { get; set; }

        public RecurringPayment(decimal? value, string frequency)
        {
            Value = value;
            Frequency = frequency;
        }
    }
}
