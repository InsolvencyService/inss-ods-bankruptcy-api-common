using INSS.ODS.Bankruptcy.API.Common.Models.OtherAssets;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.OtherAssets
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class CashTests
    {
        [TestMethod]
        public void CashValidTest()
        {
            var controller = new MockTestController();

            var model = new OtherAssetsCash();

            //positive
            model.Amount = 100;
            controller.TryFullModelValidation(model);
            Assert.IsTrue(controller.ModelState.IsValid, "Amount can be positive");
            controller.ModelState.Clear();

            //null allowed
            model.Amount = null;
            controller.TryFullModelValidation(model);
            Assert.IsTrue(controller.ModelState.IsValid, "Amount can be null");
            controller.ModelState.Clear();
        }

        [TestMethod]
        public void CashInvalidTest()
        {
            var controller = new MockTestController();

            var model = new OtherAssetsCash();

            //not negative
            model.Amount = -100;
            controller.TryFullModelValidation(model);
            Assert.IsFalse(controller.ModelState.IsValid, "Amount cannot be negative");
            controller.ModelState.Clear();

            //not zero
            model.Amount = 0;
            controller.TryFullModelValidation(model);
            Assert.IsFalse(controller.ModelState.IsValid, "Amount cannot be zero");
            controller.ModelState.Clear();

            //scale ok
            model.Amount = 1.123m;
            controller.TryFullModelValidation(model);
            Assert.IsFalse(controller.ModelState.IsValid, "Amount up to 2 decimal places");
            controller.ModelState.Clear();
        }
    }
}
