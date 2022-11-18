using FluentAssertions;
using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.BankAccount;

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

        var validationResult = validator.TestValidate(model);

        validationResult.ShouldNotHaveValidationErrorFor(x => x.BankName);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.AddressLine1);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.PostCode);
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

        var validationResult = validator.TestValidate(model);

        validationResult.ShouldHaveValidationErrorFor(x => x.BankName);
        validationResult.ShouldHaveValidationErrorFor(x => x.AddressLine1);
        validationResult.ShouldHaveValidationErrorFor(x => x.PostCode);
        validationResult.ShouldHaveValidationErrorFor(x => x.Country);

        validationResult.IsValid.Should().BeFalse();
        validationResult.Errors.Count.Should().Be(6);
    }
}
