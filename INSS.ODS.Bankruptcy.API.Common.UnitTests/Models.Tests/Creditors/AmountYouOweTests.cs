using INSS.ODS.Bankruptcy.API.Common.Models.Creditors;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Creditors
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class AmountYouOweTests
    {
        [TestMethod]
        public void AmountYouOweInvalidTest()
        {
            var amount = new AmountYouOwe();

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(amount);
            Assert.IsFalse(modelState.IsValid);
            Assert.AreEqual(3, modelState.Count);
        }

        [TestMethod]
        public void AmountYouOweValidTest()
        {
            var amount = new AmountYouOwe();
            amount.Id = 1;
            amount.Amount = 1000;
            amount.DebtType = "Rent arrears";
            amount.Reference = "My ref";
            amount.ApproxDebtStartedDateRange = "3 to 5 years ago";
            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(amount);
            Assert.IsTrue(modelState.IsValid);
        }

        [TestMethod]
        public void AmountYouOweInvalidDebtTypeTest()
        {
            var amount = new AmountYouOwe();
            amount.Id = 1;
            amount.Amount = 1000;
            amount.DebtType = "Other";
            amount.Reference = "My ref";
            amount.ApproxDebtStartedDateRange = "3 to 5 years ago";

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(amount);
            Assert.IsFalse(modelState.IsValid);
        }
    }
}
