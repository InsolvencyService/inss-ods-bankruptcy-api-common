using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.Models;
using System.Linq;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using INSS.ODS.Bankruptcy.API.Common.Resources.Shared;
using INSS.ODS.Bankruptcy.API.Common.Models.Constants;
using INSS.ODS.Bankruptcy.API.Common.Resources.Personal;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class HouseholdMemberTests
    {
        [TestMethod]
        [TestCategory("Model HouseholdMember")]
        public void HouseholdMemberValidModel()
        {
            var HouseholdMember = new HouseholdMember()
            {
                AgeGroup = "19-23",
                FinanciallyDependentOption = "No",
                FinanciallyDependent = false,
                FirstName = "Zakk",
                LastName = "Wylde",
                Relationship = "Child"
            };
          
            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(HouseholdMember);

            Assert.IsTrue(modelState.IsValid);
        }

        [TestMethod]
        [TestCategory("Model HouseholdMember")]
        public void HouseholdMemberEmptyModel()
        {
            var HouseholdMember = new HouseholdMember();
          
            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(HouseholdMember);

            Assert.IsFalse(modelState.IsValid);

            Assert.IsTrue(modelState["FirstName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_FirstName_Error_Empty));
            Assert.IsTrue(modelState["LastName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_LastName_Error_Empty));
            Assert.IsTrue(modelState["AgeGroup"].Errors.Any(x => x.ErrorMessage == AddHouseholdMemberResources.Personal_AddHouseholdMember_Age_Error_Empty));
            Assert.IsTrue(modelState["Relationship"].Errors.Any(x => x.ErrorMessage == AddHouseholdMemberResources.Personal_AddHouseholdMember_Relationship_Error_Empty));
       }

        [TestMethod]
        [TestCategory("Model HouseholdMember")]
        public void HouseholdMemberInvalidModelEmptyNameErrors()
        {
            var HouseholdMember = new HouseholdMember()
            {
                FirstName = "",
                LastName = "",
                Relationship = "Child",
                AgeGroup = "19-23",
                FinanciallyDependent = false
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(HouseholdMember);

            Assert.IsFalse(modelState.IsValid);

            Assert.IsTrue(modelState["FirstName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_FirstName_Error_Empty));
            Assert.IsTrue(modelState["LastName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_LastName_Error_Empty));
        }

        [TestMethod]
        [TestCategory("Model HouseholdMember")]
        public void HouseholdMemberInvalidModelMaxLengthErrors()
        {
            var HouseholdMember = new HouseholdMember()
            {
                FirstName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRS", //71 chars - only 70 allowed
                LastName = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRS", //71 chars - only 70 allowed
                Relationship = "Child",
                AgeGroup = "19-23",
                FinanciallyDependent = false
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(HouseholdMember);

            Assert.IsFalse(modelState.IsValid);

            Assert.IsTrue(modelState["FirstName"].Errors.Any(x => x.ErrorMessage == String.Format(NameResources.Shared_Name_FirstName_Error_MaxLength, NameValidationConstants.FirstName_MaxSize + 1)));
            Assert.IsTrue(modelState["LastName"].Errors.Any(x => x.ErrorMessage == String.Format(NameResources.Shared_Name_LastName_Error_MaxLength, NameValidationConstants.LastName_MaxSize + 1)));
        }
    }
}
