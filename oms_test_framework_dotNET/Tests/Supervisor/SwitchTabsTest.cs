using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Enums;
using static oms_test_framework_dotNET.Asserts.FluentAssert;

namespace oms_test_framework_dotNET.Tests.Supervisor
{
    [TestClass]
    public class SwitchTabsTest : TestRunner
    {

        [TestInitialize]
        public void SetUpTest()
        {
            userInfoPage = logInPage.LogInAs(Roles.SUPERVISOR);
        }

        [TestMethod]
        public void TestSwitchTabsAbility()
        {
            itemManagementPage = userInfoPage.ClickItemManagementLink();

            AssertThat(itemManagementPage.searchByFieldSet).IsDisplayed();

            itemManagementPage.ClickUserInfoLink();

            AssertThat(userInfoPage.userInfoFieldSet).IsDisplayed();
        }
    }
}
