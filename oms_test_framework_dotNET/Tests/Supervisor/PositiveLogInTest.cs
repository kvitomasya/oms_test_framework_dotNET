using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;

namespace oms_test_framework_dotNET.Tests.Supervisor
{
    [TestClass]
    public class PositiveLogInTest : TestRunner
    {
        [TestMethod]
        public void TestValidLogInSupervisor()
        {
        const string SupervisorName = "login2";
        const string SupervisorPassword = "qwerty";
        userInfoPage = logInPage.LogInAs(SupervisorName, SupervisorPassword);
            Assert.IsTrue(userInfoPage.UserInfoFieldSet.Text.Equals("User Info"), "Login with supervisor valid credentials is not successful");
        }
    }
}
