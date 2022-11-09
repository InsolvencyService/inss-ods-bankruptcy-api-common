using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Resources.BankAccount;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class BankDetailsTests
    {
        [TestMethod]
        public void BankDetailsValidModel()
        {
            var bankDetails = new BankDetails();

            bankDetails.BankName = "HSBC";
            bankDetails.AddressLine1 = "Cathedral Square";
            bankDetails.PostCode = "PE1 1EP";
            bankDetails.Country = "Uk";

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(bankDetails);

            Assert.IsTrue(modelState.IsValid);
        }

        [TestMethod]
        public void BankDetailsInvalidModel()
        {
            var bankDetails = new BankDetails();
            bankDetails.BankName = string.Empty;

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(bankDetails);

            Assert.IsFalse(modelState.IsValid);
            Assert.IsTrue(modelState["BankName"].Errors.Any(x => x.ErrorMessage == BankDetailsResources.BankAccount_BankDetails_BankName_Error_Mandatory));
        }
    }
}