using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Debt;
using INSS.ODS.Bankruptcy.API.Common.Resources.Debt;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Debt;

[TestClass]
public class DebtReliefOptionUsedTest
{
    private DebtReliefOptionUsedInterfaceValidator _validator;

    [TestInitialize]
    public void Setup()
    {
        _validator = new DebtReliefOptionUsedInterfaceValidator();
    }

    [TestMethod]
    [TestCategory("DebtReliefOptionUsed")]
    public void DebtReliefHistory_DebtReliefOptionStartDate_ShouldErrorOnInvalidValue()
    {
        var model = new DebtReliefOptionUsed();

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.DebtReliefOptionStartDate);

        model.DebtReliefOptionStartDate = DateTime.Now.AddYears(1);
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.DebtReliefOptionStartDate);
    }

    [TestMethod]
    [TestCategory("DebtReliefOptionUsed")]
    public void DebtReliefHistory_DebtReliefOptionStartDate_ShouldPassOnValidValue()
    {
        var model = new DebtReliefOptionUsed()
        {
            DebtReliefOptionStartDate = new DateTime(2012, 1, 1)
        };

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.DebtReliefOptionStartDate);
    }

    [TestMethod]
    [TestCategory("DebtReliefOptionUsed")]
    public void DebtReliefHistory_DebtReliefOptionReferenceNumber_ShouldErrorOnInvalidValue()
    {
        var model = new DebtReliefOptionUsed()
        {
            DebtReliefOptionType = DebtReliefHistoryResources.Debt_DebtReliefHistory_DebtReliefOptionType_Bankruptcy_Label
        };

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.DebtReliefOptionReferenceNumber);

        model.DebtReliefOptionType = DebtReliefHistoryResources.Debt_DebtReliefHistory_DebtReliefOptionType_DebtReliefOrder_Label;
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.DebtReliefOptionReferenceNumber);
    }

    [TestMethod]
    [TestCategory("DebtReliefOptionUsed")]
    public void DebtReliefHistory_DebtReliefOptionReferenceNumber_ShouldPassOnValidValue()
    {
        var model = new DebtReliefOptionUsed()
        {
            DebtReliefOptionType = DebtReliefHistoryResources.Debt_DebtReliefHistory_DebtReliefOptionType_Bankruptcy_Label,
            DebtReliefOptionReferenceNumber = "AB123456"
        };

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.DebtReliefOptionReferenceNumber);

        model.DebtReliefOptionType = DebtReliefHistoryResources.Debt_DebtReliefHistory_DebtReliefOptionType_DebtReliefOrder_Label;
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.DebtReliefOptionReferenceNumber);

        model.DebtReliefOptionType = DebtReliefHistoryResources.Debt_DebtReliefHistory_DebtReliefOptionType_DebtManagementPlan_Label;
        model.DebtReliefOptionReferenceNumber = "";
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.DebtReliefOptionReferenceNumber);
    }
}
