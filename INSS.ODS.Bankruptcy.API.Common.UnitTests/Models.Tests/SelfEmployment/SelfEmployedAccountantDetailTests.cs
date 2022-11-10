using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using INSS.ODS.Bankruptcy.API.Common.Models;
using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
    [TestClass]
    public class SelEmployedAccountantDetailTests
    {
        private SelfEmployedAccountantDetailValidator<Address> validator;

        [TestInitialize]
        public void Setup()
        {
            validator = new SelfEmployedAccountantDetailValidator<Address>();
        }

        [TestMethod]
        [TestCategory("Self Employed Accountant Detail")]
        public void SelfEmployedAccountantDetailValidModel()
        {
            var selfEmployedAccountantDetail = new AccountantDetail()
            {
                AccountantName = "SIMON",
                AccountantAddress = new Address()
                {
                    Address_1 = "A",
                    Address_2 = "B",
                    Address_3 = "C",
                    County = "D",
                    TownCity = "E",
                    PostCode = "F",
                    Country = "UK"
                },
                DateStarted = new DateTime(2000, 1, 1)
            };

            validator.ShouldNotHaveValidationErrorFor(x => x.AccountantName, selfEmployedAccountantDetail);
            validator.ShouldNotHaveValidationErrorFor(x => x.DateStarted, selfEmployedAccountantDetail);

            var context = new ValidationContext(selfEmployedAccountantDetail, null, null);
            var results = new List<ValidationResult>();
            var isModelStateValid = Validator.TryValidateObject(selfEmployedAccountantDetail, context, results, true);

            Assert.IsTrue(isModelStateValid);
        }

        [TestMethod]
        [TestCategory("Self Employed Accountant Detail")]
        public void SelfEmployedAccountantDetailInValidModel()
        {
            var selfEmployedAccountantDetail = new AccountantDetail()
            {
                AccountantName = "",
                AccountantAddress = new Address()
                {
                    Address_1 = "A",
                    Address_2 = "B",
                    Address_3 = "C",
                    County = "D",
                    TownCity = "E",
                    PostCode = "F",
                    Country = "UK"
                },
                DateStarted = default(DateTime)
            };

            validator.ShouldHaveValidationErrorFor(x => x.AccountantName, selfEmployedAccountantDetail);
            validator.ShouldHaveValidationErrorFor(x => x.DateStarted, selfEmployedAccountantDetail);

            var context = new ValidationContext(selfEmployedAccountantDetail, null, null);
            var results = new List<ValidationResult>();
            var isModelStateValid = Validator.TryValidateObject(selfEmployedAccountantDetail, context, results, true);

            Assert.IsFalse(isModelStateValid);
        }
       
    }
}
