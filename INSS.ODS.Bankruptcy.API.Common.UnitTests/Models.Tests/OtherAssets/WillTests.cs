using System;
using FluentValidation.Results;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Helpers;
using INSS.ODS.Bankruptcy.API.Common.Models.OtherAssets;
using INSS.ODS.Bankruptcy.API.Common.Models.Validators.OtherAssets;
using INSS.ODS.Bankruptcy.API.Common.Resources.OtherAssets;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.OtherAssets
{
    [TestClass]
    public class WillTests
    {
        [TestMethod]
        public void WillsValidTest()
        {
            var model = new OtherAssetsWill();
            var validator = new OtherAssetsWillValidator();
            ValidationResult result = null;

            //acceptable for both values to be missing
            model.Amount = null;
            model.Description = String.Empty;
            result = validator.Validate(model);
            Assert.IsTrue(result.IsValid, "Both values can be empty");

            //both values provided
            model.Amount = 100;
            model.Description = "Test";
            result = validator.Validate(model);
            Assert.IsTrue(result.IsValid, "Valid if both values provided");
        }

        [TestMethod]
        public void WillsInvalidTest()
        {
            var model = new OtherAssetsWill();
            var validator = new OtherAssetsWillValidator();
            ValidationResult result = null;

            //Amount must be provided (if description is)
            model.Amount = null;
            model.Description = "Test";
            result = validator.Validate(model);
            Assert.IsFalse(result.IsValid, "Amount must be provided");
            Assert.IsTrue(result.HasError("Amount", WillsResources.OtherAssets_Wills_Amount_Error_Required));

            //Amount must be greater than zero
            model.Amount = 0;
            model.Description = "Test";
            result = validator.Validate(model);
            Assert.IsFalse(result.IsValid, "Amount must be greather than 0");
            Assert.IsTrue(result.HasError("Amount", WillsResources.OtherAssets_Wills_Amount_Error_Minimum));

            //Description must be provided (if amount is)
            model.Amount = 100;
            model.Description = String.Empty;
            result = validator.Validate(model);
            Assert.IsFalse(result.IsValid, "Description must be provided");
            Assert.IsTrue(result.HasError("Description", WillsResources.OtherAssets_Wills_Description_Error_Required));

        }

    }
}
