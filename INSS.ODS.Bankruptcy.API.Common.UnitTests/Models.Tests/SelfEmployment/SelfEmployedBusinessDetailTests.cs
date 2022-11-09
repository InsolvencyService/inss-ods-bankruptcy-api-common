using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using INSS.ODS.Bankruptcy.API.Common.Models;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
    [TestClass]
    public class SelEmployedBusinessDetailTests
    {
        private SelfEmployedBusinessDetailValidator validator;

        [TestInitialize]
        public void Setup()
        {
            validator = new SelfEmployedBusinessDetailValidator();
        }

        [TestMethod]
        [TestCategory("Self Employed Business Detail")]
        public void SelfEmployedBusinessDetailNoOtherNamesValidModel()
        {
            var selfEmployedBusinessDetail = new SelfEmployedBusinessDetail();

            selfEmployedBusinessDetail.BusinessName="AA";
            selfEmployedBusinessDetail.BusinessType = "BB";
            selfEmployedBusinessDetail.TradingStartedDate =DateTime.Now.AddDays(-1);

            validator.ShouldNotHaveValidationErrorFor(x => x.BusinessName, selfEmployedBusinessDetail);
            validator.ShouldNotHaveValidationErrorFor(x => x.TradingStartedDate, selfEmployedBusinessDetail);
            validator.ShouldNotHaveValidationErrorFor(x => x.BusinessType, selfEmployedBusinessDetail);

        }

        [TestMethod]
        [TestCategory("Self Employed Business Detail")]
        public void SelfEmployedBusinessDetailWithOtherNamesValidModel()
        {
            var selfEmployedBusinessDetail = new SelfEmployedBusinessDetail();
            List<SelfEmployedBusinessName>  businessNamesList = new List<SelfEmployedBusinessName>();


            selfEmployedBusinessDetail.BusinessName = "AA";
            selfEmployedBusinessDetail.BusinessType = "BB";
            selfEmployedBusinessDetail.TradingStartedDate = DateTime.Now.AddDays(-1);

            var businessName = new SelfEmployedBusinessName();
            businessName.BusinessName = "Test";

            businessNamesList.Add(businessName);

            selfEmployedBusinessDetail.BusinessNames = businessNamesList;

            validator.ShouldNotHaveValidationErrorFor(x => x.BusinessName, selfEmployedBusinessDetail);
            validator.ShouldNotHaveValidationErrorFor(x => x.TradingStartedDate, selfEmployedBusinessDetail);

            var context = new ValidationContext(selfEmployedBusinessDetail, null, null);
            var results = new List<ValidationResult>();
            var isModelStateValid = Validator.TryValidateObject(selfEmployedBusinessDetail, context, results, true);

            Assert.IsTrue(isModelStateValid);
        }

        [TestMethod]
        [TestCategory("Self Employed Business Detail")]
        public void SelfEmployedBusinessDetailNoOtherNamesInValidModel()
        {
            var selfEmployedBusinessDetail = new SelfEmployedBusinessDetail();

            selfEmployedBusinessDetail.BusinessName = "AA";
            selfEmployedBusinessDetail.TradingStartedDate = DateTime.Now.AddDays(-1);

            validator.ShouldHaveValidationErrorFor(x => x.BusinessType, selfEmployedBusinessDetail);
            validator.ShouldNotHaveValidationErrorFor(x => x.TradingStartedDate, selfEmployedBusinessDetail);
            validator.ShouldNotHaveValidationErrorFor(x => x.BusinessName, selfEmployedBusinessDetail);

        }

        [TestMethod]
        [TestCategory("Self Employed Business Detail")]
        public void SelfEmployedBusinessDetailWithOtherNamesInValidModel()
        {
            var selfEmployedBusinessDetail = new SelfEmployedBusinessDetail();
            List<SelfEmployedBusinessName> businessNamesList = new List<SelfEmployedBusinessName>();


            selfEmployedBusinessDetail.BusinessName = "AA";
            selfEmployedBusinessDetail.BusinessType = "BB";
            selfEmployedBusinessDetail.TradingStartedDate = DateTime.Now.AddDays(-1);

            var businessName = new SelfEmployedBusinessName();

            businessNamesList.Add(businessName);

            selfEmployedBusinessDetail.BusinessNames = businessNamesList;

            validator.ShouldNotHaveValidationErrorFor(x => x.BusinessName, selfEmployedBusinessDetail);
            validator.ShouldNotHaveValidationErrorFor(x => x.TradingStartedDate, selfEmployedBusinessDetail);

            var context = new ValidationContext(selfEmployedBusinessDetail, null, null);
            var results = new List<ValidationResult>();
            var isModelStateValid = Validator.TryValidateObject(selfEmployedBusinessDetail, context, results, true);

            Assert.IsTrue(isModelStateValid);
        }

    }
}
