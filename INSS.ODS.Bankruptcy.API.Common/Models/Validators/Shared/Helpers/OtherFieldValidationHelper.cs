namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Shared.Helpers
{
    public static class OtherFieldValidationHelper
    {
        public static bool IsOtherFieldBeingUsed(string selectedFieldValue)
        {
            return selectedFieldValue.ToLower() == "other";
        }

        public static bool OtherFieldNotEmpty(string selectedFieldValue, string otherFieldValue)
        {
            if (IsOtherFieldBeingUsed(selectedFieldValue))
            {
                if (string.IsNullOrWhiteSpace(otherFieldValue))
                {
                    return false;
                }
            }

            return true;
        }


        public static bool OtherFieldHasLengthGreaterThan(string selectedFieldValue, string otherFieldValue, int maximumLength)
        {

            if (IsOtherFieldBeingUsed(selectedFieldValue) && OtherFieldNotEmpty(selectedFieldValue, otherFieldValue))
            {
                return otherFieldValue.Length <= maximumLength;
            }

            return true;
        }

        public static bool OtherFieldHasLengthLessThan(string selectedFieldValue, string otherFieldValue, int minimumLength)
        {
            if (IsOtherFieldBeingUsed(selectedFieldValue) && OtherFieldNotEmpty(selectedFieldValue, otherFieldValue))
            {
                return otherFieldValue.Length > minimumLength;
            }

            return true;
        }
    }
}
