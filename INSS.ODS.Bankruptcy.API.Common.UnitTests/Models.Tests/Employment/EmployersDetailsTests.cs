using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class EmployersDetailsTests
    {
        [TestMethod]
        [TestCategory("EmployersDetails")]
        public void EmployersDetailsValidModel()
        {
            var employersDetails = new EmployerDetails();

            employersDetails.EmployerName = "ABC Ltd";

            employersDetails.DateStarted = DateTime.Today;

            employersDetails.EmployerAddress = new Address
            {

                Address_1 = "Add1",
                Address_2 = "Add2",
                Address_3 = "Add3",
                TownCity = "TC",
                County = "C",
                PostCode = "B32 1RD",
                Country = "UK"
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(employersDetails);

            Assert.IsTrue(modelState.IsValid);
        }

        [TestMethod]
        [TestCategory("EmployersDetails")]
        public void EmployersDetailsInvalidModel()
        {
            //TODO: fix error 

            var employersDetails = new EmployerDetails();

            employersDetails.EmployerName = "";

            employersDetails.DateStarted = DateTime.Now;

            employersDetails.EmployerAddress = new Address
            {

                Address_1 = "Add1",
                Address_2 = "Add2",
                Address_3 = "Add3",
                TownCity = "TC",
                County = "C",
                PostCode = "B32 1RD",
                Country = "UK"
            };


            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(employersDetails);

            Assert.IsFalse(modelState.IsValid);

            //Assert.IsTrue(modelState["EmployerName"].Errors.Any(x => x.ErrorMessage == EmployersDetailsResources.Employment_EmployersDetails_EmployersName_Required));

        }

    }
}
