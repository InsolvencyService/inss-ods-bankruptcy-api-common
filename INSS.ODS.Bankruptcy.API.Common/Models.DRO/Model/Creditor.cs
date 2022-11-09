using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Model
{
    public class Creditor
    {
        public int? Id { get; set; }

        public string CreditorReference { get; set; }

        public string CreditorName { get; set; }

        public decimal? AmountOwed { get; set; }

        public bool? ExcludedDebt { get; set; }

        public bool? SecuredDebt { get; set; }

        public bool? AttachmentOfEarnings { get; set; }

        public LegacyAddress CreditorAddress { get; set; }

        public bool UnableToTraceAddress { get; set; }

        public int? CreditorId { get; set; }

        public string ItemDebtSecuredOn { get; set; }

        public decimal? ValueOfItemDebtSecuredOn { get; set; }

        public string CourtName { get; set; }

        public string CourtReference { get; set; }

        public LegacyAddress CourtAddress { get; set; }
    }
}
