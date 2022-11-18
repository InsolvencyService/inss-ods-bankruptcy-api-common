using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using System.ComponentModel.DataAnnotations;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests;

[TestClass]
public class ApplicationContinueWithSubmitTests
{
    private ApplicationSubmissionQuestionsValidator validator;

    [TestInitialize]
    public void Setup()
    {
        validator = new ApplicationSubmissionQuestionsValidator();
    }

    [TestMethod]
    [TestCategory("Application Continue With Submit")]
    public void ApplicationContinueWithSubmitValidModel()
    {
        var applicationContinueWithSubmit = new ApplicationSubmissionQuestions();

        applicationContinueWithSubmit.IncludedDebtsFromAnotherApplication = true;
        applicationContinueWithSubmit.AppliedForPAVOrder = true;
        applicationContinueWithSubmit.SpokenToDebtAdvisor = true;

        var validationResult = validator.TestValidate(applicationContinueWithSubmit);

        validationResult.ShouldNotHaveValidationErrorFor(x => x.IncludedDebtsFromAnotherApplication);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.AppliedForPAVOrder);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.SpokenToDebtAdvisor);
    }

    [TestMethod]
    [TestCategory("Application Continue With Submit")]
    public void ApplicationContinueWithSubmitInValidModel()
    {
        var applicationContinueWithSubmit = new ApplicationSubmissionQuestions();

        applicationContinueWithSubmit.IncludedDebtsFromAnotherApplication = null;
        applicationContinueWithSubmit.AppliedForPAVOrder = null;
        applicationContinueWithSubmit.SpokenToDebtAdvisor = null;

        var validationResult = validator.TestValidate(applicationContinueWithSubmit);

        validationResult.ShouldHaveValidationErrorFor(x => x.IncludedDebtsFromAnotherApplication);
        validationResult.ShouldHaveValidationErrorFor(x => x.AppliedForPAVOrder);
        validationResult.ShouldHaveValidationErrorFor(x => x.SpokenToDebtAdvisor);

        var context = new ValidationContext(applicationContinueWithSubmit, null, null);
        var results = new List<ValidationResult>();
        var isModelStateValid = Validator.TryValidateObject(applicationContinueWithSubmit, context, results, true);

        Assert.IsTrue(isModelStateValid);
    }
}
