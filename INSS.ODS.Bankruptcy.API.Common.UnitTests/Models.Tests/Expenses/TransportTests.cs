using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FluentValidation.TestHelper;
using FluentAssertions;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
    [TestClass]
    public class TransportTests
    {
        private TransportValidator validator;

        [TestInitialize]
        public void Setup()
        {
            validator = new TransportValidator();
        }

        [TestMethod]
        [TestCategory("Transportation Expenses")]
        public void TransportValidModel()
        {
            var transport = new Transport();

            transport.Breakdown_Cover = 12.12m;
            transport.Fuel_Parking_Toll = 13.13m;
            transport.MOT = 14.14m;
            transport.Public_Transport = 15.15m;
            transport.Vehicle_Finance = 16.16m;
            transport.Vehicle_Insurance = 17.17m;
            transport.Vehicle_Tax = 18.18m;

            validator.ShouldNotHaveValidationErrorFor(x => x.Breakdown_Cover, transport);
            validator.ShouldNotHaveValidationErrorFor(x => x.Fuel_Parking_Toll, transport);
            validator.ShouldNotHaveValidationErrorFor(x => x.MOT, transport);
            validator.ShouldNotHaveValidationErrorFor(x => x.Public_Transport, transport);
            validator.ShouldNotHaveValidationErrorFor(x => x.Vehicle_Finance, transport);
            validator.ShouldNotHaveValidationErrorFor(x => x.Vehicle_Insurance, transport);


        }

        [TestMethod]
        [TestCategory("Transportation Expenses")]
        public void TransportInValidModel()
        {
            var transport = new Transport();

            transport.Breakdown_Cover = -1;
            transport.Fuel_Parking_Toll = -1;
            transport.MOT = -1;
            transport.Public_Transport = -1;
            transport.Vehicle_Finance = -1;
            transport.Vehicle_Insurance = -1;
            transport.Vehicle_Tax = -1;

            validator.ShouldHaveValidationErrorFor(x => x.Breakdown_Cover, transport);
            validator.ShouldHaveValidationErrorFor(x => x.Fuel_Parking_Toll, transport);
            validator.ShouldHaveValidationErrorFor(x => x.MOT, transport);
            validator.ShouldHaveValidationErrorFor(x => x.Public_Transport, transport);
            validator.ShouldHaveValidationErrorFor(x => x.Vehicle_Finance, transport);
            validator.ShouldHaveValidationErrorFor(x => x.Vehicle_Insurance, transport);

            var validationResult = validator.Validate(transport);

            validationResult.IsValid.Should().BeFalse();
            validationResult.Errors.Count.Should().Be(7);
        }

        [TestMethod]
        public void TransportTotallingTest()
        {
            var transport = new Transport();

            Assert.IsTrue(transport.IsNotStarted);

            transport.Breakdown_Cover = 100m;
            transport.Breakdown_Cover_Frequency = "per week";
            transport.Fuel_Parking_Toll = 100m;
            transport.Fuel_Parking_Toll_Frequency = "per week";
            transport.MOT = 100m;
            transport.MOT_Frequency = "per week";
            transport.Public_Transport = 100m;
            transport.Public_Transport_Frequency = "per week";
            transport.Vehicle_Finance = 100m;
            transport.Vehicle_Finance_Frequency = "per week";
            transport.Vehicle_Insurance = 100m;
            transport.Vehicle_Insurance_Frequency = "per week";
            transport.Vehicle_Tax = 100m;
            transport.Vehicle_Tax_Frequency = "per week";

            transport.AdditionalTransport = new List<AdditionalTransport>
            {
                new AdditionalTransport
                {
                    Additional_Transport_Value = 100m,
                    Additional_Transport_Frequency = "per week",
                    Additional_Transport_Text = "test"
                }
            };

            Assert.IsFalse(transport.IsNotStarted);
            Assert.AreEqual(3466.64m, transport.Total);
        }

    }
}
