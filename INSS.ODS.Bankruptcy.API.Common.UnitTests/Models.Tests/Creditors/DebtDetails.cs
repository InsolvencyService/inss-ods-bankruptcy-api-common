using INSS.ODS.API.Common.Utilities.TestHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.Models.Creditors;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Creditors
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class DebtDetailTests
    {
        [TestMethod]
        public void DebtDetailsInvalidTest()
        {
            var debtDetails = new DebtDetail();
            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(debtDetails);
            Assert.IsFalse(modelState.IsValid);
        }

        [TestMethod]
        public void DebtDetailsInvalidOtherTextTest()
        {
            var debtDetails = new DebtDetail();
            debtDetails.Other = true;
            

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(debtDetails);
            Assert.IsFalse(modelState.IsValid);
          
        }

        [TestMethod]
        public void DebtDetailstInValidTest()
        {
            var debtDetails = new DebtDetail();
            debtDetails.AttachmentOfEarnings = true;
            debtDetails.SeizedOrSoldAssets = true;
            debtDetails.ApproxDebtStartedDateRange = "3 to 5 years ago";

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(debtDetails);
            Assert.IsFalse(modelState.IsValid);
        }

        [TestMethod]
        public void DebtDetailsValidTest()
        {
            var debtDetails = new DebtDetail();
            debtDetails.AttachmentOfEarnings = false;
            debtDetails.SeizedOrSoldAssets = true;
            debtDetails.ApproxDebtStartedDateRange = "3 to 5 years ago";

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(debtDetails);
            Assert.IsTrue(modelState.IsValid);
        }

    }
}
