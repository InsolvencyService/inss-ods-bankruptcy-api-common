using System.Linq;
using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Debt;
using INSS.ODS.Bankruptcy.API.Common.Resources.Debt;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Debt
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class PreferredCreditorRelationshipTest
    {
        private PreferredCreditorRelationshipInterfaceValidator _validator;

        [TestInitialize]
        public void Setup()
        {
            _validator = new PreferredCreditorRelationshipInterfaceValidator();
        }

        [TestMethod]
        [TestCategory("PreferredCreditorRelationship")]
        public void PreferredCreditorRelationship_MissingFields()
        {
            var model = new PreferredCreditorRelationship();

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(model);

            Assert.IsFalse(modelState.IsValid);

            // Required fields
            Assert.IsTrue(modelState["RelationshipToYou"].Errors.Any(x => x.ErrorMessage == PreferredCreditorRelationshipResources.Debt_PreferredCreditorRelationship_Relationship_Error_Required));
        }

        [TestMethod]
        [TestCategory("PreferredCreditorRelationship")]
        public void PreferredCreditorRelationship_InvalidData_TooLong()
        {
            var model = new PreferredCreditorRelationship()
            {
                RelationshipToYou = "Other",
                RelationshipToYouOther = "ABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJA"
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(model);

            Assert.IsFalse(modelState.IsValid);

            // Required fields
            Assert.IsTrue(modelState["RelationshipToYou"].Errors.Any(x => x.ErrorMessage == PreferredCreditorRelationshipResources.Debt_PreferredCreditorRelationship_RelationshipOther_Error_TooLong));
        }

        [TestMethod]
        [TestCategory("PreferredCreditorRelationship")]
        public void PreferredCreditorRelationship_InvalidData_TooShort()
        {
            var model = new PreferredCreditorRelationship()
            {
                RelationshipToYou = "Other",
                RelationshipToYouOther = "A"
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(model);

            Assert.IsFalse(modelState.IsValid);

            // Required fields
            Assert.IsTrue(modelState["RelationshipToYou"].Errors.Any(x => x.ErrorMessage == PreferredCreditorRelationshipResources.Debt_PreferredCreditorRelationship_RelationshipOther_Error_TooShort));
        }

        [TestMethod]
        [TestCategory("PreferredCreditorRelationship")]
        public void PreferredCreditorRelationship_ShouldPassOn_ValidValues()
        {
            var model = new PreferredCreditorRelationship()
            {
                RelationshipToYou = PreferredCreditorRelationshipResources.Debt_PreferredCreditorRelationship_Relationship_Employee_Label
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(model);

            Assert.IsTrue(modelState.IsValid);
        }
    }
}
