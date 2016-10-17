using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;

namespace oms_test_framework_dotNET.Tests.Administrator
{
    [TestClass]
    public class PositiveLogInTest : TestRunner
    {
        [TestMethod]
        public void TestValidLogInAdministrator()
        {
        const string AdministratorName = "iva";
        const string AdministratorPassword = "qwerty";
        userInfoPage = logInPage.LogInAs(AdministratorName, AdministratorPassword);
            Assert.IsTrue(userInfoPage.UserInfoFieldSet.Text.Equals("User Info"), "Valid data are incorrect.");
        }
    }
}