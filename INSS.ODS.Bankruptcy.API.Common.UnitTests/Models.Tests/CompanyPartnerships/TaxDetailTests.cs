using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using FluentValidation.TestHelper;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
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

            validator.ShouldNotHaveValidationErrorFor(x => x.UTR, taxDetail);

        }

    }
}
