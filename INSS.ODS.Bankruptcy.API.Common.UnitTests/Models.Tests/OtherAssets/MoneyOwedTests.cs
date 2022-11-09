using System;
using FluentValidation.Results;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INSS.ODS.Bankruptcy.API.Common.Models.OtherAssets;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.OtherAssets;
using INSS.ODS.Bankruptcy.API.Common.Resources.OtherAssets;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.OtherAssets
{
    [TestClass]
    public class MoneyOwedTests
    {
        [TestMethod]
        public void MoneyOwedsValidTest()
        {
            var model = new OtherAssetsMoneyOwed();
            var validator = new OtherAssetsMoneyOwedValidator();
            ValidationResult result = null;

            //acceptable for all values to be missing
            model.Amount = null;
            model.Reason = String.Empty;
            model.WhoOwesYou = String.Empty;
            result = validator.Validate(model);
            Assert.IsTrue(result.IsValid, "All values can be empty");

            //both values provided
            model.Amount = 100;
            model.Reason = "Test";
            model.WhoOwesYou = "Test";
            result = validator.Validate(model);
            Assert.IsTrue(result.IsValid, "Valid if both values provided");
        }

        [TestMethod]
        public void MoneyOwedsInvalidTest()
        {
            var model = new OtherAssetsMoneyOwed();
            var validator = new OtherAssetsMoneyOwedValidator();
            ValidationResult result = null;

            //Amount must be greater than zero
            model.Amount = 0;
            model.Reason = "Test";
            model.WhoOwesYou = "Test";
            result = validator.Validate(model);
            Assert.IsFalse(result.IsValid, "Amount must be greather than 0");
            Assert.IsTrue(result.HasError("Amount", MoneyOwedResources.OtherAssets_MoneyOwed_Amount_Error_Minimum));

            //Amount must be provided (if reason and WhoOwesYou are)
            model.Amount = null;
            model.Reason = "Test";
            model.WhoOwesYou = "Test";
            result = validator.Validate(model);
            Assert.IsFalse(result.IsValid, "Amount must be provided");
            Assert.IsTrue(result.HasError("Amount", MoneyOwedResources.OtherAssets_MoneyOwed_Amount_Error_Required));

            //Reason must be provided (if Amount or WhoOwesYou are)
            model.Amount = 100;
            model.Reason = String.Empty;
            model.WhoOwesYou = "Test";
            result = validator.Validate(model);
            Assert.IsFalse(result.IsValid, "Reason must be provided");
            Assert.IsTrue(result.HasError("Reason", MoneyOwedResources.OtherAssets_MoneyOwed_Reason_Error_Required));

            //WhoOwesYou must be provided (if Reason or WhoOwesYou are)
            model.Amount = 100;
            model.Reason = "Test";
            model.WhoOwesYou = String.Empty;
            result = validator.Validate(model);
            Assert.IsFalse(result.IsValid, "WhoOwesYou must be provided");
            Assert.IsTrue(result.HasError("WhoOwesYou", MoneyOwedResources.OtherAssets_MoneyOwed_WhoOwesYou_Error_Required));

        }

    }
}
