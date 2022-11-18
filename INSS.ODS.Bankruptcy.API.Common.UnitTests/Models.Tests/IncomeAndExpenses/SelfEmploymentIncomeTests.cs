using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.IncomeAndExpenses;

[TestClass]
public class SelfEmploymentIncomeTests
{
    private SelfEmploymentIncomeValidator validator;

    [TestInitialize]
    public void Setup()
    {
        validator = new SelfEmploymentIncomeValidator();
    }

    [TestMethod]
    [TestCategory("Self Employment Income")]
    public void SelfEmploymentIncomeValidModel()
    {
        var selfEmploymentIncome = new SelfEmploymentIncome();

        selfEmploymentIncome.Profit = 1;
        selfEmploymentIncome.Profit_Frequency = "Weekly";
        selfEmploymentIncome.AccountingPeriodStart = DateTime.Now.AddDays(-10);
        selfEmploymentIncome.AccountingPeriodEnd = DateTime.Now.AddDays(-1);

        var validationResult = validator.TestValidate(selfEmploymentIncome);

        validationResult.ShouldNotHaveValidationErrorFor(x => x.Profit);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.AccountingPeriodStart);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.AccountingPeriodEnd);
    }

  

    [TestMethod]
    [TestCategory("Self Employment Income")]
    public void SelfEmploymentIncomeInValidModelWithProfitGreaterThanZero()
    {
        var selfEmploymentIncome = new SelfEmploymentIncome();
        selfEmploymentIncome.Profit = 10;
        selfEmploymentIncome.Profit_Frequency = "Weekly";

        var validationResult = validator.TestValidate(selfEmploymentIncome);

        validationResult.ShouldHaveValidationErrorFor(x => x.AccountingPeriodStart);
        validationResult.ShouldHaveValidationErrorFor(x => x.AccountingPeriodEnd);
    }
}
