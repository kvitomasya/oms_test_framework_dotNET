using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;

namespace oms_test_framework_dotNET.Tests.Merchandiser
{
    [TestClass]
    public class PositiveLogInTest : TestRunner
    {
        private const string MerchandiserName = "login1";
        private const string MerchandiserPassword = "qwerty";
        [TestMethod]
        public void TestValidLogInMerchandiser()
        {
            userInfoPage = logInPage.LogInAs(MerchandiserName, MerchandiserPassword);
            Assert.IsTrue(userInfoPage.UserInfoFieldSet.Text.Equals("User Info"), "Valid data are incorrect.");
        }
    }
}