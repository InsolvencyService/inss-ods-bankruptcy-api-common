using FluentAssertions;
using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.BankAccount;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.BankAccount;

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

        var validationResult = validator.TestValidate(model);

        validationResult.ShouldNotHaveValidationErrorFor(x => x.AccountNumber);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.CurrentBalance);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.DateOpened);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.JointAccount);

        validationResult.IsValid.Should().BeTrue();
        validationResult.Errors.Count.Should().Be(0);
    }

    [TestMethod]
    [TestCategory("Bank Account Details")]
    public void BankAccountDetailsInValidModel()
    {
        var model = new BankAccountDetails();

        var validationResult = validator.TestValidate(model);

        validationResult.ShouldHaveValidationErrorFor(x => x.AccountNumber);
        validationResult.ShouldHaveValidationErrorFor(x => x.CurrentBalance);
        validationResult.ShouldHaveValidationErrorFor(x => x.DateOpened);
        validationResult.ShouldHaveValidationErrorFor(x => x.JointAccount);
        validationResult.IsValid.Should().BeFalse();
        validationResult.Errors.Count.Should().Be(4);
    }
}
