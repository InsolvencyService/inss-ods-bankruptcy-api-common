using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using System.Linq;
using INSS.ODS.Bankruptcy.API.Common.Resources.Application;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]

    public class ApplicantSecurityQuestionAnswerItemTests
    {
        [TestInitialize]
        public void Setup()
        {
        }

        [TestMethod]
        public void ApplicantSecurityQuestionAnswerItemTestsValidModel()
        {
            var item = new ApplicantSecurityQuestionAnswerItem()
            { 
                SecurityQuestion = "Question 1",
                SecurityAnswer = "Answer 1"
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(item);

            Assert.IsTrue(modelState.IsValid);
        }

        [TestMethod]
        public void ApplicantSecurityQuestionAnswerItemMissingFields()
        {
            var item = new ApplicantSecurityQuestionAnswerItem();

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(item);

            Assert.IsFalse(modelState.IsValid);

            // Required fields
            Assert.IsTrue(modelState["SecurityQuestion"].Errors.Any(x => x.ErrorMessage == String.Format(AnswerSecurityQuestionsResources.Application_AnswerSecurityQuestions_SecurityQuestion_Empty, new String[] { "1" })));
            Assert.IsTrue(modelState["SecurityAnswer"].Errors.Any(x => x.ErrorMessage == String.Format(AnswerSecurityQuestionsResources.Application_AnswerSecurityQuestions_SecurityAnswer_Empty, new String[] { "1" })));

            // value fields that will always have some value, even when not assigned 
            Assert.IsNull(modelState["Id"]);
            Assert.IsNull(modelState["ItemIndex"]);
        }

        [TestMethod]
        public void ApplicantSecurityQuestionAnswerItemMFormatErrors1()
        {
            var item = new ApplicantSecurityQuestionAnswerItem()
            {
                SecurityQuestion = "Question 1", //No format error on questions at the moment as they are chosen from config table in the database
                SecurityAnswer = "AB" //Minimum 3 required
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(item);

            Assert.IsFalse(modelState.IsValid);

            // Required fields
            Assert.IsTrue(modelState["SecurityAnswer"].Errors.Any(x => x.ErrorMessage == AnswerSecurityQuestionsResources.Application_AnswerSecurityQuestions_SecurityAnswer_FormatError));

            // no format error on question
            Assert.IsNull(modelState["SecurityQuestion"]);
        }

        [TestMethod]
        public void ApplicantSecurityQuestionAnswerItemMFormatErrors2()
        {

            var item = new ApplicantSecurityQuestionAnswerItem()
            {
                SecurityQuestion = "Question 1", //No format error on questions at the moment as they are chosen from config table in the database
                SecurityAnswer = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ123ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ123ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ123ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890ABCDEFGHIJKLMNOPQRST" //251 chars, 250 allowed
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(item);

            Assert.IsFalse(modelState.IsValid);

            // Required fields
            Assert.IsTrue(modelState["SecurityAnswer"].Errors.Any(x => x.ErrorMessage == AnswerSecurityQuestionsResources.Application_AnswerSecurityQuestions_SecurityAnswer_FormatError));

            // no format error on question
            Assert.IsNull(modelState["SecurityQuestion"]);
        }
    }

}
