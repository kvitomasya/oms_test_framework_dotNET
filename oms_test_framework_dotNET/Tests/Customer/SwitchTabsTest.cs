using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;

namespace oms_test_framework_dotNET.Tests.Customer
{
    [TestClass]
    public class SwitchTabsTest : TestRunner
    {

        [TestInitialize]
        public void SetUpTest()
        {
            const string CusomerLogin = "vpopkin";
            const string CustomerPassword = "qwerty";
            userInfoPage = logInPage.LogInAs(CusomerLogin, CustomerPassword);
        }

        [TestMethod]
        public void TestSwitchTabsAbility()
        {
            customerOrderingPage = userInfoPage.ClickCustomerOrderingLink();
            Assert.IsTrue(customerOrderingPage.CreateNewOrderLink.Displayed, "Current page is not {0}", customerOrderingPage);
            customerOrderingPage.ClickUserInfoLink();
            Assert.IsTrue(userInfoPage.UserInfoFieldSet.Displayed, "Current page is not {0}", userInfoPage);
        }
    }
}
