using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.PaymentService.V1
{
    public class PaymentReceiptDto
    {
        public int Id { get; set; }
        public string PaymentProvider { get; set; }
        public String TransactionId { get; set; }
        public string AccountId { get; set; }
        public DateTime TranscationTime { get; set; }
        public int TransactionAmountInPence { get; set; }
        public String ProviderMetadata { get; set; }
        public String Status { get; set; }
        public DateTime? StatusUpdateDate { get; set; }
        public bool VerifiedByProviderCallback { get; set; }
        public bool RefundRequested { get; set; }
        public int RefundAmountInPence { get; set; }
        public DateTime? RefundRequestDate { get; set; }

        public PaymentReceiptDto()
        {
            Status = "PENDING";
            TranscationTime = DateTime.Now;
        }

        public decimal Amount
        {
            get { return Convert.ToDecimal(TransactionAmountInPence) / 100; }
        }

        public decimal RefundAmount
        {
            get { return Convert.ToDecimal(RefundAmountInPence) / 100; }
        }

        public bool IsSuccessfulPayment
        {
            get { return Status == "AUTHORISED" || Status == "CAPTURED" || Status == "SETTLED"; }
        }

        public bool IsFailedPayment
        {
            get { return Status == "REFUSED" || Status == "ERROR" || Status == "CHARGED_BACK" || Status == "EXPIRED"; }
        }

        public bool IsPendingPayment
        {
            get { return Status == "PENDING"; }
        }

        public bool IsCancelledPayment
        {
            get { return Status == "CANCELLED"; }
        }

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
                RefundValue = Convert.ToDecimal(TransactionAmountInPence) / 100,
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
