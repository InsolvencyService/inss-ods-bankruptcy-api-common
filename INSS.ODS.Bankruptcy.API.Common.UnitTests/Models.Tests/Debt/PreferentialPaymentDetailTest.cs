using System;
using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Debt;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Debt
{
    [TestClass]
    public class PreferentialPaymentDetailTest
    {
        private PreferentialPaymentDetailInterfaceValidator _validator;

        [TestInitialize]
        public void Setup()
        {
            _validator = new PreferentialPaymentDetailInterfaceValidator();
        }

        [TestMethod]
        [TestCategory("PreferentialPaymentDetail")]
        public void PreferentialPaymentDetail_MissingFields()
        {
            var model = new PreferentialPaymentDetail();

            _validator.ShouldHaveValidationErrorFor(x => x.PaymentAmount, model);
            _validator.ShouldHaveValidationErrorFor(x => x.PaymentDate, model);
            _validator.ShouldNotHaveValidationErrorFor(x => x.AssetName, model);
        }

        [TestMethod]
        [TestCategory("PreferentialPaymentDetail")]
        public void PreferentialPaymentDetail_PaymentDate_ShouldErrorOnInvalidValue()
        {
            var model = new PreferentialPaymentDetail();

            _validator.ShouldHaveValidationErrorFor(x => x.PaymentDate, model);

            model.PaymentDate = DateTime.Now.AddYears(1);
            _validator.ShouldHaveValidationErrorFor(x => x.PaymentDate, model);
        }

        [TestMethod]
        [TestCategory("PreferentialPaymentDetail")]
        public void PreferentialPaymentDetail_PaymentDate_ShouldPassOnValidValue()
        {
            var model = new PreferentialPaymentDetail();

            model.PaymentDate = DateTime.Now.AddYears(-1);
            _validator.ShouldNotHaveValidationErrorFor(x => x.PaymentDate, model);
        }

        [TestMethod]
        [TestCategory("PreferentialPaymentDetail")]
        public void PreferentialPaymentDetail_PaymentAmount_ShouldErrorOnInvalidValue()
        {
            var model = new PreferentialPaymentDetail();

            _validator.ShouldHaveValidationErrorFor(x => x.PaymentAmount, model);

            model.PaymentAmount = -100;
            _validator.ShouldHaveValidationErrorFor(x => x.PaymentAmount, model);
        }

        [TestMethod]
        [TestCategory("PreferentialPaymentDetail")]
        public void PreferentialPaymentDetail_PaymentAmount_ShouldPassOnValidValue()
        {
            var model = new PreferentialPaymentDetail()
            {
                PaymentAmount = 200
            };

            _validator.ShouldNotHaveValidationErrorFor(x => x.PaymentAmount, model);
        }

        [TestMethod]
        [TestCategory("PreferentialPaymentDetail")]
        public void PreferentialPaymentDetail_AssetName_ShouldErrorOnInvalidValue()
        {
            var model = new PreferentialPaymentDetail()
            {
                AssetName = "ABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJA"
            };

            _validator.ShouldHaveValidationErrorFor(x => x.AssetName, model);

            model.AssetName = "A";
            _validator.ShouldHaveValidationErrorFor(x => x.AssetName, model);
        }

        [TestMethod]
        [TestCategory("PreferentialPaymentDetail")]
        public void PreferentialPaymentDetail_AssetName_ShouldPassOnValidValue()
        {
            var model = new PreferentialPaymentDetail()
            {
                AssetName = "TV"
            };

            _validator.ShouldNotHaveValidationErrorFor(x => x.AssetName, model);
        }
    }
}
