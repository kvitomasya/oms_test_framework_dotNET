using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Enums;

namespace oms_test_framework_dotNET.Tests
{
    [TestClass]
    public class LogOutTest : TestRunner
    {

        [TestMethod]
        public void TestLogInPageLogOutAbility()
        {
            logInPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.IsDisplayed(),
                "Logout is not working");
        }

        [TestMethod]
        public void TestUserInfoPageLogOutAbility()
        {
            userInfoPage = logInPage.LogInAs(Roles.CUSTOMER);
            userInfoPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.IsDisplayed(),
                "Logout is not working");
        }
    }
}
