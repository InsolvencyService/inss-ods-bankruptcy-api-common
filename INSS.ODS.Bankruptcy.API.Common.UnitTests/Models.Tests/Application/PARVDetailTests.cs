using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators;
using FluentValidation.TestHelper;


namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
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

            validator.ShouldNotHaveValidationErrorFor(x => x.CourtName, parvDetail);
            validator.ShouldNotHaveValidationErrorFor(x => x.ApprovedDate, parvDetail);

        }

        [TestMethod]
        [TestCategory("PARV Detail")]
        public void PARVDetailInValidModel()
        {
            var parvDetail = new PARVDetail();

            parvDetail.CourtName = "";
            parvDetail.ApprovedDate = DateTime.Now.AddDays(+1);

            validator.ShouldHaveValidationErrorFor(x => x.CourtName, parvDetail);
            validator.ShouldHaveValidationErrorFor(x => x.ApprovedDate, parvDetail);


        }

        

    }
}
