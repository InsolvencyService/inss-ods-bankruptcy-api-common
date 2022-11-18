using INSS.ODS.API.Common.Utilities.TestHelpers;
using INSS.ODS.Bankruptcy.API.Common.Models;
using INSS.ODS.Bankruptcy.API.Common.Resources.PensionAndInsurance;
using INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Creditors;

[TestClass]
[Ignore(TestConstants.ReasonForIgnoringUnitTests)]
public class PolicyBeneficiaryListTests
{
    [TestMethod]
    public void Test_PolicyBeneficiaryListTests_EmptyData()
    {
        var payload = new PolicyBeneficiaryList();

        var mockController = new MockTestController();
        var modelState = mockController.TryFullModelValidation(payload);
        Assert.IsFalse(modelState.IsValid);
        Assert.IsTrue(modelState["PolicyBeneficiaries"].Errors.Any(x => x.ErrorMessage == OtherPolicyBeneficiariesResources.PensionAndInsurance_OtherPolicyBeneficiaries_Error_InvalidShares));
    }

    [TestMethod]
    public void Test_PolicyBeneficiaryListTests_InvalidData1()
    {
        var payload = new PolicyBeneficiaryList()
        {
            PolicyBeneficiaries = new List<PolicyBeneficiaryDetail>() {
                new PolicyBeneficiaryDetail() {
                    FirstName = "You",
                    LastName = "You",
                    Relationship = "Self",
                    BeneficiaryShare = 0.5
                }
            }
        };

        var mockController = new MockTestController();
        var modelState = mockController.TryFullModelValidation(payload);
        Assert.IsFalse(modelState.IsValid);
        Assert.IsTrue(modelState["PolicyBeneficiaries"].Errors.Any(x => x.ErrorMessage == OtherPolicyBeneficiariesResources.PensionAndInsurance_OtherPolicyBeneficiaries_Error_InvalidShares));
        Assert.IsTrue(modelState["PolicyBeneficiaries[0].BeneficiaryShare"].Errors.Any(x => x.ErrorMessage == PolicyBeneficiaryDetailResources.PensionAndInsurance_PolicyBeneficiaryDetail_RelationshipOther_Error_YourShareTooLow));
    }

    [TestMethod]
    public void Test_PolicyBeneficiaryListTests_InvalidData2()
    {
        var payload = new PolicyBeneficiaryList()
        {
            PolicyBeneficiaries = new List<PolicyBeneficiaryDetail>(){
                new PolicyBeneficiaryDetail() {
                    FirstName = "You",
                    LastName = "You",
                    Relationship = "Self",
                    BeneficiaryShare = 50.0
                }
            }
        };

        var mockController = new MockTestController();
        var modelState = mockController.TryFullModelValidation(payload);
        Assert.IsFalse(modelState.IsValid);
        Assert.IsTrue(modelState["PolicyBeneficiaries"].Errors.Any(x => x.ErrorMessage == OtherPolicyBeneficiariesResources.PensionAndInsurance_OtherPolicyBeneficiaries_Error_InvalidShares));
    }

    [TestMethod]
    public void Test_PolicyBeneficiaryListTests_InvalidData3()
    {
        var payload = new PolicyBeneficiaryList()
        {
            PolicyBeneficiaries = new List<PolicyBeneficiaryDetail>() {
                new PolicyBeneficiaryDetail() {
                    FirstName = "You",
                    LastName = "You",
                    Relationship = "Self",
                    BeneficiaryShare = 50.0
                },
                new PolicyBeneficiaryDetail() {
                    FirstName = "First",
                    LastName = "Child",
                    Relationship = "Child",
                    BeneficiaryShare = 25.0
                }
            }
        };

        var mockController = new MockTestController();
        var modelState = mockController.TryFullModelValidation(payload);
        Assert.IsFalse(modelState.IsValid);
        Assert.IsTrue(modelState["PolicyBeneficiaries"].Errors.Any(x => x.ErrorMessage == OtherPolicyBeneficiariesResources.PensionAndInsurance_OtherPolicyBeneficiaries_Error_InvalidShares));
    }

    [TestMethod]
    public void Test_PolicyBeneficiaryListTests_InvalidData4()
    {
        var payload = new PolicyBeneficiaryList()
        {
            PolicyBeneficiaries = new List<PolicyBeneficiaryDetail>(){
                new PolicyBeneficiaryDetail() {
                    FirstName = "You",
                    LastName = "You",
                    Relationship = "Self",
                    BeneficiaryShare = 50.0
                },
                new PolicyBeneficiaryDetail() {
                    FirstName = "First",
                    LastName = "Child",
                    Relationship = "Child",
                    BeneficiaryShare = 30.0
                },
                new PolicyBeneficiaryDetail() {
                    FirstName = "First",
                    LastName = "Child",
                    Relationship = "Child",
                    BeneficiaryShare = 30.0
                }
            }
        };

        var mockController = new MockTestController();
        var modelState = mockController.TryFullModelValidation(payload);
        Assert.IsFalse(modelState.IsValid);
        Assert.IsTrue(modelState["PolicyBeneficiaries"].Errors.Any(x => x.ErrorMessage == OtherPolicyBeneficiariesResources.PensionAndInsurance_OtherPolicyBeneficiaries_Error_InvalidShares));
    }

    [TestMethod]
    public void Test_PolicyBeneficiaryListTests_ValidData1()
    {
        var payload = new PolicyBeneficiaryList()
        {
            PolicyBeneficiaries = new List<PolicyBeneficiaryDetail>(){
                new PolicyBeneficiaryDetail() {
                    FirstName = "You",
                    LastName = "You",
                    Relationship = "Self",
                    BeneficiaryShare = 50.0
                },
                new PolicyBeneficiaryDetail() {
                    FirstName = "First",
                    LastName = "Child",
                    Relationship = "Child",
                    BeneficiaryShare = 25.0
                },
                new PolicyBeneficiaryDetail() {
                    FirstName = "First",
                    LastName = "Child",
                    Relationship = "Child",
                    BeneficiaryShare = 25.0
                }
            }
        };

        var mockController = new MockTestController();
        var modelState = mockController.TryFullModelValidation(payload);
        Assert.IsTrue(modelState.IsValid);
    }

    [TestMethod]
    public void Test_PolicyBeneficiaryListTests_ValidData_EqualShare()
    {
        var payload = new PolicyBeneficiaryList()
        {
            PolicyBeneficiaries = new List<PolicyBeneficiaryDetail>(){
                new PolicyBeneficiaryDetail() {
                    FirstName = "You",
                    LastName = "You",
                    Relationship = "Self",
                    BeneficiaryShare = 33.3
                },
                new PolicyBeneficiaryDetail() {
                    FirstName = "First",
                    LastName = "Child",
                    Relationship = "Child",
                    BeneficiaryShare = 33.3
                },
                new PolicyBeneficiaryDetail() {
                    FirstName = "First",
                    LastName = "Child",
                    Relationship = "Child",
                    BeneficiaryShare = 33.3
                }
            }
        };

        var mockController = new MockTestController();
        var modelState = mockController.TryFullModelValidation(payload);
        Assert.IsTrue(modelState.IsValid);
    }
}
