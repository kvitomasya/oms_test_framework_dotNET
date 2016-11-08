using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Enums;
using oms_test_framework_dotNET.Utils;
using static oms_test_framework_dotNET.Asserts.FluentAssert;

namespace oms_test_framework_dotNET.Tests.Merchandiser
{
    [TestClass]
    public class SwitchTabsTest : TestRunner
    {

        [TestInitialize]
        public void SetUpTest()
        {
            userInfoPage = logInPage.LogInAs(Roles.MERCHANDISER);
        }

        [TestMethod]
        public void TestSwitchTabsAbility()
        {
            merchandiserOrderingPage = userInfoPage.ClickMerchandiserOrderingLink();

            AssertThat(merchandiserOrderingPage.searchByText).IsDisplayed();

            merchandiserOrderingPage.ClickUserInfoLink();

            AssertThat(userInfoPage.userInfoFieldSet).IsDisplayed();
        }
    }
}
