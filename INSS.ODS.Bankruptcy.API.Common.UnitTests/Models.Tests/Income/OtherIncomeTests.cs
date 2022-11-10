using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.Models;
using System.Linq;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using INSS.ODS.Bankruptcy.API.Common.Resources.Income;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
    [TestClass]
    public class OtherIncomeTests
    {
         [TestMethod]
        [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
        public void OtherIncomeValidModel()
         {
             var otherIncome = new OtherIncomeDetails();

             otherIncome.Amount = 100;
             otherIncome.Source = "On Call";
             otherIncome.AmountFrequency = "per month";
             
             var mockController = new MockTestController();

             var modelState = mockController.TryFullModelValidation(otherIncome);

             Assert.IsTrue(modelState.IsValid);
         }

         [TestMethod]
        [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
        public void OtherIncomeInvalidModel()
         {
             var otherIncome = new OtherIncomeDetails();
             otherIncome.Amount = 100;

             var mockController = new MockTestController();
             var modelState = mockController.TryFullModelValidation(otherIncome);

             Assert.IsFalse(modelState.IsValid);
             Assert.IsTrue(modelState["Source"].Errors.Any(x => x.ErrorMessage == OtherIncomeResources.Income_OtherIncome_Source_Error_RequiredIfAmountIsEntered));
        }

        [TestMethod]
        public void OtherIncomeTotallingTest()
        {
            var otherIncome = new OtherIncomeDetails();

            Assert.IsTrue(otherIncome.IsNotStarted);
            otherIncome.Amount = 100;
            otherIncome.AmountFrequency = "per week";
            Assert.IsFalse(otherIncome.IsNotStarted);
            Assert.AreEqual(433.33m, otherIncome.Total);

        }
    }
}