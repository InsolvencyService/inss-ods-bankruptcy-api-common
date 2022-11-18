using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Debt;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Debt;

[TestClass]
public class DebtIncurredDetailTest
{
    private DebtIncurredDetailInterfaceValidator _validator;

    [TestInitialize]
    public void Setup()
    {
        _validator = new DebtIncurredDetailInterfaceValidator();
    }

    [TestMethod]
    [TestCategory("DebtIncurredDetail")]
    public void DebtIncurredDetail_StartDate_ShouldErrorOnInvalidValue()
    {
        var model = new DebtIncurredDetail();

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.StartDate);

        model.StartDate = DateTime.Now.AddYears(1);
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.StartDate);
    }

    [TestMethod]
    [TestCategory("DebtIncurredDetail")]
    public void DebtIncurredDetail_StartDate_ShouldPassOnValidValue()
    {
        var model = new DebtIncurredDetail();

        model.StartDate = DateTime.Now.AddYears(-1);
        var validationResult = _validator.TestValidate(model);

        validationResult.ShouldNotHaveValidationErrorFor(x => x.StartDate);
    }

    [TestMethod]
    [TestCategory("DebtIncurredDetail")]
    public void DebtIncurredDetail_ReasonSelected_ShouldErrorOnInvalidValue()
    {
        var model = new DebtIncurredDetail()
        {
            StartDate = DateTime.Now.AddYears(-1)
        };

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.DebtIncurredReasonValidationHook);
    }

    [TestMethod]
    [TestCategory("DebtIncurredDetail")]
    public void DebtIncurredDetail_ReasonSelected_ShouldErrorOnValidValue()
    {
        var model = new DebtIncurredDetail()
        {
            StartDate = DateTime.Now.AddYears(-1),
            PersonalRelationshipBreakdown = true
        };

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.DebtIncurredReasonValidationHook);
    }

    [TestMethod]
    [TestCategory("DebtIncurredDetail")]
    public void DebtIncurredDetail_GamblingAmount_ShouldErrorOnInvalidValue()
    {
        var model = new DebtIncurredDetail()
        {
            PersonalGambling = true
        };

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.GamblingAmount);

        model.GamblingAmount = -100;
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.GamblingAmount);
    }

    [TestMethod]
    [TestCategory("DebtIncurredDetail")]
    public void DebtIncurredDetail_GamblingAmount_ShouldPassOnValidValue()
    {
        var model = new DebtIncurredDetail()
        {
            PersonalGambling = true,
            GamblingAmount = 200
        };

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.GamblingAmount);
    }

    [TestMethod]
    [TestCategory("DebtIncurredDetail")]
    public void DebtIncurredDetail_PersonalOtherText_ShouldErrorOnInvalidValue()
    {
        var model = new DebtIncurredDetail()
        {
            PersonalOther = true
        };

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.PersonalDebtIncurredReasonValidationHook);

        model.PersonalOtherText = "ABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJA";
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.PersonalDebtIncurredReasonValidationHook);
    }

    [TestMethod]
    [TestCategory("DebtIncurredDetail")]
    public void DebtIncurredDetail_PersonalOtherText_ShouldPassOnValidValue()
    {
        var model = new DebtIncurredDetail()
        {
            PersonalOther = true,
            PersonalOtherText = "Because of some other reason"
        };

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.PersonalDebtIncurredReasonValidationHook);
    }

    [TestMethod]
    [TestCategory("DebtIncurredDetail")]
    public void DebtIncurredDetail_BusinessOtherText_ShouldErrorOnInvalidValue()
    {
        var model = new DebtIncurredDetail()
        {
            BusinessOther = true
        };

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.BusinessDebtIncurredReasonValidationHook);

        model.BusinessOtherText = "ABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJA";
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.BusinessDebtIncurredReasonValidationHook);
    }

    [TestMethod]
    [TestCategory("DebtIncurredDetail")]
    public void DebtIncurredDetail_BusinessOtherText_ShouldPassOnValidValue()
    {
        var model = new DebtIncurredDetail()
        {
            BusinessOther = true,
            BusinessOtherText = "Because of some other reason"
        };

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.BusinessDebtIncurredReasonValidationHook);

    }
}
