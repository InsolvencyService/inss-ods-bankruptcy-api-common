using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Resources.Shared;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Common
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class AddressTest
    {
        private MockTestController _mockController;

        [TestInitialize]
        public void Setup()
        {
            _mockController = new MockTestController();
        }

        [TestMethod]
        [TestCategory("Address")]
        public void AddressInterfaceValidator_InvalidModel()
        {
            var model = new Address();

            var modelState = _mockController.TryFullModelValidation(model);
            Assert.IsFalse(modelState.IsValid);
            Assert.IsTrue(modelState["Address_1"].Errors.Any(x => x.ErrorMessage == AddressResources.Shared_Address_OtherAddress_Address_1_Error_Empty));
            Assert.IsTrue(modelState["PostCode"].Errors.Any(x => x.ErrorMessage == AddressResources.Shared_Address_OtherAddress_PostCode_Error_Empty));
            Assert.IsTrue(modelState["Country"].Errors.Any(x => x.ErrorMessage == AddressResources.Shared_Address_OtherAddress_Country_Error_Empty));
            Assert.IsTrue(modelState["TownCity"].Errors.Any(x => x.ErrorMessage == AddressResources.Shared_Address_OtherAddress_TownCity_Error_Empty));
            Assert.IsFalse(modelState["Address_2"] != null && modelState["Address_2"].Errors.Any());
            Assert.IsFalse(modelState["Address_3"] != null && modelState["Address_3"].Errors.Any());
            Assert.IsFalse(modelState["County"] != null && modelState["County"].Errors.Any());
        }

        [TestMethod]
        [TestCategory("Address")]
        public void AddressInterfaceValidator_ValidModel()
        {
            var model = new Address()
            {
                Address_1 = "1 New Street",
                PostCode = "PO5 7CD",
                Country = "UK",
                TownCity ="TEST"
            };

            var modelState = _mockController.TryFullModelValidation(model);
            Assert.IsTrue(modelState.IsValid);
        }
    }
}
