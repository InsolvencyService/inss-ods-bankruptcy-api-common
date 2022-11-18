using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests;

[TestClass]
public class PARVDetailTests
{
    private PARVDetailValidator validator;

    [TestInitialize]
    public void Setup()
    {
        validator = new PARVDetailValidator();
    }

    [TestMethod]
    [TestCategory("PARV Detail")]
    public void PARVDetailValidModel()
    {
        var parvDetail = new PARVDetail();

        parvDetail.CourtName="AA";
        parvDetail.ApprovedDate = DateTime.Now.AddDays(-1);

        var result = validator.TestValidate(parvDetail);

        result.ShouldNotHaveValidationErrorFor(x => x.CourtName);
        result.ShouldNotHaveValidationErrorFor(x => x.CourtName);
    }

    [TestMethod]
    [TestCategory("PARV Detail")]
    public void PARVDetailInValidModel()
    {
        var parvDetail = new PARVDetail();

        parvDetail.CourtName = "";
        parvDetail.ApprovedDate = DateTime.Now.AddDays(+1);

        var result = validator.TestValidate(parvDetail);

        result.ShouldHaveValidationErrorFor(x => x.CourtName);
        result.ShouldHaveValidationErrorFor(x => x.ApprovedDate);
    }
}