using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Enums;

namespace oms_test_framework_dotNET.Tests.Administrator
{
    [TestClass]
    public class PositiveLogInTest : TestRunner
    {
        [TestMethod]
        public void TestValidLogInAdministrator()
        {
            OnTestResult(() =>
            {
                userInfoPage = logInPage.LogInAs(Roles.ADMINISTRATOR);
                Assert.IsTrue(userInfoPage.UserInfoFieldSet.Text.Equals("User Info"), "Login with administrator valid credentials is not successful");
            });
        }
    }
}