using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.ApplicationOverview;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.ApplicationOverview;

namespace INSS.ODS.Bankruptcy.API.Common.Models.ApplicationOverview
{
    [Validator(typeof(RefundBankDetailsValidator))]
    public class RefundBankDetails: IRefundBankDetails, ITableBase
    {
        public int Id { get; set; }
        public string SortCode { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public string AccountHolder { get; set; }
    }
}
