using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Declaration
{
    public class ParvViewModel
    {
        public string CourtName { get; set; }
        public DateTime ApprovedDate { get; set; }
        public string OrderNumber { get; set; }
    }
}
