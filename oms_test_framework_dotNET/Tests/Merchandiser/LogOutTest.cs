using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;

namespace oms_test_framework_dotNET.Tests.Merchandiser
{
    [TestClass]
    public class LogOutTest : TestRunner
    {
        private const String MerchandiserLogin = "login1";
        private const String MerchandiserPassword = "qwerty";

        [TestInitialize]
        public void SetUp()
        {
            userInfoPage = logInPage.LogInAs(MerchandiserLogin, MerchandiserPassword);
            merchandiserOrderingPage = userInfoPage.ClickMerchandiserOrderingLink();
        }

        [TestMethod]
        public void testMerchandiserOrderingPageLogOutAbility()
        {
            Assert.IsTrue(merchandiserOrderingPage.SearchByTextLabel.Displayed,
                "Merchandiser Ordering page doesn't exist");
            merchandiserOrderingPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.Displayed,
                "Logout is not working");
        }

        [TestMethod]
        public void testMerchandiserEditOrderPageLogOutAbility()
        {
            merchandiserEditOrderPage = merchandiserOrderingPage.ClickEditFirstOrderLink();
            Assert.IsTrue(merchandiserEditOrderPage.IsGiftCheckbox.Displayed,
                "Merchandiser edit order page doesn't exist");
            merchandiserEditOrderPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.Displayed,
                "Logout is not working");
        }
    }
}
