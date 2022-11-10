using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using INSS.ODS.Bankruptcy.API.Common.Models.CompanyDirectorships;
using INSS.ODS.Bankruptcy.API.Common.Resources.Shared;
using INSS.ODS.Bankruptcy.API.Common.Models.Constants;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.CompanyDirectorships
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class InsolvencyPractitionerTest
    {
        private InsolvencyPractitionerValidator _validator;

        [TestInitialize]
        public void Setup()
        {
            _validator = new InsolvencyPractitionerValidator();
        }

        [TestMethod]
        [TestCategory("InsolvencyPractitioner")]
        public void InsolvencyPractitioner_MissingFields()
        {
            var model = new InsolvencyPractitioner();

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(model);

            Assert.IsFalse(modelState.IsValid);

            // Required fields
            Assert.IsTrue(modelState["FirstName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_FirstName_Error_Empty));
            Assert.IsTrue(modelState["LastName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_LastName_Error_Empty));
        }

        [TestMethod]
        [TestCategory("InsolvencyPractitioner")]
        public void InsolvencyPractitioner_InvalidData_TooLong()
        {
            var model = new InsolvencyPractitioner()
            {
                FirstName = "ABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJA",
                LastName = "ABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEF"
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(model);

            Assert.IsFalse(modelState.IsValid);

            // Required fields
            Assert.IsTrue(modelState["FirstName"].Errors.Any(x => x.ErrorMessage == String.Format(NameResources.Shared_Name_FirstName_Error_MaxLength, NameValidationConstants.FirstName_MaxSize + 1)));
            Assert.IsTrue(modelState["LastName"].Errors.Any(x => x.ErrorMessage == String.Format(NameResources.Shared_Name_LastName_Error_MaxLength, NameValidationConstants.LastName_MaxSize + 1)));
        }

        [TestMethod]
        [TestCategory("InsolvencyPractitioner")]
        public void InsolvencyPractitioner_InvalidData_InvalidLetters()
        {
            var model = new InsolvencyPractitioner()
            {
                FirstName = "John(",
                LastName = "W^Smith"
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(model);

            Assert.IsFalse(modelState.IsValid);

            // Required fields
            Assert.IsTrue(modelState["FirstName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_FirstName_Error_InvalidLetters));
            Assert.IsTrue(modelState["LastName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_LastName_Error_InvalidLetters));
        }

        [TestMethod]
        [TestCategory("InsolvencyPractitioner")]
        public void InsolvencyPractitioner_ShouldPassOn_ValidValues()
        {
            var model = new InsolvencyPractitioner()
            {
                FirstName = "Mary-Jo",
                LastName = "O'Reilly",
                Address = new Address
                {
                    Address_1 = "Some Street",
                    PostCode = "SO3 5TR",
                    Country = "UK",
                    TownCity ="Test"
                }
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(model);

            Assert.IsTrue(modelState.IsValid);
        }

         
        [TestMethod]
        [TestCategory("InsolvencyPractitioner")]
        public void InsolvencyPractitioner_Address_ShouldHaveChildValidator()
        {
            _validator.ShouldHaveChildValidator(x => x.Address, typeof (AddressValidator));
        }

    }
}
