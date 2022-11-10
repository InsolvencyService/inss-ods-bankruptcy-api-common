using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.DebtHistory
{
    public class PreferredCreditorViewModel
    {
        public string SourceRef { get; set; }
        public string CreditorName { get; set; }
        public AddressViewModel CreditorAddress { get; set; }
        public string RelationshipToYou { get; set; }
        public string RelationshipToYouOther { get; set; }
    }
}
