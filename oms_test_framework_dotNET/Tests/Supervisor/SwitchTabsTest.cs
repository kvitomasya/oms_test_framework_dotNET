using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;

namespace oms_test_framework_dotNET.Tests.Supervisor
{
    [TestClass]
    public class SwitchTabsTest : TestRunner
    {
        private const string SupervisorLogin = "login2";
        private const string SupervisorPassword = "qwerty";

        [TestInitialize]
        public void SetUpTest()
        {

            userInfoPage = logInPage.LogInAs(SupervisorLogin, SupervisorPassword);

        }

        [TestMethod]
        public void TestSwitchTabsAbility()
        {

            itemManagementPage = userInfoPage.ClickItemManagementLink();
            Assert.IsTrue(itemManagementPage.SearchByFieldSet.Displayed);
            itemManagementPage.ClickUserInfoLink();
            Assert.IsTrue(userInfoPage.UserInfoFieldSet.Displayed);

        }
    }
}
