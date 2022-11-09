using INSS.ODS.Bankruptcy.API.Common.Models.Vehicle;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Vehicle
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class VehicleTests
    {       
        [TestMethod]
        public void VehicleDetailsValidModelTest()
        {
            //Arrange
            var vehicle = new VehicleDetails
            {
                Make = "BMW",
                Model = "5 Series",
                RegistrationNumber = "bk62uzl",
                VehicleType = "Van",
                NatureOfInterestInVehicle = "Sold"
            };            

            //Action
            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(vehicle);

            //Assert
            Assert.IsTrue(modelState.IsValid);
        }

        [TestMethod]
        public void VehicleDetailsNotValidModelTest()
        {
            //Arrange
            var vehicle = new VehicleDetails
            {   
                RegistrationNumber = "",
                VehicleType = "Van",
                NatureOfInterestInVehicle = "Sold"
            };

            //Action
            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(vehicle);

            //Assert
            Assert.IsFalse(modelState.IsValid);
        }
    }
}
