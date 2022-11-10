using INSS.ODS.Bankruptcy.API.Common.Models.ApplicationOverview;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.ApplicationOverview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.ApplicationOverview
{
    [TestClass]
    public class RefundBankDetailsTests
    {
        [TestMethod]
        public void TestRefundBankDetails_Valid()
        {
            var model = new RefundBankDetails
            {
                Id = 1,
                AccountHolder = "Mr Brian Bagley",
                AccountNumber = "1234567A",
                BankName = "Super Test Bank",
                SortCode = "1234"
            };

            var validator = new RefundBankDetailsValidator();
            var result = validator.Validate(model);
            Assert.IsTrue(result.IsValid);
        }

        [TestMethod]
        public void TestRefundBankDetails_Invalid_MandatoryFields()
        {
            var model = new RefundBankDetails
            {
                Id = 1,
                AccountHolder = "",
                AccountNumber = "",
                BankName = "",
                SortCode = ""
            };

            var validator = new RefundBankDetailsValidator();
            var result = validator.Validate(model);
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual(4, result.Errors.Count);
        }

        [TestMethod]
        public void TestRefundBankDetails_Invalid_Length()
        {
            var model = new RefundBankDetails
            {
                Id = 1,
                AccountHolder = new string('A', 151),
                AccountNumber = new string('A', 151),
                BankName = new string('A', 151),
                SortCode = new string('A', 151),
            };

            var validator = new RefundBankDetailsValidator();
            var result = validator.Validate(model);
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual(4, result.Errors.Count);
        }
    }
}
