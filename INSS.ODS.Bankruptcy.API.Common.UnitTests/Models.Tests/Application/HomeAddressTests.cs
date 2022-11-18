using INSS.ODS.API.Common.Utilities.TestHelpers;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using INSS.ODS.Bankruptcy.API.Common.Resources.Shared;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests;

[TestClass]
[Ignore(TestConstants.ReasonForIgnoringUnitTests)]
public class HomeAddressTests
{
    private HomeAddressValidator validator;

    [TestInitialize]
    public void Setup()
    {
        validator = new HomeAddressValidator();
    }

    [TestMethod]
    [TestCategory("Home Address")]
    public void HomeAddressValidModel()
    {
        var homeAddress = new HomeAddress()
        {
            HomeRegistrationAddress = new Address
            {
                Address_1 = "Add1",
                Address_2 = "Add2",
                Address_3 = "Add3",
                TownCity = "TC",
                County = "C",
                PostCode = "B32 1RD",
                Country = "UK"
            }
        };

        var mockController = new MockTestController();

        var modelState = mockController.TryFullModelValidation(homeAddress);

        Assert.IsTrue(modelState.IsValid);
    }

    [TestMethod]
    [TestCategory("Home Address")]
    public void HomeAddressInValidModel()
    {
        var homeAddress = new HomeAddress()
        {
            HomeRegistrationAddress = new Address
            {

                Address_2 = "Add2",
                Address_3 = "Add3",
                TownCity = "TC",
                County = "C"
            }
        };


        var mockController = new MockTestController();

        var modelState = mockController.TryFullModelValidation(homeAddress);
       
        Assert.IsFalse(modelState.IsValid);

        Assert.IsTrue(modelState["HomeRegistrationAddress.Address_1"].Errors.Any(x => x.ErrorMessage == AddressResources.Shared_Address_OtherAddress_Address_1_Error_Empty));
        Assert.IsTrue(modelState["HomeRegistrationAddress.PostCode"].Errors.Any(x => x.ErrorMessage == AddressResources.Shared_Address_OtherAddress_PostCode_Error_Empty));
        Assert.IsTrue(modelState["HomeRegistrationAddress.Country"].Errors.Any(x => x.ErrorMessage == AddressResources.Shared_Address_OtherAddress_Country_Error_Empty));
    }



}
