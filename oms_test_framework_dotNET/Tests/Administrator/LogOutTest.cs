using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;

namespace oms_test_framework_dotNET.Tests.Administrator
{
    [TestClass]
    public class LogOutTest : TestRunner
    {
        private const String AdministratorLogin = "iva";
        private const String AdministratorPassword = "qwerty";

        [TestInitialize]
        public void SetUp()
        {
            userInfoPage = logInPage.LogInAs(AdministratorLogin, AdministratorPassword);
            administrationPage = userInfoPage.ClickAdministrationLink();
        }

        [TestMethod]
        public void testAdministrationPageLogOutAbility()
        {
            Assert.IsTrue(administrationPage.FoundUsersTextLabel.Displayed,
                "Administration page doesn't exist");
            administrationPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.Displayed,
                "Logout is not working");
        }

        [TestMethod]
        public void testCreateReportPageLogOutAbility()
        {
            administratorCreateReportPage = administrationPage.ClickCreateReportLink();
            Assert.IsTrue(administratorCreateReportPage.SaveReportLink.Displayed,
                "Create Report page doesn't exist");
            administratorCreateReportPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.Displayed,
                "Logout is not working");
        }

        [TestMethod]
        public void testCreateNewUserPageLogOutAbility()
        {
            createNewUserPage = administrationPage.ClickCreateNewUserLink();
            Assert.IsTrue(createNewUserPage.PageInfoText.Displayed,
                "Create new user page doesn't exists");
            createNewUserPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.Displayed,
                "Logout is not working");
        }

        [TestMethod]
        public void testEditUserPageLogOutAbility()
        {
            editUserPage = administrationPage.ClickEditFirstUserLink();
            Assert.IsTrue(editUserPage.NewPasswordText.Displayed,
                "Edit user page doesn't exists");
            editUserPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.Displayed,
                "Logout is not working");
        }
    }
}
