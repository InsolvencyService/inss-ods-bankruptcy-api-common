using System;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Models.Creditors;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Creditors
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class CreditorTests
    {
        [TestMethod]
        public void TestCreditorInvalid()
        {
            var creditor = new Creditor()
            {
                CreditorAddress = new Address()
            };
            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(creditor);
            Assert.IsFalse(modelState.IsValid);
            Assert.IsTrue(modelState.ContainsKey("CreditorName"));
            Assert.IsTrue(modelState.ContainsKey("CreditorAddress.Address_1"));
            Assert.IsTrue(modelState.ContainsKey("CreditorAddress.PostCode"));
            Assert.IsTrue(modelState.ContainsKey("CreditorAddress.Country"));
        }

        [TestMethod]
        public void TestCreditorValid()
        {
            var creditor = new Creditor
            {
                Id = 1,
                CreditorName = "ABC Bank",
                CreditorAddress = new Address
                {
                    Address_1 = "Some Street",
                    PostCode = "SB1 8UK",
                    Country = "UK",
                    TownCity = "DD"
                },
            };

            var mockController = new MockTestController();
            var modelState = mockController.TryFullModelValidation(creditor);
            Assert.IsTrue(modelState.IsValid);
        }

        [TestMethod]
        public void TestCreditorIncompleteness()
        {
            var creditor = new Creditor();
            Assert.IsFalse(creditor.IsCompleteRecord);
        }

        [TestMethod]
        public void TestCreditorCompletenessWithoutReason()
        {
            var creditor = new Creditor
            {
                AmountYouOwe = new AmountYouOwe
                {
                    DebtType = "Utilities",
                }
            };

            Assert.IsTrue(creditor.IsCompleteRecord);
        }

        [TestMethod]
        public void TestCreditorIncompletenessWithReason()
        {
            var creditor = new Creditor
            {
                AmountYouOwe = new AmountYouOwe
                {
                    DebtType = "Personal loan (unsecured)",
                }
            };

            Assert.IsFalse(creditor.IsCompleteRecord);
        }

        [TestMethod]
        public void TestCreditorCompletenessWithReason()
        {
            var creditor = new Creditor
            {
                AmountYouOwe = new AmountYouOwe
                {
                    DebtType = "Personal loan (unsecured)",
                },
                ReasonForDebt = new ReasonForDebt
                {
                    HomeImprovements = true
                }
            };

            Assert.IsTrue(creditor.IsCompleteRecord);
        }

    }
}
