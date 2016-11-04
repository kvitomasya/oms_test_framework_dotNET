using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Enums;

namespace oms_test_framework_dotNET.Tests.Merchandiser
{
    [TestClass]
    public class LogOutTest : TestRunner
    {

        [TestInitialize]
        public void SetUp()
        {
            userInfoPage = logInPage.LogInAs(Roles.MERCHANDISER);
            merchandiserOrderingPage = userInfoPage.ClickMerchandiserOrderingLink();
        }

        [TestMethod]
        public void TestMerchandiserOrderingPageLogOutAbility()
        {
            Assert.IsTrue(merchandiserOrderingPage.searchByText.IsDisplayed(),
                "Merchandiser Ordering page doesn't exist");
            merchandiserOrderingPage.DoLogOut();
            Assert.IsTrue(logInPage.usernameInput.IsDisplayed(),
                "Logout is not working");
        }

        [TestMethod]
        public void TestMerchandiserEditOrderPageLogOutAbility()
        {
            merchandiserEditOrderPage = merchandiserOrderingPage.ClickEditFirstOrderLink();
            Assert.IsTrue(merchandiserEditOrderPage.isGiftCheckbox.IsDisplayed(),
                "Merchandiser edit order page doesn't exist");
            merchandiserEditOrderPage.DoLogOut();
            Assert.IsTrue(logInPage.usernameInput.IsDisplayed(),
                "Logout is not working");
        }
    }
}
