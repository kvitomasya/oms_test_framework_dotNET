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
            OnTestResult(() =>
            {
                customerOrderingPage = userInfoPage.ClickCustomerOrderingLink();
                Assert.IsTrue(customerOrderingPage.CreateNewOrderLink.Displayed, "Current page is not {0}", customerOrderingPage);
                customerOrderingPage.ClickUserInfoLink();
                Assert.IsTrue(userInfoPage.UserInfoFieldSet.Displayed, "Current page is not {0}", userInfoPage);
            });
        }
    }
}
