using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Enums;
using oms_test_framework_dotNET.Utils;

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
            Assert.IsTrue(merchandiserOrderingPage.SearchByText.Displayed, "Current page is not {0}", merchandiserOrderingPage);
            merchandiserOrderingPage.ClickUserInfoLink();
            Assert.IsTrue(userInfoPage.UserInfoFieldSet.Displayed, "Current page is not {0}", userInfoPage);
        }
    }
}
