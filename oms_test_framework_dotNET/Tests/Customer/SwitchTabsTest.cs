using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Enums;
using oms_test_framework_dotNET.Utils;

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
            Assert.IsTrue(customerOrderingPage.createNewOrderLink.IsDisplayed(), "Current page is not {0}", customerOrderingPage);
            customerOrderingPage.ClickUserInfoLink();
            Assert.IsTrue(userInfoPage.userInfoFieldSet.IsDisplayed(), "Current page is not {0}", userInfoPage);
        }
    }
}
