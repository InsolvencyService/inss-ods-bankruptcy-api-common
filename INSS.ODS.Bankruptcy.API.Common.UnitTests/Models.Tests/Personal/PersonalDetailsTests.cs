using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.Models;
using System.Linq;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using INSS.ODS.Bankruptcy.API.Common.Resources.Shared;
using INSS.ODS.Bankruptcy.API.Common.Resources.Personal;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class PersonalDetailsTests
    {
        [TestMethod]
        public void PersonalDetailsValidModel()
        {
            var personalDetails = new PersonalDetails();

            personalDetails.Title = "Mr";
            personalDetails.TitleOther = "";
            personalDetails.FirstName = "John";
            personalDetails.LastName = "Henry";
            personalDetails.MiddleNames = "";
            personalDetails.DateOfBirth = new DateTime(1980, 9, 1);

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(personalDetails);

            Assert.IsTrue(modelState.IsValid);
        }

        [TestMethod]
        public void PersonalDetailsInvalidModel()
        {
            var personalDetails = new PersonalDetails();

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(personalDetails);

            Assert.IsFalse(modelState.IsValid);

            Assert.IsTrue(modelState["Title"].Errors
                .Any(r => r.ErrorMessage == StartResources.Personal_Start_Title_Error_Empty));

            Assert.IsTrue(modelState["FirstName"].Errors
                .Any(r => r.ErrorMessage == NameResources.Shared_Name_ApplicantFirstName_Error_Empty));

            Assert.IsTrue(modelState["LastName"].Errors
                .Any(r => r.ErrorMessage == NameResources.Shared_Name_ApplicantLastName_Error_Empty));

            Assert.IsTrue(modelState["DateOfBirth.Date"].Errors
                .Any(r => r.ErrorMessage == StartResources.Personal_Start_DateOfBirth_Error_Empty));
        }

        //need to reinstate this test. does not work as cannot test custom validators,  due to required IncludeInterfacesModelValidatorProvider()

        //[TestMethod]
        //public void PersonalDetailsTitleOtherTest()
        //{
        //    var personalDetails = new PersonalDetails();

        //    personalDetails.ApplicantIdentity = new ApplicantIdentity();
        //    personalDetails.Title = "Other";
        //    personalDetails.TitleOther = "";
        //    personalDetails.FirstName = "John";
        //    personalDetails.LastName = "Smith";
        //    personalDetails.MiddleNames = "";
        //    personalDetails.RelationshipStatus = "Single";
        //    personalDetails.DateOfBirth = new DateTime(1980, 9, 1);

        //    var context = new ValidationContext(personalDetails, null, null);
        //    var results = new List<ValidationResult>();
        //    var isModelStateValid = Validator.TryValidateObject(personalDetails, context, results, true);

        //    Assert.IsFalse(isModelStateValid);

        //    Assert.IsTrue(results.Any(r => r.MemberNames.Contains("Title")));

        //    Assert.AreEqual(1, results.Count);

        //}


    }
}
