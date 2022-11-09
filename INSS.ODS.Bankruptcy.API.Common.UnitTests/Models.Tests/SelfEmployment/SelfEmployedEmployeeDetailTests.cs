using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
    [TestClass]
    public class SelEmployedEmployeeDetailTests
    {
        private SelfEmployedEmployeeDetailValidator validator;

        [TestInitialize]
        public void Setup()
        {
            validator = new SelfEmployedEmployeeDetailValidator();
        }

        [TestMethod]
        [TestCategory("Self Employed Employee Detail")]
        public void SelfEmployedEmployeeDetailValidModel()
        {
            var selfEmployedEmployeesDetail = new EmployeeDetail();

            selfEmployedEmployeesDetail.FirstName = "SIMON";
            selfEmployedEmployeesDetail.LastName = "TEST";
            selfEmployedEmployeesDetail.MoneyOwed = true;
            selfEmployedEmployeesDetail.EmployeeAddress = new Address()
            {
                Address_1 = "A",
                Address_2 = "B",
                Address_3 = "C",
                County = "D",
                TownCity = "E",
                PostCode = "F",
                Country = "UK"
            };

            validator.ShouldNotHaveValidationErrorFor(x => x.FirstName, selfEmployedEmployeesDetail);
            validator.ShouldNotHaveValidationErrorFor(x => x.LastName, selfEmployedEmployeesDetail);
            validator.ShouldNotHaveValidationErrorFor(x => x.MoneyOwed, selfEmployedEmployeesDetail);

        }

        [TestMethod]
        [TestCategory("Self Employed Employee Detail")]
        public void SelfEmployedEmployeeDetailInValidModel()
        {
            var selfEmployedEmployeesDetail = new EmployeeDetail();

            selfEmployedEmployeesDetail.FirstName = "";
            selfEmployedEmployeesDetail.LastName = "";
            selfEmployedEmployeesDetail.EmployeeAddress = new Address()
            {
                Address_1 = "",
                Address_2 = "B",
                Address_3 = "C",
                County = "D",
                TownCity = "E",
                PostCode = ""
            };

            validator.ShouldHaveValidationErrorFor(x => x.FirstName, selfEmployedEmployeesDetail);
            validator.ShouldHaveValidationErrorFor(x => x.LastName, selfEmployedEmployeesDetail);
            validator.ShouldHaveValidationErrorFor(x => x.MoneyOwed, selfEmployedEmployeesDetail);

            var context = new ValidationContext(selfEmployedEmployeesDetail, null, null);
                var results = new List<ValidationResult>();
                var isModelStateValid = Validator.TryValidateObject(selfEmployedEmployeesDetail, context, results, true);

                Assert.IsTrue(isModelStateValid);


        }

       
    }
}
