using INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.IncomeAndExpenses.Transport
{
    public class TransportViewModel
    {
        public RecurringPayment Vehicle_Finance { get; set; }
        public RecurringPayment Vehicle_Insurance { get; set; }
        public RecurringPayment Breakdown_Cover { get; set; }
        public RecurringPayment Vehicle_Tax { get; set; }
        public RecurringPayment MOT { get; set; }
        public RecurringPayment Fuel_Parking_Toll { get; set; }
        public RecurringPayment Public_Transport { get; set; }
        public List<AdditionalTransportViewModel> AdditionalTransport { get; set; }
        public decimal? Total { get; set; }
    }
}
