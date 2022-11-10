using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentValidation.TestHelper;
using FluentAssertions;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
    [TestClass]
    public class AdditionalTransportTests
    {
        private AdditionalTransportValidator additionalTransportValidator;

        [TestInitialize]
        public void Setup()
        {
            additionalTransportValidator = new AdditionalTransportValidator();
        }

        [TestMethod]
        [TestCategory("Additional Transportation Expenses")]
        public void AdditionalTransportValidModel()
        {
            var additionalTransport = new AdditionalTransport();

            additionalTransport.Additional_Transport_Text = "TEST";
            additionalTransport.Additional_Transport_Value = 12.12m;
            additionalTransport.Additional_Transport_Frequency = "Yearly";

            additionalTransportValidator.ShouldNotHaveValidationErrorFor(x => x.Additional_Transport_Text, additionalTransport);
            additionalTransportValidator.ShouldNotHaveValidationErrorFor(x => x.Additional_Transport_Value, additionalTransport);
           
        }

        [TestMethod]
        [TestCategory("Additional Transportation Expenses")]
        public void AdditionalTransportInValidModel()
        {
            var additionalTransport = new AdditionalTransport();
            additionalTransport.Additional_Transport_Text = "TEST";
            additionalTransport.Additional_Transport_Value = -1;

            additionalTransportValidator.ShouldHaveValidationErrorFor(x => x.Additional_Transport_Value, additionalTransport);

            var validationResult = additionalTransportValidator.Validate(additionalTransport);

            validationResult.IsValid.Should().BeFalse();
            validationResult.Errors.Count.Should().Be(1);
          }

    }
}
