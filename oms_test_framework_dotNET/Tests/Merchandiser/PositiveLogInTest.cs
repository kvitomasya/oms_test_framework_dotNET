using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;

namespace oms_test_framework_dotNET.Tests.Merchandiser
{
    [TestClass]
    public class PositiveLogInTest : TestRunner
    {
        [TestMethod]
        public void TestValidLogInMerchandiser()
        {
        const string MerchandiserName = "login1";
        const string MerchandiserPassword = "qwerty";
        userInfoPage = logInPage.LogInAs(MerchandiserName, MerchandiserPassword);
            Assert.IsTrue(userInfoPage.UserInfoFieldSet.Text.Equals("User Info"), "Login with merchandiser valid credentials is not successful");
        }
    }
}