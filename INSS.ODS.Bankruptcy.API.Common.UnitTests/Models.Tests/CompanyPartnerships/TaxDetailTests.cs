using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests;

[TestClass]
public class TaxDetailTests
{
    private TaxDetailValidator validator;

    [TestInitialize]
    public void Setup()
    {
        validator = new TaxDetailValidator();
    }

    [TestMethod]
    [TestCategory("Tax Details")]
    public void TaxDetailValidModel()
    {
        var taxDetail = new TaxDetail();

        taxDetail.UTR = "ABCD1234EF";

        var validationResult = validator.TestValidate(taxDetail);

        validationResult.ShouldNotHaveValidationErrorFor(x => x.UTR);
    }
}
