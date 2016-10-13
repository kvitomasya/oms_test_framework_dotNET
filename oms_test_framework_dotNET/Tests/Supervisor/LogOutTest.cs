using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;

namespace oms_test_framework_dotNET.Tests.Supervisor
{
    [TestClass]
    public class LogOutTest : TestRunner
    {
        private const String SupervisorLogin = "login2";
        private const String SupervisorPassword = "qwerty";

        [TestInitialize]
        public void SetUp()
        {
            userInfoPage = logInPage.LogInAs(SupervisorLogin, SupervisorPassword);
            itemManagementPage = userInfoPage.ClickItemManagementLink();
        }

        [TestMethod]
        public void testItemManagementPageLogOutAbility()
        {
            Assert.IsTrue(itemManagementPage.SearchByTextLabel.Displayed,
                "Item Management page doesn't exist");
            itemManagementPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.Displayed,
                "Logout is not working");
        }
    }
}
