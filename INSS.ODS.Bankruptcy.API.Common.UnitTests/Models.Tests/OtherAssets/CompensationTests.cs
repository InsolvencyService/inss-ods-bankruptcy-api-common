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
    public class CompensationTests
    {
        [TestMethod]
        public void CompensationValidTest()
        {
            var model = new OtherAssetsCompensation();
            var validator = new OtherAssetsCompensationValidator();
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
        public void CompensationInvalidTest()
        {
            var model = new OtherAssetsCompensation();
            var validator = new OtherAssetsCompensationValidator();
            ValidationResult result = null;

            //Amount must be provided (if description is)
            model.Amount = null;
            model.Description = "Test";
            result = validator.Validate(model);
            Assert.IsFalse(result.IsValid, "Amount must be provided");
            Assert.IsTrue(result.HasError("Amount", CompensationsResources.OtherAssets_Compensations_Amount_Error_Required));

            //Amount must be greater than zero
            model.Amount = 0;
            model.Description = "Test";
            result = validator.Validate(model);
            Assert.IsFalse(result.IsValid, "Amount must be greather than 0");
            Assert.IsTrue(result.HasError("Amount", CompensationsResources.OtherAssets_Compensations_Amount_Error_Minimum));

            //Description must be provided (if amount is)
            model.Amount = 100;
            model.Description = String.Empty;
            result = validator.Validate(model);
            Assert.IsFalse(result.IsValid, "Description must be provided");
            Assert.IsTrue(result.HasError("Description", CompensationsResources.OtherAssets_Compensations_Description_Error_Required));

            //Description cannot be over 100 characters
            model.Amount = 100;
            model.Description = Helpers.Constants.InvalidLengthString;
            result = validator.Validate(model);
            Assert.IsFalse(result.IsValid, "Description must be no more than 100 characters");
            Assert.IsTrue(result.HasError("Description", CompensationsResources.OtherAssets_Compensations_Description_Error_MaxLength));
        }

    }
}
