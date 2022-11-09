using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using INSS.ODS.Bankruptcy.API.Common.Models;
using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
    [TestClass]
    public class SelEmployedEmployeeMoneyOwedTests
    {
        private SelfEmployedEmployeeMoneyOwedValidator validator;

        [TestInitialize]
        public void Setup()
        {
            validator = new SelfEmployedEmployeeMoneyOwedValidator();
        }

        [TestMethod]
        [TestCategory("Self Employed Employee Money Owed")]
        public void SelfEmployedEmployeeMoneyOwedValidModel()
        {
            var selfEmployedEmployeeMoneyOwed = new SelfEmployedEmployeeMoneyOwed();

            selfEmployedEmployeeMoneyOwed.Amount = 1;
            selfEmployedEmployeeMoneyOwed.Reason = "Test";

            validator.ShouldNotHaveValidationErrorFor(x => x.Amount, selfEmployedEmployeeMoneyOwed);
            validator.ShouldNotHaveValidationErrorFor(x => x.Reason, selfEmployedEmployeeMoneyOwed);

        }

        [TestMethod]
        [TestCategory("Self Employed Employee Money Owed")]
        public void SelfEmployedEmployeeMoneyOwedInValidModel()
        {
            var selfEmployedEmployeeMoneyOwed = new SelfEmployedEmployeeMoneyOwed();

            selfEmployedEmployeeMoneyOwed.Amount = -1;
            selfEmployedEmployeeMoneyOwed.Reason = "";

            validator.ShouldHaveValidationErrorFor(x => x.Amount, selfEmployedEmployeeMoneyOwed);
            validator.ShouldHaveValidationErrorFor(x => x.Reason, selfEmployedEmployeeMoneyOwed);

            var context = new ValidationContext(selfEmployedEmployeeMoneyOwed, null, null);
                var results = new List<ValidationResult>();
                var isModelStateValid = Validator.TryValidateObject(selfEmployedEmployeeMoneyOwed, context, results, true);

                Assert.IsTrue(isModelStateValid);


        }

       
    }
}
