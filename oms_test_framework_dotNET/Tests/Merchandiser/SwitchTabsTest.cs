using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;

namespace oms_test_framework_dotNET.Tests.Merchandiser
{
    [TestClass]
    public class SwitchTabsTest : TestRunner
    {

        [TestInitialize]
        public void SetUpTest()
        {
            const string MerchandiserLogin = "login1";
            const string MerchandiserPassword = "qwerty";
            userInfoPage = logInPage.LogInAs(MerchandiserLogin, MerchandiserPassword);
        }

        [TestMethod]
        public void TestSwitchTabsAbility()
        {
            OnTestResult(() =>
            {
                merchandiserOrderingPage = userInfoPage.ClickMerchandiserOrderingLink();
                Assert.IsTrue(merchandiserOrderingPage.SearchByText.Displayed, "Current page is not {0}", merchandiserOrderingPage);
                merchandiserOrderingPage.ClickUserInfoLink();
                Assert.IsTrue(userInfoPage.UserInfoFieldSet.Displayed, "Current page is not {0}", userInfoPage);
            });
        }
    }
}
