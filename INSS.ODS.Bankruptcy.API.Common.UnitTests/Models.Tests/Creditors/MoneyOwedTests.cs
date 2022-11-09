using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentValidation.TestHelper;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Creditors;
using INSS.ODS.Bankruptcy.API.Common.Models.Creditors;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Creditors
{
    [TestClass]
    public class MoneyOwedTests
    {

        private MoneyOwedValidator validator;

        [TestInitialize]
        public void Setup()
        {
            validator = new MoneyOwedValidator();
        }

        [TestMethod]
        public void MoneyOwedInvalid()
        {

            var MoneyOwed = new MoneyOwed
            {

            };

            validator.ShouldHaveValidationErrorFor(x => x.IsMoneyOwed, MoneyOwed);

        }

        [TestMethod]
        public void MoneyOwedValid()
        {
            var MoneyOwed = new MoneyOwed
            {
                IsMoneyOwed = true
            };


            validator.ShouldNotHaveValidationErrorFor(x => x.IsMoneyOwed, MoneyOwed);

            var context = new System.ComponentModel.DataAnnotations.ValidationContext(MoneyOwed, null, null);
            var results = new List<ValidationResult>();
            var isModelStateValid = Validator.TryValidateObject(MoneyOwed, context, results, true);

            Assert.IsTrue(isModelStateValid);
        }



    }
}
