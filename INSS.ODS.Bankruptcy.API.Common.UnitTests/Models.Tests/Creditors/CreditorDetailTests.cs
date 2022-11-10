using INSS.ODS.Bankruptcy.API.Common.Models.Creditors;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Creditors
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class CreditorDetailTests
    {
        [TestMethod]
        public void CreditorDetailInvalidTest()
        {
            var creditorDetail = new CreditorDetail();

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(creditorDetail);
            Assert.IsFalse(modelState.IsValid);
            Assert.AreEqual(2, modelState.Count);
        }

        [TestMethod]
        public void CreditorDetailValidTest()
        {
            var creditorDetail = new CreditorDetail();
            creditorDetail.Id = 1;
            creditorDetail.Amount = 1000;
            creditorDetail.DebtType = "Rent arrears";
            creditorDetail.Reference = "My ref";
            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(creditorDetail);
            Assert.IsTrue(modelState.IsValid);
        }

        [TestMethod]
        public void CreditorDetailInvalidDebtTypeTest()
        {
            var creditorDetail = new CreditorDetail();
            creditorDetail.Id = 1;
            creditorDetail.Amount = 1000;
            creditorDetail.DebtType = "Other";
            creditorDetail.Reference = "My ref";

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(creditorDetail);
            Assert.IsFalse(modelState.IsValid);
        }
    }
}
