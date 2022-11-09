using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using INSS.ODS.Bankruptcy.API.Common.Models;
using System.Linq;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using INSS.ODS.Bankruptcy.API.Common.Resources.Personal;
using INSS.ODS.Bankruptcy.API.Common.Resources.Shared;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class PersonalDetailsAdditionalTests
    {
        [TestMethod]
        public void PersonalDetailsAdditionalValidModel()
        {
            var personalDetailsAdditional = new PersonalDetailsAdditional();

            personalDetailsAdditional.Gender = "Man";
            personalDetailsAdditional.RelationshipStatus = "Single";
            personalDetailsAdditional.NationalInsuranceNumber = "AB123456C";

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(personalDetailsAdditional);

            Assert.IsTrue(modelState.IsValid);
        }

        [TestMethod]
        public void PersonalDetailsAdditionalInvalidModel()
        {
            var personalDetailsAdditional = new PersonalDetailsAdditional();

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(personalDetailsAdditional);

            Assert.IsFalse(modelState.IsValid);

            Assert.IsTrue(modelState["NationalInsuranceNumber"].Errors
                .Any(r => r.ErrorMessage == StartResources.Personal_Start_NationalInsuranceNumber_Error_Empty));

            Assert.IsTrue(modelState["Gender"].Errors
                .Any(r => r.ErrorMessage == StartResources.Personal_Start_Gender_Error_Empty));

            Assert.IsTrue(modelState["RelationshipStatus"].Errors
                .Any(r => r.ErrorMessage == StartResources.Personal_Start_RelationshipStatus_Error_Empty));

        }

        [TestMethod]
        public void PersonalDetailsAdditional_NationalInsuranceNumber_ShouldFailOnInvalidPayload()
        {
            var personalDetailsAdditional = new PersonalDetailsAdditional()
            {
                NationalInsuranceNumber = "ABCDEFGHI"
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(personalDetailsAdditional);

            Assert.IsFalse(modelState.IsValid);

            Assert.IsTrue(modelState["NationalInsuranceNumber"].Errors
                .Any(r => r.ErrorMessage == StartResources.Personal_Start_NationalInsuranceNumber_Error_InvalidFormat));
        }


        [TestMethod]
        public void PersonalDetailsAdditional_NationalInsuranceNumber_ShouldPassOnValidPayload()
        {
            var personalDetailsAdditional = new PersonalDetailsAdditional()
            {
                NationalInsuranceNumber = "AB123456C"
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(personalDetailsAdditional);

            Assert.IsNull(modelState["NationalInsuranceNumber"]);
        }
    }
}
