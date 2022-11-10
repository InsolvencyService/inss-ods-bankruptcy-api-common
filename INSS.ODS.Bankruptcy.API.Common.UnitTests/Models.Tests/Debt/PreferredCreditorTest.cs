using System.Linq;
using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Debt;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.Resources.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Debt
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class PreferredCreditorTest
    {
        private PreferredCreditorInterfaceValidator _validator;

        [TestInitialize]
        public void Setup()
        {
            _validator = new PreferredCreditorInterfaceValidator();
        }

        [TestMethod]
        [TestCategory("PreferredCreditor")]
        public void PreferredCreditor_MissingFields()
        {
            var model = new PreferredCreditor();

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(model);

            Assert.IsFalse(modelState.IsValid);

            // Required fields
            Assert.IsTrue(modelState["CreditorName"].Errors.Any(x => x.ErrorMessage == DebtPreferentialPaymentsResources.Debt_DebtPreferentialPayments_CreditorName_Error_Empty));
        }

        [TestMethod]
        [TestCategory("PreferredCreditor")]
        public void PreferredCreditor_InvalidData_TooLong()
        {
            var model = new PreferredCreditor()
            {
               CreditorName  = "ABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJA"
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(model);

            Assert.IsFalse(modelState.IsValid);

            // Required fields
            Assert.IsTrue(modelState["CreditorName"].Errors.Any(x => x.ErrorMessage == DebtPreferentialPaymentsResources.Debt_DebtPreferentialPayments_CreditorName_Error_TooLong));
        }

        [TestMethod]
        [TestCategory("PreferredCreditor")]
        public void PreferredCreditor_InvalidData_TooShort()
        {
            var model = new PreferredCreditor()
            {
                CreditorName = "A"
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(model);

            Assert.IsFalse(modelState.IsValid);

            // Required fields
            Assert.IsTrue(modelState["CreditorName"].Errors.Any(x => x.ErrorMessage == DebtPreferentialPaymentsResources.Debt_DebtPreferentialPayments_CreditorName_Error_TooShort));
        }

        [TestMethod]
        [TestCategory("PreferredCreditor")]
        public void PreferredCreditor_ShouldPassOn_ValidValues()
        {
            var model = new PreferredCreditor()
            {
                CreditorName = "I am a creditor",
                CreditorAddress = new Address
                {
                    Address_1 = "Some Street",
                    PostCode = "SO3 5TR",
                    Country = "UK",
                     TownCity = "DD"
                }
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(model);

            Assert.IsTrue(modelState.IsValid);
        }

         
        [TestMethod]
        [TestCategory("PreferredCreditor")]
        public void PreferredCreditor_Address_ShouldHaveChildValidator()
        {
            _validator.ShouldHaveChildValidator(x => x.CreditorAddress, typeof (AddressValidator));
        }

    }
}
