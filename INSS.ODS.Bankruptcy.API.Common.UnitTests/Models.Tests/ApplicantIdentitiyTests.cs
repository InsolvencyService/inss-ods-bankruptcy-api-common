using INSS.ODS.API.Common.Utilities.TestHelpers;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Constants;
using INSS.ODS.Bankruptcy.API.Common.Resources.Application;
using INSS.ODS.Bankruptcy.API.Common.Resources.Shared;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class ApplicantIdentitiyTests
    {
        [TestInitialize]
        public void Setup()
        {
        }

        [TestMethod]
        public void ApplicationIdentityValidModel()
        {
            var identity = new ApplicantIdentity() { 
                Urn = "testurnmarch",
                FirstName = "John",
                LastName = "Henry",
                DateOfBirth = new DateTime(1976, 12, 15),
                Email = "john.henry@steelmill.com",
                ConfirmEmail = "john.henry@steelmill.com",
                CreatedOnDate = DateTime.Now
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(identity);

            Assert.IsTrue(modelState.IsValid);
        }

        [TestMethod]
        public void ApplicationIdentityMissingFields()
        {
            var identity = new ApplicantIdentity();

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(identity);

            Assert.IsFalse(modelState.IsValid);

            // Required fields
            Assert.IsTrue(modelState["FirstName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_ApplicantFirstName_Error_Empty));
            Assert.IsTrue(modelState["LastName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_ApplicantLastName_Error_Empty));
            Assert.IsTrue(modelState["DateOfBirth.Date"].Errors.Any(x => x.ErrorMessage == StartResources.Application_Start_DateOfBirth_Error_Empty));

            // value fields that will always have some value, even when not assigned 
            Assert.IsNull(modelState["Id"]);
 
            //No error generated for Optional values 
            Assert.IsNull(modelState["PersonalDetails"]);
        }

        [TestMethod]
        public void ApplicationIdentityFormatErrors1()
        {
            var identity = new ApplicantIdentity()
            {
                FirstName = "",
                LastName = "AbcdefghijklmnopqrstuvwxyzAbcdefghij", //36 chars, 35 allowed
                DateOfBirth = new DateTime(3001, 12, 15),
                Email = "john.henry",
                ConfirmEmail = "john.henry@steelmill.com",
            };
            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(identity);

            Assert.IsFalse(modelState.IsValid);

            Assert.IsTrue(modelState["FirstName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_ApplicantFirstName_Error_Empty));
            Assert.IsTrue(modelState["LastName"].Errors.Any(x => x.ErrorMessage == String.Format(NameResources.Shared_Name_ApplicantLastName_Error_MaxLength, NameValidationConstants.LastName_MaxSize + 1)));
            Assert.IsTrue(modelState["DateOfBirth"].Errors.Any(x => x.ErrorMessage == String.Format(StartResources.Application_Start_DateOfBirth_Error_MinimumAge, new String[] { "18" })));
        }

        [TestMethod]
        public void ApplicationIdentityFormatErrors2()
        {
            var identity = new ApplicantIdentity()
            {
                FirstName = "AbcdefghijklmnopqrstuvwxyzAbcdefghijklmnopqrstuvwxyzAbcdefghijklmnopqrs", //71 chars, 70 allowed
                LastName = "",
                DateOfBirth = new DateTime(1800, 1, 1),
                Email = "john.henry@steelmill.com",
                ConfirmEmail = "john.henry@steelmill.com",
            };
            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(identity);

            Assert.IsFalse(modelState.IsValid);

            Assert.IsTrue(modelState["FirstName"].Errors.Any(x => x.ErrorMessage == String.Format(NameResources.Shared_Name_ApplicantFirstName_Error_MaxLength, NameValidationConstants.FirstName_MaxSize + 1)));
            Assert.IsTrue(modelState["LastName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_ApplicantLastName_Error_Empty));
            Assert.IsTrue(modelState["DateOfBirth.Date"].Errors.Any(x => x.ErrorMessage == String.Format(StartResources.Application_Start_DateOfBirth_Error_MinimumDate, new String[] { "01/01/1900" })));
        }
    }

}
