using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Creditors
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class PolicyProviderTests
    {
        [TestMethod]
        public void TestPolicyProviderInvalid()
        {
            var creditor = new PolicyMain()
            {
                ProviderAddress = new Address()
            };
            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(creditor);
            Assert.IsFalse(modelState.IsValid);
            Assert.IsTrue(modelState["ProviderName"]?.Errors != null && modelState["ProviderName"].Errors.Count > 0);
            Assert.IsTrue(modelState["ProviderAddress.Address_1"]?.Errors != null && modelState["ProviderAddress.Address_1"].Errors.Count > 0);
            Assert.IsTrue(modelState["ProviderAddress.PostCode"]?.Errors != null && modelState["ProviderAddress.PostCode"].Errors.Count > 0);
            Assert.IsTrue(modelState["ProviderAddress.Country"]?.Errors != null && modelState["ProviderAddress.Country"].Errors.Count > 0);
        }

        [TestMethod]
        public void TestPolicyProviderValid()
        {
            var creditor = new PolicyMain
            {
                ProviderName = "ABC Bank",
                ProviderAddress = new Address
                {
                    Address_1 = "Street1",
                    PostCode = "ABC1",
                    Country = "UK",
                    TownCity = "DD"
                }
            };

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(creditor);
            Assert.IsTrue(modelState.IsValid);
        }

    }
}
