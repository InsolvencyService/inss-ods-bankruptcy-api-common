using System;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Creditors
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class PolicyDetailTests
    {
        [TestMethod]
        public void TestPolicyProviderDetailInvalid()
        {
            var policyProviderDetail = new PolicyDetail();

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(policyProviderDetail);
            Assert.IsFalse(modelState.IsValid);
            Assert.IsTrue(modelState["CommencementDate"]?.Errors != null && modelState["CommencementDate"].Errors.Count > 0);
            Assert.IsTrue(modelState["PolicyType"]?.Errors != null && modelState["PolicyType"].Errors.Count > 0);
        }

        [TestMethod]
        public void TestPolicyProviderValid()
        {
            var policyProviderDetail = new PolicyDetail()
            {
                CommencementDate = "0 to 12 months",
                PolicyType = "Endowment",
            };

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(policyProviderDetail);
            Assert.IsTrue(modelState.IsValid);
        }

    }
}
