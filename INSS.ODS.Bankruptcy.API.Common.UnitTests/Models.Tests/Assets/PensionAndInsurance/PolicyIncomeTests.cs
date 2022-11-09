using System;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using INSS.ODS.Bankruptcy.API.Common.Resources.PensionAndInsurance;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Creditors
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class PolicyIncomeTests
    {
        [TestMethod]
        public void TestPolicyIncomeInvalidData1()
        {
            var PolicyIncome = new PolicyIncome()
            {
                IncomeAmount = -100.00M
            };

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(PolicyIncome);
            Assert.IsFalse(modelState.IsValid);
            Assert.IsTrue(modelState["IncomeAmount"].Errors.Any(x => x.ErrorMessage == PolicyIncomeResources.PensionAndInsurance_PolicyIncome_IncomeAmount_Error_Negative));
            Assert.IsTrue(modelState["IncomeFrequency"].Errors.Any(x => x.ErrorMessage == PolicyIncomeResources.PensionAndInsurance_PolicyIncome_IncomeFrequency_Error_Empty));
        }

        [TestMethod]
        public void TestPolicyIncomeInvalidData2()
        {
            var PolicyIncome = new PolicyIncome()
            {
                IncomeAmount = 123.456M,
                IncomeFrequency = ""
            };

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(PolicyIncome);
            Assert.IsFalse(modelState.IsValid);
            Assert.IsTrue(modelState["IncomeAmount"].Errors.Any(x => x.ErrorMessage.Contains(PolicyIncomeResources.PensionAndInsurance_PolicyIncome_IncomeAmount_Error_Format)));
            Assert.IsTrue(modelState["IncomeFrequency"].Errors.Any(x => x.ErrorMessage == PolicyIncomeResources.PensionAndInsurance_PolicyIncome_IncomeFrequency_Error_Empty));
        }

        [TestMethod]
        public void TestPolicyIncomeValid()
        {
            var PolicyIncome = new PolicyIncome()
            {
                IncomeAmount = 123.45M,
                IncomeFrequency = "per month"
            };

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(PolicyIncome);
            Assert.IsTrue(modelState.IsValid);
        }

    }
}
