using System;

namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators.Shared.Helpers
{
    public static class DateValidationHelper
    {
        public static bool BeAValidDate(DateTime? date)
        {
            if (!date.HasValue || date == default(DateTime))
                return false;
            return true;
        }
    }
}
