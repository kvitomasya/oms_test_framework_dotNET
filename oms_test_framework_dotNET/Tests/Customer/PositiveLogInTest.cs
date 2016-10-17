using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;

namespace oms_test_framework_dotNET.Tests.Customer
{
    [TestClass]
    public class PositiveLogInTest : TestRunner
    {
        [TestMethod]
        public void TestValidLogInCustomer()
        {
        const string CustomerName = "login1";
        const string CustomerPassword = "qwerty";
        userInfoPage = logInPage.LogInAs(CustomerName, CustomerPassword);
            Assert.IsTrue(userInfoPage.UserInfoFieldSet.Text.Equals("User Info"), "Valid data are incorrect.");
        }
    }
}