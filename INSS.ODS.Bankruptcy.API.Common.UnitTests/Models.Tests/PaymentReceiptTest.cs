using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.API.Common.Utilities.TestHelpers;
using System.Linq;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests
{
    [TestClass]
    [Ignore(TestConstants.ReasonForIgnoringUnitTests)]
    public class PaymentReceiptTest
    {
        [TestMethod]
        public void TestThatPaymentReceiptWithValidMetadataIsValid()
        {
            var payment = new PaymentReceipt()
            {
                PaymentProvider = "Worldpay",
                AccountId = "ADJ1234567",
                TransactionId = "ADJ1234567-001",
                TranscationTime = new DateTime(2015, 4, 1),
                TransactionAmountInPence = 1500,
                ProviderMetadata = @"{'PZAgentRef' : '002983','Terminal Ser No': '1234','TXN Source': '6' }"
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(payment);

            Assert.IsTrue(modelState.IsValid);
        }

        [TestMethod]
        public void TestThatPaymentReceiptWithEmptyMetadataIsValid()
        {
            var payment = new PaymentReceipt()
            {
                PaymentProvider = "Worldpay",
                AccountId = "ADJ1234567",
                TransactionId = "ADJ1234567-001",
                TranscationTime = new DateTime(2015, 4, 1),
                TransactionAmountInPence = 1500,
                ProviderMetadata = "{}"
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(payment);

            Assert.IsTrue(modelState.IsValid);
        }

        [TestMethod]
        public void TestThatPaymentReceiptWithNoMetadataIsValid()
        {
            var payment = new PaymentReceipt()
            {
                PaymentProvider = "Worldpay",
                AccountId = "ADJ1234567",
                TransactionId = "ADJ1234567-001",
                TranscationTime = new DateTime(2015, 4, 1),
                TransactionAmountInPence = 1500,
            };

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(payment);

            Assert.IsTrue(modelState.IsValid);
        }

        [TestMethod]
        public void TestThatEmptyPaymentReceiptModelIsInvalid()
        {
            var payment = new PaymentReceipt();
            payment.PaymentProvider = "Worldpay";

            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(payment);
            Assert.IsFalse(modelState.IsValid);

            Assert.IsTrue(modelState["TransactionId"].Errors.Any(x => x.ErrorMessage == "The TransactionId field is required."));
            Assert.IsTrue(modelState["TransactionAmountInPence"].Errors.Any(x => x.ErrorMessage == "The field TransactionAmountInPence must be between 1 and 2147483647."));

            //Value fields that is always valid
            // value fields that will always have some value, even when not assigned 
            Assert.IsNull(modelState["Id"]);

            //Provider metadata can be empty... 
            Assert.IsNull(modelState["ProviderMetadata"]);
        }

        [TestMethod]
        public void TestThatFutureDatePaymentReceiptIsInvalid()
        {
            var payment = new PaymentReceipt()
            {
                PaymentProvider = "Worldpay",
                AccountId = "ADJ1234567",
                TransactionId = "ADJ1234567-001",
                TranscationTime = DateTime.Now.AddDays(1),
                TransactionAmountInPence = 1500,
            };
            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(payment);
            Assert.IsFalse(modelState.IsValid);

            Assert.IsTrue(modelState["TranscationTime"].Errors.Any(x => x.ErrorMessage == "The Transaction Time cannot be in future."));
        }

        [TestMethod]
        public void TestThatPaymentReceiptWithInvalidMetadataIsInvalid()
        {
            var payment = new PaymentReceipt()
            {
                PaymentProvider = "Worldpay",
                AccountId = "ADJ1234567",
                TransactionId = "ADJ1234567-001",
                TranscationTime = new DateTime(2015, 04, 15),
                TransactionAmountInPence = 1500,
                ProviderMetadata = "{NOT A JSON DATA}"
            };
            var mockController = new MockTestController();

            var modelState = mockController.TryFullModelValidation(payment);
            Assert.IsFalse(modelState.IsValid);

            Assert.IsTrue(modelState["ProviderMetadata"].Errors.Any(x => x.ErrorMessage == "The field ProviderMetadata is invalid."));
        }

    }
}
