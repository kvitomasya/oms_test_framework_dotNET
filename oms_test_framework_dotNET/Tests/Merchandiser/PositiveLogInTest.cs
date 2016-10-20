using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Enums;

namespace oms_test_framework_dotNET.Tests.Merchandiser
{
    [TestClass]
    public class PositiveLogInTest : TestRunner
    {
        [TestMethod]
        public void TestValidLogInMerchandiser()
        {
            userInfoPage = logInPage.LogInAs(Roles.MERCHANDISER);
            Assert.IsTrue(userInfoPage.UserInfoFieldSet.Text.Equals("User Info"), "Login with merchandiser valid credentials is not successful");
        }
    }
}