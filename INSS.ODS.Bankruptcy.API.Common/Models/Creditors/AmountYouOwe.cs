using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Attributes;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Creditors;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Creditors
{
    [DataContract]
    [Validator(typeof(AmountYouOweValidator))]
    public class AmountYouOwe : IAmountYouOwe, ITableBase
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public string Reference { get; set; }

        [DataMember]
        public string DebtType { get; set; }

        [DataMember]
        public string DebtTypeOther { get; set; }

        [DataMember]
        public string ApproxDebtStartedDateRange { get; set; }

        [NotMapped]
        public bool RequiresReason
        {
            get
            {
                return DebtType == "Credit card/ store card"
                    || DebtType == "Personal loan (unsecured)";
            }
        }

    }
}
