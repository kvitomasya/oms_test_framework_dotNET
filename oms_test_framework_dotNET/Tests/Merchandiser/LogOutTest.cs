using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Enums;
using static oms_test_framework_dotNET.Asserts.FluentAssert;

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
            AssertThat(merchandiserOrderingPage.searchByText).IsDisplayed();

            merchandiserOrderingPage.DoLogOut();

            AssertThat(logInPage.usernameInput).IsDisplayed();
        }

        [TestMethod]
        public void TestMerchandiserEditOrderPageLogOutAbility()
        {
            merchandiserEditOrderPage = merchandiserOrderingPage.ClickEditFirstOrderLink();

            AssertThat(merchandiserEditOrderPage.isGiftCheckbox).IsDisplayed();

            merchandiserEditOrderPage.DoLogOut();

            AssertThat(logInPage.usernameInput).IsDisplayed();
        }
    }
}
