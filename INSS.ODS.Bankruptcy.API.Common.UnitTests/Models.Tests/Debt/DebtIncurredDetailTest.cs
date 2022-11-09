using System;
using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models.Debt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Debt;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Debt
{
    [TestClass]
    public class DebtIncurredDetailTest
    {
        private DebtIncurredDetailInterfaceValidator _validator;

        [TestInitialize]
        public void Setup()
        {
            _validator = new DebtIncurredDetailInterfaceValidator();
        }

        [TestMethod]
        [TestCategory("DebtIncurredDetail")]
        public void DebtIncurredDetail_StartDate_ShouldErrorOnInvalidValue()
        {
            var model = new DebtIncurredDetail();
            
            _validator.ShouldHaveValidationErrorFor(x => x.StartDate, model);

            model.StartDate = DateTime.Now.AddYears(1);
            _validator.ShouldHaveValidationErrorFor(x => x.StartDate, model);
        }

        [TestMethod]
        [TestCategory("DebtIncurredDetail")]
        public void DebtIncurredDetail_StartDate_ShouldPassOnValidValue()
        {
            var model = new DebtIncurredDetail();

            model.StartDate = DateTime.Now.AddYears(-1);
            _validator.ShouldNotHaveValidationErrorFor(x => x.StartDate, model);
        }

        [TestMethod]
        [TestCategory("DebtIncurredDetail")]
        public void DebtIncurredDetail_ReasonSelected_ShouldErrorOnInvalidValue()
        {
            var model = new DebtIncurredDetail()
            {
                StartDate = DateTime.Now.AddYears(-1)
            };
            
            _validator.ShouldHaveValidationErrorFor(x => x.DebtIncurredReasonValidationHook, model);
        }

        [TestMethod]
        [TestCategory("DebtIncurredDetail")]
        public void DebtIncurredDetail_ReasonSelected_ShouldErrorOnValidValue()
        {
            var model = new DebtIncurredDetail()
            {
                StartDate = DateTime.Now.AddYears(-1),
                PersonalRelationshipBreakdown = true
            };

            _validator.ShouldNotHaveValidationErrorFor(x => x.DebtIncurredReasonValidationHook, model);
        }

        [TestMethod]
        [TestCategory("DebtIncurredDetail")]
        public void DebtIncurredDetail_GamblingAmount_ShouldErrorOnInvalidValue()
        {
            var model = new DebtIncurredDetail()
            {
                PersonalGambling = true
            };
            
            _validator.ShouldHaveValidationErrorFor(x => x.GamblingAmount, model);

            model.GamblingAmount = -100;
            _validator.ShouldHaveValidationErrorFor(x => x.GamblingAmount, model);
        }

        [TestMethod]
        [TestCategory("DebtIncurredDetail")]
        public void DebtIncurredDetail_GamblingAmount_ShouldPassOnValidValue()
        {
            var model = new DebtIncurredDetail()
            {
                PersonalGambling = true,
                GamblingAmount = 200
            };

            _validator.ShouldNotHaveValidationErrorFor(x => x.GamblingAmount, model);
        }

        [TestMethod]
        [TestCategory("DebtIncurredDetail")]
        public void DebtIncurredDetail_PersonalOtherText_ShouldErrorOnInvalidValue()
        {
            var model = new DebtIncurredDetail()
            {
                PersonalOther = true
            };

            _validator.ShouldHaveValidationErrorFor(x => x.PersonalDebtIncurredReasonValidationHook, model);

            model.PersonalOtherText = "ABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJA";
            _validator.ShouldHaveValidationErrorFor(x => x.PersonalDebtIncurredReasonValidationHook, model);
        }

        [TestMethod]
        [TestCategory("DebtIncurredDetail")]
        public void DebtIncurredDetail_PersonalOtherText_ShouldPassOnValidValue()
        {
            var model = new DebtIncurredDetail()
            {
                PersonalOther = true,
                PersonalOtherText = "Because of some other reason"
            };

            _validator.ShouldNotHaveValidationErrorFor(x => x.PersonalDebtIncurredReasonValidationHook, model);
        }

        [TestMethod]
        [TestCategory("DebtIncurredDetail")]
        public void DebtIncurredDetail_BusinessOtherText_ShouldErrorOnInvalidValue()
        {
            var model = new DebtIncurredDetail()
            {
                BusinessOther = true
            };

            _validator.ShouldHaveValidationErrorFor(x => x.BusinessDebtIncurredReasonValidationHook, model);

            model.BusinessOtherText = "ABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJA";
            _validator.ShouldHaveValidationErrorFor(x => x.BusinessDebtIncurredReasonValidationHook, model);
        }

        [TestMethod]
        [TestCategory("DebtIncurredDetail")]
        public void DebtIncurredDetail_BusinessOtherText_ShouldPassOnValidValue()
        {
            var model = new DebtIncurredDetail()
            {
                BusinessOther = true,
                BusinessOtherText = "Because of some other reason"
            };

            _validator.ShouldNotHaveValidationErrorFor(x => x.BusinessDebtIncurredReasonValidationHook, model);
        }
    }
}
