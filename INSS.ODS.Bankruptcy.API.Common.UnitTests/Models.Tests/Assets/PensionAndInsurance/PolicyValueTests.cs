using System;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using INSS.ODS.Bankruptcy.API.Common.Resources.PensionAndInsurance;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Creditors
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class PolicyValueTests
    {
        [TestMethod]
        public void TestPolicyValueInvalidData1()
        {
            var policyValue = new PolicyValue()
            {
                CurrentWorth = -1000.00M
            };

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(policyValue);
            Assert.IsFalse(modelState.IsValid);
            Assert.IsTrue(modelState["CurrentlyReceivingPaymentOptions"].Errors.Any(x => x.ErrorMessage == PolicyValueResources.PensionAndInsurance_PolicyValue_CurrentlyReceivingPayment_Error_Empty));
            Assert.IsTrue(modelState["CurrentWorth"].Errors.Any(x => x.ErrorMessage == PolicyValueResources.PensionAndInsurance_PolicyValue_CurrentlyWorth_Error_NegativeValue));
        }

        [TestMethod]
        public void TestPolicyValueInvalidData2()
        {
            var policyValue = new PolicyValue()
            {
                CurrentlyReceivingPaymentOptions = null,
                CurrentWorth = 1234.567M
            };

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(policyValue);
            Assert.IsFalse(modelState.IsValid);
            Assert.IsTrue(modelState["CurrentlyReceivingPaymentOptions"].Errors.Any(x => x.ErrorMessage == PolicyValueResources.PensionAndInsurance_PolicyValue_CurrentlyReceivingPayment_Error_Empty));
            Assert.IsTrue(modelState["CurrentWorth"].Errors.Any(x => x.ErrorMessage.Contains(PolicyValueResources.PensionAndInsurance_PolicyValue_CurrentlyWorth_Error_Format)));
        }

        [TestMethod]
        public void TestPolicyValueValid()
        {
            var policyValue = new PolicyValue()
            {
                CurrentWorth = 1000.00M,
                CurrentlyReceivingPaymentOptions = "Yes",
                CurrentlyReceivingPayment = true,
            };

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(policyValue);
            Assert.IsTrue(modelState.IsValid);
        }

    }
}
