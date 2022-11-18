using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Creditors;
using System.ComponentModel.DataAnnotations;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Creditors;

[TestClass]
public class MoneyOwedTests
{

    private MoneyOwedValidator validator;

    [TestInitialize]
    public void Setup()
    {
        validator = new MoneyOwedValidator();
    }

    [TestMethod]
    public void MoneyOwedInvalid()
    {

        var MoneyOwed = new MoneyOwed
        {

        };

        var validationResult = validator.TestValidate(MoneyOwed);

        validationResult.ShouldHaveValidationErrorFor(x => x.IsMoneyOwed);
    }

    [TestMethod]
    public void MoneyOwedValid()
    {
        var MoneyOwed = new MoneyOwed
        {
            IsMoneyOwed = true
        };

        var validationResult = validator.TestValidate(MoneyOwed);

        validationResult.ShouldNotHaveValidationErrorFor(x => x.IsMoneyOwed);

        var context = new System.ComponentModel.DataAnnotations.ValidationContext(MoneyOwed, null, null);
        var results = new List<ValidationResult>();
        var isModelStateValid = Validator.TryValidateObject(MoneyOwed, context, results, true);

        Assert.IsTrue(isModelStateValid);
    }
}
