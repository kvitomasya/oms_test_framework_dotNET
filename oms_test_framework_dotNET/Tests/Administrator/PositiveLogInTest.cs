using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;

namespace oms_test_framework_dotNET.Tests.Administrator
{
    [TestClass]
    public class PositiveLogInTest : TestRunner
    {
        private const string AdministratorName = "iva";
        private const string AdministratorPassword = "qwerty";
        [TestMethod]
        public void TestValidLogInAdministrator()
        {
            userInfoPage = logInPage.LogInAs(AdministratorName, AdministratorPassword);
            Assert.IsTrue(userInfoPage.UserInfoFieldSet.Text.Equals("User Info"), "Valid data are incorrect.");
        }
    }
}