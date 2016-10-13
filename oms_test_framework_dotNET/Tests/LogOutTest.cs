using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;

namespace oms_test_framework_dotNET.Tests
{
    [TestClass]
    public class LogOutTest : TestRunner
    {
        private const String UserLogin = "vpopkin";
        private const String UserPassword = "qwerty";

        [TestMethod]
        public void testUserInfoPageLogOutAbility()
        {
            userInfoPage = logInPage.LogInAs(UserLogin, UserPassword);
            userInfoPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.Displayed,
                "Logout is not working");
        }

        [TestMethod]
        public void testLogInPageLogOutAbility()
        {
            logInPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.Displayed,
                "Logout is not working");
        }
    }
}
