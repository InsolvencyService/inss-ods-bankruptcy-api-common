using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.CompanyDirectorships;
using System.ComponentModel.DataAnnotations;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests;

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

        var validationResult = validator.TestValidate(selfEmployedAccountantDetail);

        validationResult.ShouldNotHaveValidationErrorFor(x => x.AccountantName);
        validationResult.ShouldNotHaveValidationErrorFor(x => x.DateStarted);

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

        var validationResult = validator.TestValidate(selfEmployedAccountantDetail);

        validationResult.ShouldHaveValidationErrorFor(x => x.AccountantName);
        validationResult.ShouldHaveValidationErrorFor(x => x.DateStarted);

        var context = new ValidationContext(selfEmployedAccountantDetail, null, null);
        var results = new List<ValidationResult>();
        var isModelStateValid = Validator.TryValidateObject(selfEmployedAccountantDetail, context, results, true);

        Assert.IsFalse(isModelStateValid);
    }

}
