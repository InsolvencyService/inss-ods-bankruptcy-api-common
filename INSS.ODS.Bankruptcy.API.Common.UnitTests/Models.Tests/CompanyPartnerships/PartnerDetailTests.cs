using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyPartnerships;
using System.ComponentModel.DataAnnotations;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests;

[TestClass]
public class PartnerDetailTests
{
    private PartnerDetailValidator validator;

    [TestInitialize]
    public void Setup()
    {
        validator = new PartnerDetailValidator();
    }

    [TestMethod]
    [TestCategory("Partners Details")]
    public void PartnerDetailValidModel()
    {
        var partnerDetail = new PartnerDetail();

        partnerDetail.FirstName = "SIMON";
        partnerDetail.LastName = "TEST";

        partnerDetail.PartnerAddress = new Address()
        {
            Address_1 = "A",
            Address_2 = "B",
            Address_3 = "C",
            County = "D",
            TownCity = "E",
            PostCode = "F",
            Country = "UK"
        };

        var validationResult = validator.TestValidate(partnerDetail);

        validationResult.ShouldNotHaveValidationErrorFor(x => x.FirstName);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.LastName);
    }

    [TestMethod]
    [TestCategory("Partners Details")]
    public void PartnerDetailInValidModel()
    {
        var partnerDetail = new PartnerDetail();

        partnerDetail.FirstName = "";
        partnerDetail.LastName = "";

        partnerDetail.PartnerAddress = new Address()
        {
            Address_1 = "A",
            Address_2 = "B",
            Address_3 = "C",
            County = "D",
            TownCity = "E",
            PostCode = "F",
            Country = "UK"
        };

        var validationResult = validator.TestValidate(partnerDetail);

        validationResult.ShouldHaveValidationErrorFor(x => x.FirstName);
        validationResult.ShouldHaveValidationErrorFor(x => x.LastName);

        var context = new ValidationContext(partnerDetail, null, null);
        var results = new List<ValidationResult>();
        var isModelStateValid = Validator.TryValidateObject(partnerDetail, context, results, true);

        Assert.IsTrue(isModelStateValid);
    }
}
