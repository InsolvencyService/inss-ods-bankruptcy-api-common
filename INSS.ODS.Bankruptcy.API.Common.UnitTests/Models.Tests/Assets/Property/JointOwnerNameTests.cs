using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Resources.Property;
using INSS.ODS.Bankruptcy.API.Common.Resources.Shared;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class JointOwnerNameTests
    {
        [TestMethod]
        [TestCategory("PropertyDetailsModelTests")]
        public void JointOwnerDetailsValidModel()
        {
            var jointOwner = new PropertyJointOwnerDetails
            {
                FirstName = "John",
                LastName = "Henry",
                Relationship = "Child"
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(jointOwner);

            Assert.IsTrue(modelState.IsValid);
        }

        [TestMethod]
        [TestCategory("PropertyDetailsModelTests")]
        public void JointOwnerDetailsInValidModel()
        {
            var jointOwner = new PropertyJointOwnerDetails
            {
                FirstName = "",
                LastName = "",
                Relationship = "Other",
                OtherRelationship = "A"
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(jointOwner);

            Assert.IsFalse(modelState.IsValid);
            Assert.IsTrue(modelState["FirstName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_FirstName_Error_Empty));
            Assert.IsTrue(modelState["LastName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_LastName_Error_Empty));
            Assert.IsTrue(modelState["Relationship"].Errors.Any(x => x.ErrorMessage == JointOwnerDetailsResources.Property_JointOwnerDetails_RelationshipOther_Error_Length));
        }

        [TestMethod]
        [TestCategory("PropertyDetailsModelTests")]
        public void JointOwnerDetailsInValidModelTest2()
        {
            var jointOwner = new PropertyJointOwnerDetails
            {                
                FirstName = "",
                LastName = "%%",
                Relationship = "Other",
                OtherRelationship = ""                
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(jointOwner);

            Assert.IsFalse(modelState.IsValid);
            Assert.IsTrue(modelState["FirstName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_FirstName_Error_Empty));
            Assert.IsTrue(modelState["LastName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_LastName_Error_InvalidLetters));
            Assert.IsTrue(modelState["Relationship"].Errors.Any(x => x.ErrorMessage == JointOwnerDetailsResources.Property_JointOwnerDetails_RelationshipOther_Error_Mandatory));
        }


    }
}