using FluentAssertions;
using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.BankAccount
{
    [TestClass]
    public class BankDetailsTest
    {
        private BankDetailsValidator validator;

        [TestInitialize]
        public void Setup()
        {
            validator = new BankDetailsValidator();
        }

        [TestMethod]
        [TestCategory("Bank Details")]
        public void BankDetailsValidModel()
        {
            var model = new BankDetails()
            {
                BankName = "Testing Bank Name",
                AddressLine1 = "Testing Address Line 1",
                PostCode = "AB1 2CD"
            };

            validator.ShouldNotHaveValidationErrorFor(x => x.BankName, model);
            validator.ShouldNotHaveValidationErrorFor(x => x.AddressLine1, model);
            validator.ShouldNotHaveValidationErrorFor(x => x.PostCode, model);
        }

        [TestMethod]
        [TestCategory("Bank Details")]
        public void BankDetailsInValidModel()
        {
            var model = new BankDetails()
            {
                BankName = "",
                AddressLine1 = "",
                PostCode = "",
                Country = ""
            };

            validator.ShouldHaveValidationErrorFor(x => x.BankName, model);
            validator.ShouldHaveValidationErrorFor(x => x.AddressLine1, model);
            validator.ShouldHaveValidationErrorFor(x => x.PostCode, model);
            validator.ShouldHaveValidationErrorFor(x => x.Country, model);

            var validationResult = validator.Validate(model);

            validationResult.IsValid.Should().BeFalse();
            validationResult.Errors.Count.Should().Be(6);
        }
    }
}
