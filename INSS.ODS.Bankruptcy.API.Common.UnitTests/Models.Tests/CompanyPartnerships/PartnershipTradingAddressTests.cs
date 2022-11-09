using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Resources.Shared;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class PartnershipTradingAddressTests
    {
        private CompanyPartnershipTradingAddressValidator validator;

        [TestInitialize]
        public void Setup()
        {
            validator = new CompanyPartnershipTradingAddressValidator();
        }

        [TestMethod]
        [TestCategory("Company Partnership Trading Address")]
        public void CompanyPartnershipTradingAddressValidModel()
        {
            var partnershipTradingAddress = new PartnershipTradingAddress()
            {
                BusinessAddress = new Address
                {
                    Address_1 = "Add1",
                    Address_2 = "Add2",
                    Address_3 = "Add3",
                    TownCity = "TC",
                    County = "C",
                    PostCode = "B32 1RD",
                    Country = "UK"
                },
                TradingStartedDate = DateTime.Now.AddDays(-1)
            };

            validator.ShouldNotHaveValidationErrorFor(x => x.TradingStartedDate, partnershipTradingAddress);

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(partnershipTradingAddress);

            Assert.IsTrue(modelState.IsValid);
        }

        [TestMethod]
        [TestCategory("Company Partnership Trading Address")]
        public void CompanyPartnershipTradingAddressInValidModel()
        {
            var partnershipTradingAddress = new PartnershipTradingAddress()
            {
                BusinessAddress = new Address
                {
                    Address_2 = "Add2",
                    Address_3 = "Add3",
                    TownCity = "TC",
                    County = "C"
                },
                TradingStartedDate = DateTime.Now.AddDays(-1)
            };


            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(partnershipTradingAddress);
           
            Assert.IsFalse(modelState.IsValid);

            Assert.IsTrue(modelState["BusinessAddress.Address_1"].Errors.Any(x => x.ErrorMessage == AddressResources.Shared_Address_OtherAddress_Address_1_Error_Empty));
            Assert.IsTrue(modelState["BusinessAddress.PostCode"].Errors.Any(x => x.ErrorMessage == AddressResources.Shared_Address_OtherAddress_PostCode_Error_Empty));
            Assert.IsTrue(modelState["BusinessAddress.Country"].Errors.Any(x => x.ErrorMessage == AddressResources.Shared_Address_OtherAddress_Country_Error_Empty));
        }



    }
}
