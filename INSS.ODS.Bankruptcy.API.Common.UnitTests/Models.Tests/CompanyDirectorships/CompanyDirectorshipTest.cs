using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.CompanyDirectorships;

[TestClass]
public class CompanyDirectorshipTest
{
    private CompanyDirectorshipValidator _validator;

    [TestInitialize]
    public void Setup()
    {
        _validator = new CompanyDirectorshipValidator();
    }

    [TestMethod]
    [TestCategory("CompanyDirectorship")]
    public void CompanyDirectorshipInvalidModel_LimitedCompanyName()
    {
        var model = new CompanyDirectorship();
        model.LimitedCompanyName = "";

        var validationResult = _validator.TestValidate(model);

        validationResult.ShouldHaveValidationErrorFor(x => x.LimitedCompanyName);

        model.LimitedCompanyName = "1";
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.LimitedCompanyName);

        model.LimitedCompanyName = "12345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901";
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.LimitedCompanyName);

        model.LimitedCompanyName = "My Company";
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.LimitedCompanyName);

        model.LimitedCompanyName = "My Company $";
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.LimitedCompanyName);
    }

    [TestMethod]
    [TestCategory("CompanyDirectorship")]
    public void CompanyDirectorshipValidModel_LimitedCompanyName()
    {
        var model = new CompanyDirectorship();

        model.LimitedCompanyName = "My Company Ltd";

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.LimitedCompanyName);
    }

    [TestMethod]
    [TestCategory("CompanyDirectorship")]
    public void CompanyDirectorship_IsCompanyRegisteredInTheUK_ShouldErrorOnInvalidValue()
    {
        var model = new CompanyDirectorship();

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.IsCompanyRegisteredInTheUK);
    }

    [TestMethod]
    [TestCategory("CompanyDirectorship")]
    public void CompanyDirectorship_AreYourAnActiveDirector_ShouldErrorOnInvalidValue()
    {
        var model = new CompanyDirectorship();

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.AreYouStillAnActiveDirector);
    }

    [TestMethod]
    [TestCategory("CompanyDirectorship")]
    public void CompanyDirectorship_AreYouAnActiveDirector_ShouldPassOnValidValue()
    {
        var model = new CompanyDirectorship()
        {
            AreYouStillAnActiveDirector = true
        };

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.AreYouStillAnActiveDirector);
    }

    [TestMethod]
    [TestCategory("CompanyDirectorship")]
    public void CompanyDirectorship_IsCompanyRegisteredInTheUK_ShouldPassOnValidValue()
    {
        var model = new CompanyDirectorship()
        {
            IsCompanyRegisteredInTheUK = true
        };

        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.IsCompanyRegisteredInTheUK);
    }

    [TestMethod]
    [TestCategory("CompanyDirectorship")]
    public void CompanyDirectorship_CompanyRegistrationNumber_WhenCompanyIsRegisteredInUK_ShouldErrorOnInvalidValue()
    {
        var model = new CompanyDirectorship()
        {
            IsCompanyRegisteredInTheUK = true
        };

        model.CompanyRegistrationNumber = "";
        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationNumber);

        model.CompanyRegistrationNumber = "123456789";
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationNumber);

        model.CompanyRegistrationNumber = "1234567";
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationNumber);

        model.CompanyRegistrationNumber = "A1234567";
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationNumber);

        model.CompanyRegistrationNumber = "ABC12345";
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationNumber);

        model.CompanyRegistrationNumber = "AB12345B";
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationNumber);
    }

    [TestMethod]
    [TestCategory("CompanyDirectorship")]
    public void CompanyDirectorship_CompanyRegistrationNumber_WhenCompanyIsRegisteredInUK_ShouldPassOnValidValue()
    {
        var model = new CompanyDirectorship()
        {
            IsCompanyRegisteredInTheUK = true,
            CompanyRegistrationNumber = ""
        };

        model.CompanyRegistrationNumber = "AB123456";
        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.CompanyRegistrationNumber);

        model.CompanyRegistrationNumber = "12345678";
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.CompanyRegistrationNumber);
    }

    [TestMethod]
    [TestCategory("CompanyDirectorship")]
    public void CompanyDirectorship_CompanyRegistrationCountry_WhenCompanyIsNotRegisteredInUK_ShouldErrorOnInvalidValue()
    {
        var model = new CompanyDirectorship()
        {
            IsCompanyRegisteredInTheUK = false
        };

        model.CompanyRegistrationCountry = "";
        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationCountry);

        model.CompanyRegistrationCountry = "A";
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationCountry);

        model.CompanyRegistrationCountry = "ABCEDFGHI!";
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationCountry);

        model.CompanyRegistrationCountry = "ABCDEFGHIJAABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJ";
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationCountry);

        model.CompanyRegistrationCountry = "12345678";
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationCountry);
    }

    [TestMethod]
    [TestCategory("CompanyDirectorship")]
    public void CompanyDirectorship_CompanyRegistrationCountry_WhenCompanyIsRegisteredNotInUK_ShouldPassOnValidValue()
    {
        var model = new CompanyDirectorship()
        {
            IsCompanyRegisteredInTheUK = false,
            CompanyRegistrationNumber = ""
        };

        model.CompanyRegistrationCountry = "France";
        var validationResult = _validator.TestValidate(model);

        validationResult.ShouldNotHaveValidationErrorFor(x => x.CompanyRegistrationCountry);
    }

    [TestMethod]
    [TestCategory("CompanyDirectorship")]
    public void CompanyDirectorship_CompanyRegistrationNumber_WhenCompanyIsNotRegisteredInUK_ShouldErrorOnInvalidValue()
    {
        var model = new CompanyDirectorship()
        {
            IsCompanyRegisteredInTheUK = false
        };

        model.CompanyRegistrationNumber = "";
        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.CompanyRegistrationNumber);

        model.CompanyRegistrationNumber = "123";
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationNumber);

        model.CompanyRegistrationNumber = "123456789012345678901";
        validationResult = _validator.TestValidate(model);
        validationResult.ShouldHaveValidationErrorFor(x => x.CompanyRegistrationNumber);
    }

    [TestMethod]
    [TestCategory("CompanyDirectorship")]
    public void CompanyDirectorship_CompanyRegistrationNumber_WhenCompanyIsRegisteredNotInUK_ShouldPassOnValidValue()
    {
        var model = new CompanyDirectorship()
        {
            IsCompanyRegisteredInTheUK = false,
            CompanyRegistrationNumber = ""
        };

        model.CompanyRegistrationNumber = "FR1234567890";
        var validationResult = _validator.TestValidate(model);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.CompanyRegistrationNumber);
    }
}
