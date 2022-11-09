using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.Models.DRO.OfficialReceiverExport;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.DRO.Model
{
    [TestClass]
    public class PersonalDetailTests
    {
        [TestMethod]
        public void PersonalDetail_FullName_NoMiddleName()
        {
            var model = new PersonalDetail()
            {
                Forename = "Bill",
                MiddleNames = null,
                Surname = "Billson"
            };

            var result = model.FullName;

            Assert.AreEqual("Bill Billson", result);
        }

        [TestMethod]
        public void PersonalDetail_FullName_MiddleName()
        {
            var model = new PersonalDetail()
            {
                Forename = "Bill",
                MiddleNames = "Billy",
                Surname = "Billson"
            };

            var result = model.FullName;

            Assert.AreEqual("Bill Billy Billson", result);
        }
    }
}
