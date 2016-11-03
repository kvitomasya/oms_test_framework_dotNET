using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Enums;

namespace oms_test_framework_dotNET.Tests.Supervisor
{
    [TestClass]
    public class PositiveLogInTest : TestRunner
    {

        [TestMethod]
        public void TestValidLogInSupervisor()
        {
            userInfoPage = logInPage.LogInAs(Roles.SUPERVISOR);
            Assert.IsTrue(userInfoPage.UserInfoFieldSet.GetText().Equals("User Info"), "Login with supervisor valid credentials is not successful");
        }
    }
}
