using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Enums;
using oms_test_framework_dotNET.Utils;
using static oms_test_framework_dotNET.Asserts.AbstractElementAsserts;

namespace oms_test_framework_dotNET.Tests.Customer
{
    [TestClass]
    public class SwitchTabsTest : TestRunner
    {

        [TestInitialize]
        public void SetUpTest()
        {
            userInfoPage = logInPage.LogInAs(Roles.CUSTOMER);
        }

        [TestMethod]
        public void TestSwitchTabsAbility()
        {
            customerOrderingPage = userInfoPage.ClickCustomerOrderingLink();

            AssertThat(customerOrderingPage.createNewOrderLink).IsDisplayed();

            customerOrderingPage.ClickUserInfoLink();

            AssertThat(userInfoPage.userInfoFieldSet).IsDisplayed();
        }
    }
}
