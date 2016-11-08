using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Enums;
using static oms_test_framework_dotNET.Asserts.FluentAssert;

namespace oms_test_framework_dotNET.Tests.Supervisor
{
    [TestClass]
    public class PositiveLogInTest : TestRunner
    {

        [TestMethod]
        public void TestValidLogInSupervisor()
        {
            userInfoPage = logInPage.LogInAs(Roles.SUPERVISOR);
            AssertThat(userInfoPage.userInfoFieldSet).TextEquals("User Info");
        }
    }
}
