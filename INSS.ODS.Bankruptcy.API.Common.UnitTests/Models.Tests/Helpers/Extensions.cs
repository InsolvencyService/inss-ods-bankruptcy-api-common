using System.Linq;
using FluentValidation.Results;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Helpers
{
    public static class Extensions
    {
        public static bool HasError(this ValidationResult result, string propertyName, string errorMessage)
        {
            var error = result.Errors.FirstOrDefault(e => e.PropertyName == propertyName && e.ErrorMessage == errorMessage);
            return error != null;
        }
    }
}
