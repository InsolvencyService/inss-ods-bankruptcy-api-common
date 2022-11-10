using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
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

            validator.ShouldNotHaveValidationErrorFor(x => x.IncludedDebtsFromAnotherApplication, applicationContinueWithSubmit);
            validator.ShouldNotHaveValidationErrorFor(x => x.AppliedForPAVOrder, applicationContinueWithSubmit);
            validator.ShouldNotHaveValidationErrorFor(x => x.SpokenToDebtAdvisor, applicationContinueWithSubmit);

        }

        [TestMethod]
        [TestCategory("Application Continue With Submit")]
        public void ApplicationContinueWithSubmitInValidModel()
        {
            var applicationContinueWithSubmit = new ApplicationSubmissionQuestions();

            applicationContinueWithSubmit.IncludedDebtsFromAnotherApplication = null;
            applicationContinueWithSubmit.AppliedForPAVOrder = null;
            applicationContinueWithSubmit.SpokenToDebtAdvisor = null;

            validator.ShouldHaveValidationErrorFor(x => x.IncludedDebtsFromAnotherApplication, applicationContinueWithSubmit);
            validator.ShouldHaveValidationErrorFor(x => x.AppliedForPAVOrder, applicationContinueWithSubmit);
            validator.ShouldHaveValidationErrorFor(x => x.SpokenToDebtAdvisor, applicationContinueWithSubmit);

            var context = new ValidationContext(applicationContinueWithSubmit, null, null);
            var results = new List<ValidationResult>();
            var isModelStateValid = Validator.TryValidateObject(applicationContinueWithSubmit, context, results, true);

            Assert.IsTrue(isModelStateValid);


        }

    }
}
