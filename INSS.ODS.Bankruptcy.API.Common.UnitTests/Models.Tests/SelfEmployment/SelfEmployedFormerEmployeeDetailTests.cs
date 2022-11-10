using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using INSS.ODS.Bankruptcy.API.Common.Models;
using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
    [TestClass]
    public class SelEmployedFormerEmployeeDetailTests
    {
        private SelfEmployedFormerEmployeeDetailValidator validator;

        [TestInitialize]
        public void Setup()
        {
            validator = new SelfEmployedFormerEmployeeDetailValidator();
        }

        [TestMethod]
        [TestCategory("Self Employed Former Employee Detail")]
        public void SelfEmployedFormerEmployeeDetailValidModel()
        {
            var selfEmployedFormerEmployeeDetail = new FormerEmployeeDetail();

            selfEmployedFormerEmployeeDetail.FirstName = "SIMON";
            selfEmployedFormerEmployeeDetail.LastName = "TEST";
            selfEmployedFormerEmployeeDetail.Reason  = "TEST";
            selfEmployedFormerEmployeeDetail.Amount = 100;
            selfEmployedFormerEmployeeDetail.FormerEmployeeAddress = new Address()
            {
                Address_1 = "A",
                Address_2 = "B",
                Address_3 = "C",
                County = "D",
                TownCity = "E",
                PostCode = "F",
                Country = "UK"
            };

            validator.ShouldNotHaveValidationErrorFor(x => x.FirstName, selfEmployedFormerEmployeeDetail);
            validator.ShouldNotHaveValidationErrorFor(x => x.LastName, selfEmployedFormerEmployeeDetail);


        }

        [TestMethod]
        [TestCategory("Self Employed Former Employee Detail")]
        public void SelfEmployedFormerEmployeeDetailInValidModel()
        {
            var selfEmployedFormerEmployeeDetail = new FormerEmployeeDetail();


            selfEmployedFormerEmployeeDetail.FirstName = "";
            selfEmployedFormerEmployeeDetail.LastName = "";
            selfEmployedFormerEmployeeDetail.Reason = "";
            selfEmployedFormerEmployeeDetail.FormerEmployeeAddress = new Address()
            {
                Address_1 = "",
                Address_2 = "B",
                Address_3 = "C",
                County = "D",
                TownCity = "E",
                PostCode = ""
            };

            validator.ShouldHaveValidationErrorFor(x => x.FirstName, selfEmployedFormerEmployeeDetail);
            validator.ShouldHaveValidationErrorFor(x => x.LastName, selfEmployedFormerEmployeeDetail);


            var context = new ValidationContext(selfEmployedFormerEmployeeDetail, null, null);
                var results = new List<ValidationResult>();
                var isModelStateValid = Validator.TryValidateObject(selfEmployedFormerEmployeeDetail, context, results, true);

                Assert.IsTrue(isModelStateValid);


        }



    }
}
