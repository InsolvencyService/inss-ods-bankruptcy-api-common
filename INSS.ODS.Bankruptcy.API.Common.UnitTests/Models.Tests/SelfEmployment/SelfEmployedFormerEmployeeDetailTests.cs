using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships;
using System.ComponentModel.DataAnnotations;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests;

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

        var validationResult = validator.TestValidate(selfEmployedFormerEmployeeDetail);

        validationResult.ShouldNotHaveValidationErrorFor(x => x.FirstName);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.LastName);
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

        var validationResult = validator.TestValidate(selfEmployedFormerEmployeeDetail);

        validationResult.ShouldHaveValidationErrorFor(x => x.FirstName);
        validationResult.ShouldHaveValidationErrorFor(x => x.LastName);

        var context = new ValidationContext(selfEmployedFormerEmployeeDetail, null, null);
            var results = new List<ValidationResult>();
            var isModelStateValid = Validator.TryValidateObject(selfEmployedFormerEmployeeDetail, context, results, true);

            Assert.IsTrue(isModelStateValid);
    }
}
