using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Enums;
using oms_test_framework_dotNET.Utils;

namespace oms_test_framework_dotNET.Tests.Administrator
{
    [TestClass]
    public class SwitchTabsTest : TestRunner
    {

        [TestInitialize]
        public void SetUpTest()
        {
            userInfoPage = logInPage.LogInAs(Roles.ADMINISTRATOR);
        }

        [TestMethod]
        public void TestSwitchTabsAbility()
        {
            administrationPage = userInfoPage.ClickAdministrationLink();
            Assert.IsTrue(administrationPage.FoundUsersTextLabel.Displayed, "Current page is not {0}", administrationPage);
            administrationPage.ClickUserInfoLink();
            Assert.IsTrue(userInfoPage.UserInfoFieldSet.Displayed, "Current page is not {0}", userInfoPage);
        }
    }
}