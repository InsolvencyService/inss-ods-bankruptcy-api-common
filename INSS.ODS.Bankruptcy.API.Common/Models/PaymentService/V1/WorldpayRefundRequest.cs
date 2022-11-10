namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.PaymentService.V1
{
    public class WorldpayRefundRequest
    {
        public string OrderCode { get; set; }
        public decimal RefundValue { get; set; }
        public string CurrencyCode { get; set; }
    }
}
