namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Shared.Helpers
{
    public static class ValidationLengthHelper
    {
        public static bool HaveLengthGreaterThan(string value, int length)
        {
            return value.Length > length;
        }

        public static bool HaveLengthLessThan(string value, int length)
        {
            return value.Length < length;
        }
    }
}
