using System.Linq;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.Resources.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Models.Creditors;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Creditors
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class ReasonForDebtTests
    {
        [TestMethod]
        public void ReasonForDebtInvalidTest()
        {
            var reason = new ReasonForDebt();
            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(reason);
            Assert.IsFalse(modelState.IsValid);
        }

        [TestMethod]
        public void ReasonForDebtInvalidOtherTextTest()
        {
            var reason = new ReasonForDebt();
            reason.Other = true;
            

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(reason);
            Assert.IsFalse(modelState.IsValid);
            Assert.AreEqual(ReasonForDebtResources.Creditors_ReasonForDebt_Reason_Error_Mandatory, modelState.First().Value.Errors.First().ErrorMessage);
        }

        [TestMethod]
        public void ReasonForDebtValidTest()
        {
            var reason = new ReasonForDebt
            {
                VehiclePurchase = true
            };

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(reason);
            Assert.IsTrue(modelState.IsValid);
        }

    }
}
