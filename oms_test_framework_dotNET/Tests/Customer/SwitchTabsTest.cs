using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;

namespace oms_test_framework_dotNET.Tests.Customer
{
    [TestClass]
     public class SwitchTabsTest : TestRunner
    {
        private const string CusomerLogin = "vpopkin";
        private const string CustomerPassword = "qwerty";
        
        [TestInitialize]
        public void SetUpTest()
        {

            userInfoPage = logInPage.LogInAs(CusomerLogin, CustomerPassword);

        }

        [TestMethod]
        public void TestSwitchTabsAbility()
        {

            customerOrderingPage = userInfoPage.ClickCustomerOrdetingLink();
            Assert.IsTrue(customerOrderingPage.CreateNewOrderLink.Displayed, "Current page is not {0}", customerOrderingPage);
            customerOrderingPage.ClickUserInfoLink();
            Assert.IsTrue(userInfoPage.UserInfoFieldSet.Displayed, "Current page is not {0}", userInfoPage);

        }
    }
}
