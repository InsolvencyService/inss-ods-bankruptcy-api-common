using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using INSS.ODS.Bankruptcy.API.Common.Resources.Personal;
using INSS.ODS.Bankruptcy.API.Common.Resources.Shared;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class LandlordOrAgentDetailsTests
    {
        [TestMethod]
        [TestCategory("Model_Tests_LandlordOrAgentDetails")]
        public void LandlordOrAgentDetails_ValidModel()
        {
            var landlordDetails = new LandlordOrAgentDetails()
            {
                Id = 1,
                Name = "Mr. Landlord",
                Address = new Address()
                {
                    Address_1 = "Some Building",
                    Address_2 = "Some Street",
                    TownCity = "Some Town",
                    County = "Some County",
                    PostCode = "SO3 8LD",
                    Country = "UK"
                }
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(landlordDetails);

            Assert.IsTrue(modelState.IsValid);
        }
        [TestMethod]
        [TestCategory("Model_Tests_LandlordOrAgentDetails")]
        public void LandlordOrAgentDetails_InvalidModel()
        {
            var landlordDetails = new LandlordOrAgentDetails()
            {
                //Just create empty address for mock validation
                Address = new Address()
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(landlordDetails);

            Assert.IsFalse(modelState.IsValid);

            Assert.IsTrue(modelState["Name"].Errors.Any(x => x.ErrorMessage == LandlordDetailsResources.Personal_LandlordDetails_Name_Error_Empty));
            Assert.IsTrue(modelState["Address.Address_1"].Errors.Any(x => x.ErrorMessage == AddressResources.Shared_Address_OtherAddress_Address_1_Error_Empty));
            Assert.IsTrue(modelState["Address.PostCode"].Errors.Any(x => x.ErrorMessage == AddressResources.Shared_Address_OtherAddress_PostCode_Error_Empty));
            Assert.IsTrue(modelState["Address.Country"].Errors.Any(x => x.ErrorMessage == AddressResources.Shared_Address_OtherAddress_Country_Error_Empty));
        }
    }
}
