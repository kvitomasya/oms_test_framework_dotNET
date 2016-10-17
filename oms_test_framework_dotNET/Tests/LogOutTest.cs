using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;

namespace oms_test_framework_dotNET.Tests
{
    [TestClass]
    public class LogOutTest : TestRunner
    {

        [TestMethod]
        public void TestLogInPageLogOutAbility()
        {
            logInPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.Displayed,
                "Logout is not working");
        }

        [TestMethod]
        public void TestUserInfoPageLogOutAbility()
        {
            const String UserLogin = "vpopkin";
            const String UserPassword = "qwerty";
            userInfoPage = logInPage.LogInAs(UserLogin, UserPassword);
            userInfoPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.Displayed,
                "Logout is not working");
        }
    }
}
