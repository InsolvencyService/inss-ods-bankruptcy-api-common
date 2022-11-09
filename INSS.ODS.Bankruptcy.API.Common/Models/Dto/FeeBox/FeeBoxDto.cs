using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Dto.FeeBox
{
    public class FeeBoxDto
    {
        public string AdjReference { get; set; }
        public string ApplicantFirstName { get; set; }
        public string ApplicantLastName { get; set; }
        public string ApplicantEmail { get; set; }
        public decimal Fee { get; set; }
        public decimal OutstandingAmount { get; set; }
        public decimal ReceivedAmount { get; set; }
        public DateTime? LastPaymentUpdate { get; set; }
        public AddressDto Address { get; set; }
        public string TelephoneNumber { get; set; }

        public string ThirdPartyPaymentUrl { get; set; }

        public List<KeyValuePair<string, decimal>> PaymentsByType { get; set; }

        public FeeBoxDto()
        {   
        }

        public FeeBoxDto(decimal fee, decimal paid, DateTime? lastPayment)
        {
            Fee = fee;
            ReceivedAmount = paid;
            OutstandingAmount = fee - paid;
            LastPaymentUpdate = lastPayment;
        }
    }
}
