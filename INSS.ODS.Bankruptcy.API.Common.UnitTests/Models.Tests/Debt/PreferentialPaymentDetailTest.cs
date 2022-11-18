using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Debt;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Debt;

[TestClass]
public class PreferentialPaymentDetailTest
{
    private PreferentialPaymentDetailInterfaceValidator _validator;

    [TestInitialize]
    public void Setup()
    {
        _validator = new PreferentialPaymentDetailInterfaceValidator();
    }

    [TestMethod]
    [TestCategory("PreferentialPaymentDetail")]
    public void PreferentialPaymentDetail_MissingFields()
    {
        var model = new PreferentialPaymentDetail();

        var validationResult = _validator.TestValidate(model);

        validationResult.ShouldHaveValidationErrorFor(x => x.PaymentAmount);
        validationResult.ShouldHaveValidationErrorFor(x => x.PaymentDate);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.AssetName);
    }

    [TestMethod]
    [TestCategory("PreferentialPaymentDetail")]
    public void PreferentialPaymentDetail_PaymentDate_ShouldErrorOnInvalidValue()
    {
        var model = new PreferentialPaymentDetail();

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.PaymentDate);

        model.PaymentDate = DateTime.Now.AddYears(1);
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.PaymentDate);
    }

    [TestMethod]
    [TestCategory("PreferentialPaymentDetail")]
    public void PreferentialPaymentDetail_PaymentDate_ShouldPassOnValidValue()
    {
        var model = new PreferentialPaymentDetail();

        model.PaymentDate = DateTime.Now.AddYears(-1);
        var validationResult = _validator.TestValidate(model);

        validationResult.ShouldNotHaveValidationErrorFor(x => x.PaymentDate);
    }

    [TestMethod]
    [TestCategory("PreferentialPaymentDetail")]
    public void PreferentialPaymentDetail_PaymentAmount_ShouldErrorOnInvalidValue()
    {
        var model = new PreferentialPaymentDetail();

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.PaymentAmount);

        model.PaymentAmount = -100;
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.PaymentAmount);
    }

    [TestMethod]
    [TestCategory("PreferentialPaymentDetail")]
    public void PreferentialPaymentDetail_PaymentAmount_ShouldPassOnValidValue()
    {
        var model = new PreferentialPaymentDetail()
        {
            PaymentAmount = 200
        };

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.PaymentAmount);
    }

    [TestMethod]
    [TestCategory("PreferentialPaymentDetail")]
    public void PreferentialPaymentDetail_AssetName_ShouldErrorOnInvalidValue()
    {
        var model = new PreferentialPaymentDetail()
        {
            AssetName = "ABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJA"
        };

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.AssetName);


        model.AssetName = "A";
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.AssetName);
    }

    [TestMethod]
    [TestCategory("PreferentialPaymentDetail")]
    public void PreferentialPaymentDetail_AssetName_ShouldPassOnValidValue()
    {
        var model = new PreferentialPaymentDetail()
        {
            AssetName = "TV"
        };

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.AssetName);
    }
}
