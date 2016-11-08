using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Enums;
using static oms_test_framework_dotNET.Asserts.FluentAssert;

namespace oms_test_framework_dotNET.Tests
{
    [TestClass]
    public class LogOutTest : TestRunner
    {

        [TestMethod]
        public void TestLogInPageLogOutAbility()
        {
            logInPage.DoLogOut();

            AssertThat(logInPage.usernameInput).IsDisplayed();
        }

        [TestMethod]
        public void TestUserInfoPageLogOutAbility()
        {
            userInfoPage = logInPage.LogInAs(Roles.CUSTOMER);
            userInfoPage.DoLogOut();

            AssertThat(logInPage.usernameInput).IsDisplayed();
        }
    }
}
