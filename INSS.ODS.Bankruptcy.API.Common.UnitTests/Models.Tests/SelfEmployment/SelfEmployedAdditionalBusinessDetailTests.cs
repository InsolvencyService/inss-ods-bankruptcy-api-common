using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using FluentValidation.TestHelper;


namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
    [TestClass]
    public class SelEmployedAdditionalBusinessDetailTests
    {
        private SelfEmployedAdditionalBusinessDetailValidator validator;

        [TestInitialize]
        public void Setup()
        {
            validator = new SelfEmployedAdditionalBusinessDetailValidator();
        }

        [TestMethod]
        [TestCategory("Self Employed Additional Business Detail")]
        public void SelfEmployedAdditionalBusinessDetailValidModel()
        {
            var selfEmployedAdditionalBusinessDetail = new SelfEmployedAdditionalBusinessDetail();

            selfEmployedAdditionalBusinessDetail.VATNumber = "GB 551 6778 32";
            //selfEmployedAdditionalBusinessDetail.VATNumber = "GB551677832";
            selfEmployedAdditionalBusinessDetail.UTR="AA";
            selfEmployedAdditionalBusinessDetail.RecordsLocation = "BB";

            var context = new ValidationContext(selfEmployedAdditionalBusinessDetail, null, null);
            var results = new List<ValidationResult>();
            var isModelStateValid = Validator.TryValidateObject(selfEmployedAdditionalBusinessDetail, context, results, true);

            Assert.IsTrue(isModelStateValid);

            var validationResult = validator.Validate(selfEmployedAdditionalBusinessDetail);

            //validationResult.IsValid.Should().BeTrue();
            //validationResult.Errors.Count.Should().Be(0);

            validator.ShouldNotHaveValidationErrorFor(x => x.VATNumber, selfEmployedAdditionalBusinessDetail);
            validator.ShouldNotHaveValidationErrorFor(x => x.UTR, selfEmployedAdditionalBusinessDetail);
            validator.ShouldNotHaveValidationErrorFor(x => x.RecordsLocation, selfEmployedAdditionalBusinessDetail);
 
        }

        [TestMethod]
        [TestCategory("Self Employed Additional Business Detail")]
        public void SelfEmployedAdditionalBusinessDetailInValidModel()
        {
            var selfEmployedAdditionalBusinessDetail = new SelfEmployedAdditionalBusinessDetail();

            selfEmployedAdditionalBusinessDetail.VATNumber = "AAAAAAAAAAAAAAAAAAAAAAAA";
            selfEmployedAdditionalBusinessDetail.UTR = "";
            selfEmployedAdditionalBusinessDetail.RecordsLocation = null;

            validator.ShouldHaveValidationErrorFor(x => x.VATNumber, selfEmployedAdditionalBusinessDetail);
            validator.ShouldHaveValidationErrorFor(x => x.UTR, selfEmployedAdditionalBusinessDetail);
            validator.ShouldHaveValidationErrorFor(x => x.RecordsLocation, selfEmployedAdditionalBusinessDetail);

        }

        

    }
}
