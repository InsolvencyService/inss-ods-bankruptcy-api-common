using FluentValidation.TestHelper;
using INSS.ODS.Bankruptcy.API.Common.Models.Debt;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.Debt;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Debt
{
    [TestClass]
    public class DebtReliefHistoryTest
    {
        private DebtReliefOptionUsedInterfaceValidator _validator;

        [TestInitialize]
        public void Setup()
        {
            _validator = new DebtReliefOptionUsedInterfaceValidator();
        }

        [TestMethod]
        [TestCategory("DebtReliefHistory")]
        public void DebtReliefHistory_DebtReliefOptionType_ShouldErrorOnInvalidValue()
        {
            var model = new DebtReliefOptionUsed();
            
            _validator.ShouldHaveValidationErrorFor(x => x.DebtReliefOptionType, model);
        }

        [TestMethod]
        [TestCategory("DebtReliefHistory")]
        public void DebtReliefHistory_DebtReliefOptionType_ShouldPassOnValidValue()
        {
            var model = new DebtReliefOptionUsed()
            {
                DebtReliefOptionType = "Bankruptcy"
            };
            
            _validator.ShouldNotHaveValidationErrorFor(x => x.DebtReliefOptionType, model);
        }
    }
}
