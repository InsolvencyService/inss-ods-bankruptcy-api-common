using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships;
using System.ComponentModel.DataAnnotations;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests;

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

        var validationResult = validator.TestValidate(selfEmployedEmployeesDetail);

        validationResult.ShouldNotHaveValidationErrorFor(x => x.FirstName);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.LastName);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.MoneyOwed);
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

        var validationResult = validator.TestValidate(selfEmployedEmployeesDetail);

        validationResult.ShouldHaveValidationErrorFor(x => x.FirstName);
        validationResult.ShouldHaveValidationErrorFor(x => x.LastName);
        validationResult.ShouldHaveValidationErrorFor(x => x.MoneyOwed);

        var context = new ValidationContext(selfEmployedEmployeesDetail, null, null);
            var results = new List<ValidationResult>();
            var isModelStateValid = Validator.TryValidateObject(selfEmployedEmployeesDetail, context, results, true);

            Assert.IsTrue(isModelStateValid);
    }
}
