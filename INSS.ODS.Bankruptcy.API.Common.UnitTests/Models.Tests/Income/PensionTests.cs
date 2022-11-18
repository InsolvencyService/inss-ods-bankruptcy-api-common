using FluentAssertions;
using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Income;

[TestClass]
public class PensionTests
{
    private PensionValidator validator;

    [TestInitialize]
    public void Setup()
    {
        validator = new PensionValidator();
    }

    [TestMethod]
    public void PensionValidModel()
    {
        var pension = new Pension();

        pension.PensionCredit = 1000;
        pension.State = 1000;

        var validationResult = validator.TestValidate(pension);

        validationResult.ShouldNotHaveValidationErrorFor(x => x.PensionCredit);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.State);
    }

    [TestMethod]
    public void PensionInValidModel()
    {
        var pension = new Pension();

        pension.PensionCredit = -1;
        pension.State = -1;

        var validationResult = validator.TestValidate(pension);

        validationResult.ShouldHaveValidationErrorFor(x => x.PensionCredit);
        validationResult.ShouldHaveValidationErrorFor(x => x.State);

        validationResult.IsValid.Should().BeFalse();
        validationResult.Errors.Count.Should().Be(2);
    }

    [TestMethod]
    public void PensionTotallingTest()
    {
        var pension = new Pension();
        Assert.IsTrue(pension.IsNotStarted);

        pension.State = 100;
        pension.State_Frequency = "per week";
        pension.PensionCredit = 100;
        pension.PensionCredit_Frequency = "per week";

        pension.OtherPensions = new List<OtherPension>
        {
            new OtherPension
            {
                Value = 100,
                Frequency = "per week"
            }
        };

        Assert.IsFalse(pension.IsNotStarted);
        Assert.AreEqual(1299.99m, pension.Total);
    }
}
