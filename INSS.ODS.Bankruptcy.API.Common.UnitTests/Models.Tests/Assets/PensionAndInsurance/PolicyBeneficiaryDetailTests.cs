using System;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using INSS.ODS.Bankruptcy.API.Common.Resources.PensionAndInsurance;
using INSS.ODS.Bankruptcy.API.Common.Resources.Shared;
using INSS.ODS.Bankruptcy.API.Common.Models.Constants;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Creditors
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class PolicyBeneficiaryDetailTests
    {
        [TestMethod]
        public void Test_PolicyBeneficiaryDetailTests_EmptyData()
        {
            var payload = new PolicyBeneficiaryDetail();

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(payload);
            Assert.IsFalse(modelState.IsValid);
            Assert.IsTrue(modelState["FirstName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_FirstName_Error_Empty));
            Assert.IsTrue(modelState["LastName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_LastName_Error_Empty));
            Assert.IsTrue(modelState["Relationship"].Errors.Any(x => x.ErrorMessage == PolicyBeneficiaryDetailResources.PensionAndInsurance_PolicyBeneficiaryDetail_Relationship_Error_Empty));
        }

        [TestMethod]
        public void Test_PolicyBeneficiaryDetailTests_InvalidData1()
        {
            var PolicyIncome = new PolicyBeneficiaryDetail()
            {
                FirstName = "J0hn",
                LastName = "B@gley",
                Relationship = "Other",
                RelationshipOther = ""
            };

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(PolicyIncome);
            Assert.IsFalse(modelState.IsValid);
            Assert.IsTrue(modelState["FirstName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_FirstName_Error_InvalidLetters));
            Assert.IsTrue(modelState["LastName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_LastName_Error_InvalidLetters));
            Assert.IsTrue(modelState["Relationship"].Errors.Any(x => x.ErrorMessage == PolicyBeneficiaryDetailResources.PensionAndInsurance_PolicyBeneficiaryDetail_RelationshipOther_Error_Empty));
        }

        [TestMethod]
        public void Test_PolicyBeneficiaryDetailTests_InvalidData2()
        {
            var payload = new PolicyBeneficiaryDetail()
            {
                FirstName = "AbcdefghijklmnopqrstuvwxyzAbcdefghijklmnopqrstuvwxyzAbcdefghijklmnopqrs",
                LastName = "AbcdefghijklmnopqrstuvwxyzAbcdefghij",
                Relationship = "Other",
                RelationshipOther = "NA"
            };

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(payload);
            Assert.IsFalse(modelState.IsValid);
            Assert.IsTrue(modelState["FirstName"].Errors.Any(x => x.ErrorMessage == String.Format(NameResources.Shared_Name_FirstName_Error_MaxLength, NameValidationConstants.FirstName_MaxSize + 1)));
            Assert.IsTrue(modelState["LastName"].Errors.Any(x => x.ErrorMessage == String.Format(NameResources.Shared_Name_LastName_Error_MaxLength, NameValidationConstants.LastName_MaxSize + 1)));
            Assert.IsTrue(modelState["Relationship"].Errors.Any(x => x.ErrorMessage == PolicyBeneficiaryDetailResources.PensionAndInsurance_PolicyBeneficiaryDetail_RelationshipOther_Error_InvalidLength));
        }

        [TestMethod]
        public void Test_PolicyBeneficiaryDetailTests_ValidData1()
        {
            var payload = new PolicyBeneficiaryDetail()
            {
                FirstName = "John",
                LastName = "Bagley",
                Relationship = "Other",
                RelationshipOther = "Grandson"
            };

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(payload);
            Assert.IsTrue(modelState.IsValid);
        }

        [TestMethod]
        public void Test_PolicyBeneficiaryDetailTests_ValidData2()
        {
            var payload = new PolicyBeneficiaryDetail()
            {
                FirstName = "John",
                LastName = "Bagley",
                Relationship = "Child",
                RelationshipOther = ""
            };

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(payload);
            Assert.IsTrue(modelState.IsValid);
        }
    }
}
