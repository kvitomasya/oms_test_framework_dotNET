using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Enums;
using static oms_test_framework_dotNET.Asserts.FluentAssert;

namespace oms_test_framework_dotNET.Tests.Administrator
{
    [TestClass]
    public class LogOutTest : TestRunner
    {

        [TestInitialize]
        public void SetUp()
        {
            userInfoPage = logInPage.LogInAs(Roles.ADMINISTRATOR);
            administrationPage = userInfoPage.ClickAdministrationLink();
        }

        [TestMethod]
        public void TestAdministrationPageLogOutAbility()
        {
            AssertThat(administrationPage.foundUsersTextLabel).IsDisplayed();
            administrationPage.DoLogOut();
            AssertThat(logInPage.usernameInput).IsDisplayed();
        }

        [TestMethod]
        public void TestCreateReportPageLogOutAbility()
        {
            administratorCreateReportPage = administrationPage.ClickCreateReportLink();
            AssertThat(administratorCreateReportPage.saveReportLink).IsDisplayed();
            administratorCreateReportPage.DoLogOut();
            AssertThat(logInPage.usernameInput).IsDisplayed();
        }

        [TestMethod]
        public void TestCreateUserPageLogOutAbility()
        {
            createUserPage = administrationPage.ClickCreateNewUser();
            AssertThat(createUserPage.loginNameLabel).IsDisplayed();
            createUserPage.DoLogOut();
            AssertThat(logInPage.usernameInput).IsDisplayed();
        }

        [TestMethod]
        public void TestEditUserPageLogOutAbility()
        {
            editUserPage = administrationPage.ClickEditFirstUserLink();
            AssertThat(editUserPage.confirmPasswordText).IsDisplayed();
            editUserPage.DoLogOut();
            AssertThat(logInPage.usernameInput).IsDisplayed();
        }
    }
}
