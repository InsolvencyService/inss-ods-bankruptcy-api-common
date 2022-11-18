using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Debt;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Debt;

[TestClass]
public class DebtReliefHistoryTest
{
    private DebtReliefOptionUsedInterfaceValidator _validator;

    [TestInitialize]
    public void Setup()
    {
        _validator = new DebtReliefOptionUsedInterfaceValidator();
    }

    [TestMethod]
    [TestCategory("DebtReliefHistory")]
    public void DebtReliefHistory_DebtReliefOptionType_ShouldErrorOnInvalidValue()
    {
        var model = new DebtReliefOptionUsed();

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.DebtReliefOptionType);
    }

    [TestMethod]
    [TestCategory("DebtReliefHistory")]
    public void DebtReliefHistory_DebtReliefOptionType_ShouldPassOnValidValue()
    {
        var model = new DebtReliefOptionUsed()
        {
            DebtReliefOptionType = "Bankruptcy"
        };

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.DebtReliefOptionType);
    }
}
