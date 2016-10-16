using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;

namespace oms_test_framework_dotNET.Tests.Customer
{
    [TestClass]
    public class PositiveLogInTest : TestRunner
    {
        private const string CustomerName = "login1";
        private const string CustomerPassword = "qwerty";
        [TestMethod]
        public void TestValidLogInCustomer()
        {
            userInfoPage = logInPage.LogInAs(CustomerName, CustomerPassword);
            Assert.IsTrue(userInfoPage.UserInfoFieldSet.Text.Equals("User Info"), "Valid data are incorrect.");
        }
    }
}