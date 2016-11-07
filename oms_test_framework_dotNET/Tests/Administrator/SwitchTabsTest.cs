using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Enums;
using oms_test_framework_dotNET.Utils;
using static oms_test_framework_dotNET.Asserts.FluentAsserts;

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

            AssertThat(administrationPage.foundUsersTextLabel).IsDisplayed();

            administrationPage.ClickUserInfoLink();

            AssertThat(userInfoPage.userInfoFieldSet).IsDisplayed();
        }
    }
}
