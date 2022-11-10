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
    public class DependantsNotLivingWithYouTests
    {
        [TestMethod]
        [TestCategory("Model DependantsNotLivingWithYou")]
        public void DependantsNotLivingWithYouValidModel()
        {
            var dependant = new DependentsNotLivingWithYou()
            {
                FirstName = "John",
                LastName = "Cooper",
                Age = 56,
                Address = new Address
                {
                    Address_1 = "Some Building",
                    TownCity = "Birmingham",
                    PostCode = "B4 6FD",
                    Country = "UK"
                },
                Relationship = "Parent"   
            };
          
            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(dependant);

            Assert.IsTrue(modelState.IsValid);
        }

        [TestMethod]
        [TestCategory("Model DependantsNotLivingWithYou")]
        public void DependantsNotLivingWithYouEmptyModel()
        {
            var dependant = new DependentsNotLivingWithYou() { Address = new Address()};
          
            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(dependant);

            Assert.IsFalse(modelState.IsValid);

            Assert.IsTrue(modelState["FirstName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_FirstName_Error_Empty));
            Assert.IsTrue(modelState["LastName"].Errors.Any(x => x.ErrorMessage == NameResources.Shared_Name_LastName_Error_Empty));
            Assert.IsTrue(modelState["Age"].Errors.Any(x => x.ErrorMessage == AddDependantResources.Personal_AddDependant_Age_Error_Empty));
            Assert.IsTrue(modelState["Address.Address_1"].Errors.Any(x => x.ErrorMessage == AddressResources.Shared_Address_OtherAddress_Address_1_Error_Empty));
            Assert.IsTrue(modelState["Address.PostCode"].Errors.Any(x => x.ErrorMessage == AddressResources.Shared_Address_OtherAddress_PostCode_Error_Empty));
            Assert.IsTrue(modelState["Address.Country"].Errors.Any(x => x.ErrorMessage == AddressResources.Shared_Address_OtherAddress_Country_Error_Empty));
        }

        [TestMethod]
        [TestCategory("Model DependantsNotLivingWithYou")]
        public void DependantsNotLivingWithYouMaxLengthErrors()
        {
            var dependant= new DependentsNotLivingWithYou()
            {
                FirstName = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwcsadadadadadasdadasdadadadasdadadxyz",
                LastName = "abcdefghijklmnopqrstuvwxyzabcdefghijdccsadadadadadasdadadadadadsa",
                Age  = 12,
                Address = new Address
                {
                    Address_1 = "Some Building",
                    TownCity = "Birmingham",
                    PostCode = "B4 6FD",
                    Country = "UK"
                },
                Relationship = "Child",
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(dependant);

            Assert.IsFalse(modelState.IsValid);

            Assert.IsTrue(modelState["FirstName"].Errors.Any(x => x.ErrorMessage == String.Format(NameResources.Shared_Name_FirstName_Error_MaxLength, NameValidationConstants.FirstName_MaxSize + 1)));
            Assert.IsTrue(modelState["LastName"].Errors.Any(x => x.ErrorMessage == String.Format(NameResources.Shared_Name_LastName_Error_MaxLength, NameValidationConstants.LastName_MaxSize + 1)));
        }

        
    }
}
