using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Enums;
using static oms_test_framework_dotNET.Asserts.AbstractElementAsserts;


namespace oms_test_framework_dotNET.Tests.Merchandiser
{
    [TestClass]
    public class PositiveLogInTest : TestRunner
    {

        [TestMethod]
        public void TestValidLogInMerchandiser()
        {
            userInfoPage = logInPage.LogInAs(Roles.MERCHANDISER);
            AssertThat(userInfoPage.userInfoFieldSet).TextEquals("User Info");
        }
    }
}
