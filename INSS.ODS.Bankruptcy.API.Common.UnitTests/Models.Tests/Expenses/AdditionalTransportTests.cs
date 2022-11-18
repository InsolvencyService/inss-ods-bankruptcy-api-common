using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentValidation.TestHelper;
using FluentAssertions;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models;
using System.ComponentModel.DataAnnotations;

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

            var validationResult = additionalTransportValidator.TestValidate(additionalTransport);

            validationResult.ShouldNotHaveValidationErrorFor(x => x.Additional_Transport_Text);
            validationResult.ShouldNotHaveValidationErrorFor(x => x.Additional_Transport_Value);
           
        }

        [TestMethod]
        [TestCategory("Additional Transportation Expenses")]
        public void AdditionalTransportInValidModel()
        {
            var additionalTransport = new AdditionalTransport();
            additionalTransport.Additional_Transport_Text = "TEST";
            additionalTransport.Additional_Transport_Value = -1;

            var validationResult = additionalTransportValidator.TestValidate(additionalTransport);

            validationResult.ShouldHaveValidationErrorFor(x => x.Additional_Transport_Value);

            validationResult.IsValid.Should().BeFalse();
            validationResult.Errors.Count.Should().Be(1);
          }

    }
}
