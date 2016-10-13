using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;

namespace oms_test_framework_dotNET.Tests.Customer
{
    [TestClass]
    public class LogOutTest : TestRunner
    {
        private const String CustomerLogin = "vpopkin";
        private const String CustomerPassword = "qwerty";

        [TestInitialize]
        public void SetUp()
        {
            userInfoPage = logInPage.LogInAs(CustomerLogin, CustomerPassword);
            customerOrderingPage = userInfoPage.ClickCustomerOrderingLink();
        }

        [TestMethod]
        public void testCustomerOrderingPageLogOutAbility()
        {
            Assert.IsTrue(customerOrderingPage.CreateNewOrderLink.Displayed,
                "Customer Ordering page doesn't exist");
            customerOrderingPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.Displayed,
                "Logout is not working");
        }
    }
}
