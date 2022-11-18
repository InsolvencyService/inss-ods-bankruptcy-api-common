using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using System.ComponentModel.DataAnnotations;


namespace INSS.ODS.Bankruptcy.API.Common.UnitTests;

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

        var validationResult = validator.TestValidate(selfEmployedAdditionalBusinessDetail);

        //validationResult.IsValid.Should().BeTrue();
        //validationResult.Errors.Count.Should().Be(0);

        validationResult.ShouldNotHaveValidationErrorFor(x => x.VATNumber);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.UTR);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.RecordsLocation);
    }

    [TestMethod]
    [TestCategory("Self Employed Additional Business Detail")]
    public void SelfEmployedAdditionalBusinessDetailInValidModel()
    {
        var selfEmployedAdditionalBusinessDetail = new SelfEmployedAdditionalBusinessDetail();

        selfEmployedAdditionalBusinessDetail.VATNumber = "AAAAAAAAAAAAAAAAAAAAAAAA";
        selfEmployedAdditionalBusinessDetail.UTR = "";
        selfEmployedAdditionalBusinessDetail.RecordsLocation = null;

        var validationResult = validator.TestValidate(selfEmployedAdditionalBusinessDetail);

        validationResult.ShouldHaveValidationErrorFor(x => x.VATNumber);
        validationResult.ShouldHaveValidationErrorFor(x => x.UTR);
        validationResult.ShouldHaveValidationErrorFor(x => x.RecordsLocation);
    }
}
