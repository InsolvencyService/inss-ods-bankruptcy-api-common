using System;
using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Debt;
using INSS.ODS.Bankruptcy.API.Common.Resources.Debt;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Debt
{
    [TestClass]
    public class DebtReliefOptionUsedTest
    {
        private DebtReliefOptionUsedInterfaceValidator _validator;

        [TestInitialize]
        public void Setup()
        {
            _validator = new DebtReliefOptionUsedInterfaceValidator();
        }

        [TestMethod]
        [TestCategory("DebtReliefOptionUsed")]
        public void DebtReliefHistory_DebtReliefOptionStartDate_ShouldErrorOnInvalidValue()
        {
            var model = new DebtReliefOptionUsed();
            
            _validator.ShouldHaveValidationErrorFor(x => x.DebtReliefOptionStartDate, model);

            model.DebtReliefOptionStartDate = DateTime.Now.AddYears(1);
            _validator.ShouldHaveValidationErrorFor(x => x.DebtReliefOptionStartDate, model);
        }

        [TestMethod]
        [TestCategory("DebtReliefOptionUsed")]
        public void DebtReliefHistory_DebtReliefOptionStartDate_ShouldPassOnValidValue()
        {
            var model = new DebtReliefOptionUsed()
            {
                DebtReliefOptionStartDate = new DateTime(2012, 1, 1)
            };
            
            _validator.ShouldNotHaveValidationErrorFor(x => x.DebtReliefOptionStartDate, model);
        }

        [TestMethod]
        [TestCategory("DebtReliefOptionUsed")]
        public void DebtReliefHistory_DebtReliefOptionReferenceNumber_ShouldErrorOnInvalidValue()
        {
            var model = new DebtReliefOptionUsed()
            {
                DebtReliefOptionType = DebtReliefHistoryResources.Debt_DebtReliefHistory_DebtReliefOptionType_Bankruptcy_Label
            };

            _validator.ShouldHaveValidationErrorFor(x => x.DebtReliefOptionReferenceNumber, model);

            model.DebtReliefOptionType = DebtReliefHistoryResources.Debt_DebtReliefHistory_DebtReliefOptionType_DebtReliefOrder_Label;
            _validator.ShouldHaveValidationErrorFor(x => x.DebtReliefOptionReferenceNumber, model);
        }

        [TestMethod]
        [TestCategory("DebtReliefOptionUsed")]
        public void DebtReliefHistory_DebtReliefOptionReferenceNumber_ShouldPassOnValidValue()
        {
            var model = new DebtReliefOptionUsed()
            {
                DebtReliefOptionType = DebtReliefHistoryResources.Debt_DebtReliefHistory_DebtReliefOptionType_Bankruptcy_Label,
                DebtReliefOptionReferenceNumber = "AB123456"
            };

            _validator.ShouldNotHaveValidationErrorFor(x => x.DebtReliefOptionReferenceNumber, model);

            model.DebtReliefOptionType = DebtReliefHistoryResources.Debt_DebtReliefHistory_DebtReliefOptionType_DebtReliefOrder_Label;
            _validator.ShouldNotHaveValidationErrorFor(x => x.DebtReliefOptionReferenceNumber, model);

            model.DebtReliefOptionType = DebtReliefHistoryResources.Debt_DebtReliefHistory_DebtReliefOptionType_DebtManagementPlan_Label;
            model.DebtReliefOptionReferenceNumber = "";
            _validator.ShouldNotHaveValidationErrorFor(x => x.DebtReliefOptionReferenceNumber, model);
        }
    }
}
