using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;

namespace oms_test_framework_dotNET.Tests.Merchandiser
{
    [TestClass]
    public class LogOutTest : TestRunner
    {

        [TestInitialize]
        public void SetUp()
        {
            const String MerchandiserLogin = "login1";
            const String MerchandiserPassword = "qwerty";
            userInfoPage = logInPage.LogInAs(MerchandiserLogin, MerchandiserPassword);
            merchandiserOrderingPage = userInfoPage.ClickMerchandiserOrderingLink();
        }

        [TestMethod]
        public void TestMerchandiserOrderingPageLogOutAbility()
        {
            Assert.IsTrue(merchandiserOrderingPage.SearchByText.Displayed,
                "Merchandiser Ordering page doesn't exist");
            merchandiserOrderingPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.Displayed,
                "Logout is not working");
        }

        [TestMethod]
        public void TestMerchandiserEditOrderPageLogOutAbility()
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
