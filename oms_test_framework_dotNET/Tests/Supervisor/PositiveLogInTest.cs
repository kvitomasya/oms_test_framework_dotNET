using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;

namespace oms_test_framework_dotNET.Tests.Supervisor
{
    [TestClass]
    public class PositiveLogInTest : TestRunner
    {
        private const string SupervisorName = "login2";
        private const string SupervisorPassword = "qwerty";
        [TestMethod]
        public void TestValidLogInSupervisor()
        {
            userInfoPage = logInPage.LogInAs(SupervisorName, SupervisorPassword);
            Assert.IsTrue(userInfoPage.UserInfoFieldSet.Text.Equals("User Info"), "Valid data are incorrect.");
        }
    }
}
