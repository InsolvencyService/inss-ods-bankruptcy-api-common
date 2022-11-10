namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Account
{
    public class OverridePasswordRequest
    {
        public string UserId { get; set; }
        public string NewPassword { get; set; }
    }
}