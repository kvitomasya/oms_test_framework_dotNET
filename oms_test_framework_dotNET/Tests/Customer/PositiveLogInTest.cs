using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Enums;
using static oms_test_framework_dotNET.Asserts.AbstractElementAsserts;

namespace oms_test_framework_dotNET.Tests.Customer
{
    [TestClass]
    public class PositiveLogInTest : TestRunner
    {

        [TestMethod]
        public void TestValidLogInCustomer()
        {
            userInfoPage = logInPage.LogInAs(Roles.CUSTOMER);
            AssertThat(userInfoPage.userInfoFieldSet).TextEquals("User Info");
        }
    }
}
