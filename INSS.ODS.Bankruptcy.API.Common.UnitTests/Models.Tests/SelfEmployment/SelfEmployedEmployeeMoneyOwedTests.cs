using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships;
using System.ComponentModel.DataAnnotations;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests;

[TestClass]
public class SelEmployedEmployeeMoneyOwedTests
{
    private SelfEmployedEmployeeMoneyOwedValidator validator;

    [TestInitialize]
    public void Setup()
    {
        validator = new SelfEmployedEmployeeMoneyOwedValidator();
    }

    [TestMethod]
    [TestCategory("Self Employed Employee Money Owed")]
    public void SelfEmployedEmployeeMoneyOwedValidModel()
    {
        var selfEmployedEmployeeMoneyOwed = new SelfEmployedEmployeeMoneyOwed();

        selfEmployedEmployeeMoneyOwed.Amount = 1;
        selfEmployedEmployeeMoneyOwed.Reason = "Test";

        var validationResult = validator.TestValidate(selfEmployedEmployeeMoneyOwed);

        validationResult.ShouldNotHaveValidationErrorFor(x => x.Amount);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.Reason);
    }

    [TestMethod]
    [TestCategory("Self Employed Employee Money Owed")]
    public void SelfEmployedEmployeeMoneyOwedInValidModel()
    {
        var selfEmployedEmployeeMoneyOwed = new SelfEmployedEmployeeMoneyOwed();

        selfEmployedEmployeeMoneyOwed.Amount = -1;
        selfEmployedEmployeeMoneyOwed.Reason = "";

        var validationResult = validator.TestValidate(selfEmployedEmployeeMoneyOwed);

        validationResult.ShouldHaveValidationErrorFor(x => x.Amount);
        validationResult.ShouldHaveValidationErrorFor(x => x.Reason);

        var context = new ValidationContext(selfEmployedEmployeeMoneyOwed, null, null);
        var results = new List<ValidationResult>();
        var isModelStateValid = Validator.TryValidateObject(selfEmployedEmployeeMoneyOwed, context, results, true);

        Assert.IsTrue(isModelStateValid);
    }
}
