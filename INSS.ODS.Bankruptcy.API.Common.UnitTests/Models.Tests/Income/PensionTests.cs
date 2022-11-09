using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using INSS.ODS.Bankruptcy.API.Common.Models;
using System.Linq;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using FluentValidation;
using FluentValidation.TestHelper;
using FluentAssertions;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Income
{
    [TestClass]
    public class PensionTests
    {
        private PensionValidator validator;

        [TestInitialize]
        public void Setup()
        {
            validator = new PensionValidator();
        }

        [TestMethod]
        public void PensionValidModel()
        {
            var pension = new Pension();

            pension.PensionCredit = 1000;
            pension.State = 1000;

            validator.ShouldNotHaveValidationErrorFor(x => x.PensionCredit, pension);
            validator.ShouldNotHaveValidationErrorFor(x => x.State, pension);
          
        }

        [TestMethod]
        public void PensionInValidModel()
        {
            var pension = new Pension();

            pension.PensionCredit = -1;
            pension.State = -1;

            validator.ShouldHaveValidationErrorFor(x => x.PensionCredit, pension);
            validator.ShouldHaveValidationErrorFor(x => x.State, pension);

            var validationResult = validator.Validate(pension);

            validationResult.IsValid.Should().BeFalse();
            validationResult.Errors.Count.Should().Be(2);
        }

        [TestMethod]
        public void PensionTotallingTest()
        {
            var pension = new Pension();
            Assert.IsTrue(pension.IsNotStarted);

            pension.State = 100;
            pension.State_Frequency = "per week";
            pension.PensionCredit = 100;
            pension.PensionCredit_Frequency = "per week";

            pension.OtherPensions = new List<OtherPension>
            {
                new OtherPension
                {
                    Value = 100,
                    Frequency = "per week"
                }
            };

            Assert.IsFalse(pension.IsNotStarted);
            Assert.AreEqual(1299.99m, pension.Total);
        }
    }
}
