using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Enums;

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
            Assert.IsTrue(itemManagementPage.searchByFieldSet.IsDisplayed(), "Current page is not {0}", itemManagementPage);
            itemManagementPage.ClickUserInfoLink();
            Assert.IsTrue(userInfoPage.userInfoFieldSet.IsDisplayed(), "Current page is not {0}", userInfoPage);
        }
    }
}
