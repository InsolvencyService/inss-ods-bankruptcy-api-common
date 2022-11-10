using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using INSS.ODS.Bankruptcy.API.Common.Models.DRO.PaymentService.V1;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    [DataContract]
    public class PaymentReceipt : ITableBase, IPaymentReceipt
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [MaxLength(20)]
        public string PaymentProvider { get; set; }

        [DataMember]
        [MaxLength(36)]
        public String TransactionId { get; set; }

        [DataMember]
        [MaxLength(20)]
        public string AccountId { get; set; }

        [DataMember]
        public DateTime TranscationTime { get; set; }

        [DataMember]
        public int TransactionAmountInPence { get; set; }

        [DataMember]
        public String ProviderMetadata { get; set; }

        [DataMember]
        [MaxLength(30)]
        public String Status { get; set; }

        [DataMember]
        public DateTime? StatusUpdateDate { get; set; }

        [DataMember]
        public bool VerifiedByProviderCallback { get; set; }

        [DataMember]
        public bool RefundRequested { get; set; }

        [DataMember]
        public int RefundAmountInPence { get; set; }

        [DataMember]
        public DateTime? RefundRequestDate { get; set; }

        public PaymentReceipt()
        {
            Status = "PENDING";
            TranscationTime = DateTime.Now;
        }

        //for cash payments only
        [DataMember]
        public String AuthoriserUserId { get; set; }

        [NotMapped]
        public decimal Amount
        {
            get { return Convert.ToDecimal(TransactionAmountInPence)/100; }
        }

        [NotMapped]
        public decimal RefundAmount
        {
            get { return Convert.ToDecimal(RefundAmountInPence) / 100; }
        }


        [NotMapped]
        public bool IsSuccessfulPayment
        {
            get { return Status == "AUTHORISED" || Status == "CAPTURED" || Status == "SETTLED"; }
        }

        [NotMapped]
        public bool IsFailedPayment
        {
            get { return Status == "REFUSED" || Status == "ERROR" || Status == "CHARGED_BACK" || Status == "EXPIRED"; }
        }

        [NotMapped]
        public bool IsPendingPayment
        {
            get { return Status == "PENDING"; }
        }

        [NotMapped]
        public bool IsCancelledPayment
        {
            get { return Status == "CANCELLED"; }
        }

        [NotMapped]
        public bool IsAvailableForRefund
        {
            get
            {
                return IsSuccessfulPayment && !RefundRequested;
            }
        }

        public WorldpayRefundRequest GenerateRefundRequest()
        {
            var result = new WorldpayRefundRequest
            {
                OrderCode = TransactionId,
                RefundValue = Convert.ToDecimal(TransactionAmountInPence)/100,
                CurrencyCode = "GBP"
            };
            return result;
        }

        public WorldpayRefundRequest GenerateRefundRequest(decimal amount)
        {
            var result = new WorldpayRefundRequest
            {
                OrderCode = TransactionId,
                RefundValue = amount,
                CurrencyCode = "GBP"
            };
            return result;
        }
    }
}
