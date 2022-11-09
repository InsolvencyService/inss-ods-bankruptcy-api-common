namespace INSS.ODS.Bankruptcy.API.Common.UnitTests.Constants;

public static class TestConstants
{
    /*
     As discussed with Tech Lead and dev team, these unit tests are  being ignored as part of upgrade to .NET 6 due to time limitation
     These failing  unit tests have dependency on code from ODS API Common library, and once ODS Common library issues have been fixed, these unit tests can be included in testing
     Unit Tests using MockTestController are failing, MockTestController is in ODS API Common library, fixing ODS common unit tests will fix these unit tests as well
     */

    public const string ReasonForIgnoringUnitTests = "Ignored as part of upgrade to .NET 6, most failures due to dependency on ods.api.common library";
}
