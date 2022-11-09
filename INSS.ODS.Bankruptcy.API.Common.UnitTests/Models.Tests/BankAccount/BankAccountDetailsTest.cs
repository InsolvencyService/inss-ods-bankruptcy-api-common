using System;
using FluentAssertions;
using FluentValidation.TestHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.BankAccount;
using INSS.ODS.Bankruptcy.API.Common.Models;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.BankAccount
{
    [TestClass]
    public class BankAccountDetailsTest
    {
        private BankAccountDetailsValidator validator;

        [TestInitialize]
        public void Setup()
        {
            validator = new BankAccountDetailsValidator();
        }

        [TestMethod]
        [TestCategory("Bank Account Details")]
        public void BankAccountDetailsValidModel()
        {
            var model = new BankAccountDetails()
            {
                AccountNumber = "12345678",
                CurrentBalance = -2500,
                DateOpened = new DateTime(2012, 12, 1),
                JointAccount = true
            };
            
            validator.ShouldNotHaveValidationErrorFor(x => x.AccountNumber, model);
            validator.ShouldNotHaveValidationErrorFor(x => x.CurrentBalance, model);
            validator.ShouldNotHaveValidationErrorFor(x => x.DateOpened, model);
            validator.ShouldNotHaveValidationErrorFor(x => x.JointAccount, model);

            var validationResult = validator.Validate(model);

            validationResult.IsValid.Should().BeTrue();
            validationResult.Errors.Count.Should().Be(0);
        }

        [TestMethod]
        [TestCategory("Bank Account Details")]
        public void BankAccountDetailsInValidModel()
        {
            var model = new BankAccountDetails();

            validator.ShouldHaveValidationErrorFor(x => x.AccountNumber, model);
            validator.ShouldHaveValidationErrorFor(x => x.CurrentBalance, model);
            validator.ShouldHaveValidationErrorFor(x => x.DateOpened, model);
            validator.ShouldHaveValidationErrorFor(x => x.JointAccount, model);

            var validationResult = validator.Validate(model);

            validationResult.IsValid.Should().BeFalse();
            validationResult.Errors.Count.Should().Be(4);
        }
    }
}
